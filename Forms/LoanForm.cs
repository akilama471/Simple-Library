using SarasaviLibrary.Data;
using SarasaviLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarasaviLibrary.Forms
{
    public partial class LoanForm : Form
    {
        private DataTable _loanTable;

        public LoanForm()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            _loanTable = new DataTable();
            _loanTable.Columns.Add("CopyId", typeof(int));
            _loanTable.Columns.Add("Copy Number", typeof(string));
            _loanTable.Columns.Add("Book Name", typeof(string));
            _loanTable.Columns.Add("Loan Date", typeof(DateTime));
            _loanTable.Columns.Add("Due Date", typeof(DateTime));

            dataGridView1.DataSource = _loanTable;
            dataGridView1.Columns["CopyId"].Visible = false; // Hide ID column

            // Wire up Add button
            btnAddBookToBorrow.Click += BtnAddBookToBorrow_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void BtnAddBookToBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = memberNICInputField.Text.Trim();
                if (string.IsNullOrWhiteSpace(nic))
                {
                    MessageBox.Show("Please enter Member NIC first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Rule 1: First click / First item check
                if (_loanTable.Rows.Count == 0)
                {
                    MemberRepository memberRepo = new MemberRepository();
                    Member member = memberRepo.GetByNIC(nic);

                    if (member == null)
                    {
                        MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    LoanRepository loanRepo = new LoanRepository();
                    if (loanRepo.HasOverdueLoans(member.MemberId))
                    {
                        MessageBox.Show("This member has overdue books. Please return them before borrowing new ones.", "Overdue Books Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }

                // Rule 3: Max 5 records in grid
                if (_loanTable.Rows.Count >= 5)
                {
                    MessageBox.Show("You can only add up to 5 books per loan session.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string copyNumber = bookCopyInputField.Text.Trim();
                if (string.IsNullOrEmpty(copyNumber))
                {
                    MessageBox.Show("Please enter a Copy Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if already in list
                foreach (DataRow row in _loanTable.Rows)
                {
                    if (row["Copy Number"].ToString() == copyNumber)
                    {
                        MessageBox.Show("This copy is already added to the list.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                BookRepository bookRepo = new BookRepository();
                Copy copy = bookRepo.GetCopyByNumber(copyNumber);

                if (copy == null)
                {
                    MessageBox.Show("Book copy not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!copy.IsAvailable)
                {
                    MessageBox.Show("This copy is currently borrowed.", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (copy.IsReferenceOnly)
                {
                    MessageBox.Show("Reference-only copies cannot be borrowed.", "Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string bookTitle = GetBookTitleForCopy(copy.CopyId);

                // Add to table
                _loanTable.Rows.Add(copy.CopyId, copy.CopyNumber, bookTitle, DateTime.Now, DateTime.Now.AddDays(14));
                
                // Rule 2: Disable NIC input after first addition
                memberNICInputField.Enabled = false;

                bookCopyInputField.Clear();
                bookCopyInputField.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetBookTitleForCopy(int copyId)
        {
            // Simple helper to get title if repository mapping is incomplete
            string query = "SELECT b.Title FROM Books b JOIN Copies c ON b.BookId = c.BookId WHERE c.CopyId = @CopyId";
            object title = DatabaseHelper.ExecuteScalar(query, new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@CopyId", copyId) });
            return title?.ToString() ?? "Unknown Title";
        }

        private void BtnLoan_Click(object sender, EventArgs e)
        {
            if (_loanTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one book to borrow.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nic = memberNICInputField.Text.Trim();
            if (string.IsNullOrWhiteSpace(nic))
            {
                MessageBox.Show("Please enter Member NIC.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MemberRepository memberRepo = new MemberRepository();
                Member member = memberRepo.GetByNIC(nic);

                if (member == null)
                {
                    MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoanRepository loanRepo = new LoanRepository();
                
                // Rules check for total loans
                int activeLoans = loanRepo.GetActiveLoanCount(member.MemberId);
                if (activeLoans + _loanTable.Rows.Count > 5)
                {
                    MessageBox.Show($"Member cannot borrow more than 5 books in total. (Currently has {activeLoans} active loans)", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (loanRepo.HasOverdueLoans(member.MemberId))
                {
                    MessageBox.Show("Member has overdue books. Cannot borrow new books.", "Overdue Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Process all books in the grid
                foreach (DataRow row in _loanTable.Rows)
                {
                    Loan loan = new Loan
                    {
                        CopyId = Convert.ToInt32(row["CopyId"]),
                        MemberId = member.MemberId,
                        LoanDate = Convert.ToDateTime(row["Loan Date"]),
                        DueDate = Convert.ToDateTime(row["Due Date"])
                    };
                    loanRepo.AddLoan(loan);
                }

                MessageBox.Show($"Loan processed successfully for {_loanTable.Rows.Count} books.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing loan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

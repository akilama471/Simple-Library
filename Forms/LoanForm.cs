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
        private Label lblMemberNIC;
        private TextBox txtMemberNIC;
        private Label lblCopyNumber;
        private TextBox txtCopyNumber;
        private Button btnLoan;
        private Button btnCancel;

        public LoanForm()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            this.Size = new Size(400, 250);
            this.Text = "Borrow Book";
            this.StartPosition = FormStartPosition.CenterParent;

            lblMemberNIC = new Label { Text = "Member NIC:", Location = new Point(20, 30), AutoSize = true };
            txtMemberNIC = new TextBox { Location = new Point(120, 27), Width = 200 };

            lblCopyNumber = new Label { Text = "Copy Number:", Location = new Point(20, 70), AutoSize = true };
            txtCopyNumber = new TextBox { Location = new Point(120, 67), Width = 200 };

            btnLoan = new Button { Text = "Loan", Location = new Point(120, 120), Width = 90, Height = 30 };
            btnCancel = new Button { Text = "Cancel", Location = new Point(230, 120), Width = 90, Height = 30 };

            btnLoan.Click += BtnLoan_Click;
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.Add(lblMemberNIC);
            this.Controls.Add(txtMemberNIC);
            this.Controls.Add(lblCopyNumber);
            this.Controls.Add(txtCopyNumber);
            this.Controls.Add(btnLoan);
            this.Controls.Add(btnCancel);
        }

        private void BtnLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMemberNIC.Text) || string.IsNullOrWhiteSpace(txtCopyNumber.Text))
                {
                    MessageBox.Show("Please enter Member NIC and Copy Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MemberRepository memberRepo = new MemberRepository();
                Member member = memberRepo.GetByNIC(txtMemberNIC.Text.Trim());

                if (member == null)
                {
                    MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoanRepository loanRepo = new LoanRepository();
                
                // Rule 1: Max 5 books
                int activeLoans = loanRepo.GetActiveLoanCount(member.MemberId);
                if (activeLoans >= 5)
                {
                    MessageBox.Show("Member has reached maximum limit of 5 borrowed books.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Rule 2: No overdue books
                if (loanRepo.HasOverdueLoans(member.MemberId))
                {
                    MessageBox.Show("Member has overdue books. Cannot borrow new books.", "Overdue Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check Copy availability
                BookRepository bookRepo = new BookRepository();
                Copy copy = bookRepo.GetCopyByNumber(txtCopyNumber.Text.Trim());

                if (copy == null)
                {
                    MessageBox.Show("Book copy not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int copyId = copy.CopyId;
                bool isAvailable = copy.IsAvailable;
                bool isReferenceOnly = copy.Book.IsReferenceOnly;

                // Rule 3: Available
                if (!isAvailable)
                {
                    MessageBox.Show("This copy is currently borrowed.", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Rule 4: Reference only
                if (isReferenceOnly)
                {
                    MessageBox.Show("Reference-only books cannot be borrowed.", "Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create Loan
                Loan loan = new Loan
                {
                    CopyId = copyId,
                    MemberId = member.MemberId,
                    LoanDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(14) // Rule: 14 days
                };

                loanRepo.AddLoan(loan);

                MessageBox.Show($"Loan successful! Due date: {loan.DueDate.ToShortDateString()}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing loan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

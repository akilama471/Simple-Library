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
    public partial class ReturnForm : Form
    {
        private Label lblCopyNumber;
        private TextBox txtCopyNumber;
        private Button btnCheck;
        private Button btnReturn;
        private Button btnCancel;
        private Label lblInfo;
        private int _currentLoanId = -1;

        public ReturnForm()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            this.Size = new Size(400, 300);
            this.Text = "Return Book";
            this.StartPosition = FormStartPosition.CenterParent;

            lblCopyNumber = new Label { Text = "Copy Number:", Location = new Point(20, 30), AutoSize = true };
            txtCopyNumber = new TextBox { Location = new Point(120, 27), Width = 150 };
            btnCheck = new Button { Text = "Check", Location = new Point(280, 25), Width = 80 };

            lblInfo = new Label { Text = "", Location = new Point(20, 70), Size = new Size(350, 60), BorderStyle = BorderStyle.FixedSingle };

            btnReturn = new Button { Text = "Return Book", Location = new Point(120, 150), Width = 100, Height = 30, Enabled = false };
            btnCancel = new Button { Text = "Cancel", Location = new Point(230, 150), Width = 90, Height = 30 };

            btnCheck.Click += BtnCheck_Click;
            btnReturn.Click += BtnReturn_Click;
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.Add(lblCopyNumber);
            this.Controls.Add(txtCopyNumber);
            this.Controls.Add(btnCheck);
            this.Controls.Add(lblInfo);
            this.Controls.Add(btnReturn);
            this.Controls.Add(btnCancel);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCopyNumber.Text))
                {
                    MessageBox.Show("Please enter Copy Number.");
                    return;
                }

                LoanRepository loanRepo = new LoanRepository();
                Loan loan = loanRepo.GetActiveLoanByCopyNumber(txtCopyNumber.Text.Trim());

                if (loan != null)
                {
                    _currentLoanId = loan.LoanId;
                    
                    lblInfo.Text = $"Borrowed by: {loan.Member.Name} (NIC: {loan.Member.NIC})\nDue Date: {loan.DueDate.ToShortDateString()}\nStatus: Active Loan";
                    btnReturn.Enabled = true;
                }
                else
                {
                    lblInfo.Text = "No active loan found for this copy.";
                    _currentLoanId = -1;
                    btnReturn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking loan: {ex.Message}");
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (_currentLoanId == -1) return;

            try
            {
                LoanRepository loanRepo = new LoanRepository();
                loanRepo.ReturnLoan(_currentLoanId);

                // Check reservations
                // Get BookId from CopyNumber to check reservations? 
                // Need to query reservation logic.
                // For now, adhering to basic return logic.
                // Reservation check logic:
                // 1. Get BookId of returned copy.
                // 2. Check Reservations table for that BookId.
                // 3. If exists, notify (MessageBox).
                // 4. Delete oldest reservation.
                
                CheckReservations(txtCopyNumber.Text.Trim());

                MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckReservations(string copyNumber)
        {
             ReservationRepository resRepo = new ReservationRepository();
             Reservation res = resRepo.GetOldestReservationByCopyNumber(copyNumber);

             if (res != null)
             {
                 // Notify
                 MemberRepository memberRepo = new MemberRepository();
                 Member member = memberRepo.GetById(res.MemberId);
                 MessageBox.Show($"Book is reserved by {member.Name} (NIC: {member.NIC}). Please notify them.", "Reservation Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 // Delete reservation
                 resRepo.Remove(res.ReservationId);
             }
        }
    }
}

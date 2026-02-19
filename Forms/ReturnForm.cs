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
        private int _currentLoanId = -1;

        public ReturnForm()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
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

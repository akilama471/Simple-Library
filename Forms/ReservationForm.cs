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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
            
            // Wire up event
            btnReserveBook.Click += BtnReserveBook_Click;
        }

        private void BtnReserveBook_Click(object sender, EventArgs e)
        {
            string nic = memberNICInputField.Text.Trim();
            string copyNumber = bookCopyInputField.Text.Trim();

            if (string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(copyNumber))
            {
                MessageBox.Show("Please enter both Member NIC and Book Copy Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Validate Member
                Data.MemberRepository memberRepo = new Data.MemberRepository();
                Models.Member member = memberRepo.GetByNIC(nic);
                if (member == null)
                {
                    MessageBox.Show("Member not found with the provided NIC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Validate Book Copy and get BookId
                Data.BookRepository bookRepo = new Data.BookRepository();
                Models.Copy copy = bookRepo.GetCopyByNumber(copyNumber);
                if (copy == null)
                {
                    MessageBox.Show("Book copy not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Logic Check: Reservation is usually for books that are not available
                if (copy.IsAvailable)
                {
                    DialogResult result = MessageBox.Show(
                        "This book copy is currently available for loan. Members should ideally borrow available books instead of reserving them.\n\nDo you still want to proceed with the reservation?", 
                        "Copy Available", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);
                    
                    if (result == DialogResult.No) return;
                }

                // 4. Create Reservation
                Models.Reservation reservation = new Models.Reservation
                {
                    BookId = copy.BookId,
                    MemberId = member.MemberId,
                    ReservationDate = DateTime.Now
                };

                Data.ReservationRepository resRepo = new Data.ReservationRepository();
                resRepo.Add(reservation);

                MessageBox.Show("Book reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating reservation: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            memberNICInputField.Clear();
            bookCopyInputField.Clear();
            memberNICInputField.Focus();
        }
    }
}

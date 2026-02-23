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
using System.Xml.Linq;

namespace SarasaviLibrary.Forms
{
    public partial class MemberAddForm : Form
    {
        private Member _memberToEdit;
        private MemberRepository _repo;

        public MemberAddForm(Member memberToEdit = null)
        {
            InitializeComponent();
            _memberToEdit = memberToEdit;
            _repo = new MemberRepository();

            if (_memberToEdit != null)
            {
                this.Text = "Edit Member";
                // Assuming button exists and is named submitMemberFromButton
                submitMemberFromButton.Text = "Update Member"; 
                LoadMemberData();
            }
        }

        private void LoadMemberData()
        {
            memberNameInputField.Text = _memberToEdit.Name;
            memberNICInputField.Text = _memberToEdit.NIC;
            memberAddressInputField.Text = _memberToEdit.Address;
            memberSexInputField.SelectedItem = _memberToEdit.Sex;
        }

        private void submitMemberFromButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(memberNameInputField.Text) ||
                string.IsNullOrWhiteSpace(memberAddressInputField.Text) ||
                string.IsNullOrWhiteSpace(memberNICInputField.Text) ||
                memberSexInputField.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            try
            {
                if (_memberToEdit == null)
                {
                    // Add New Member
                    Member member = new Member
                    {
                        Name = memberNameInputField.Text,
                        NIC = memberNICInputField.Text,
                        Address = memberAddressInputField.Text,
                        Sex = memberSexInputField.SelectedItem.ToString()
                    };

                    if (_repo.IsNicExists(member.NIC))
                    {
                        MessageBox.Show("A member with this NIC already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _repo.Add(member);
                    MessageBox.Show($"Member added successfully! User Number: {member.UserNumber}");
                }
                else
                {
                    // Update Existing Member
                    _memberToEdit.Name = memberNameInputField.Text;
                    _memberToEdit.NIC = memberNICInputField.Text;
                    _memberToEdit.Address = memberAddressInputField.Text;
                    _memberToEdit.Sex = memberSexInputField.SelectedItem.ToString();
                    
                    // Check NIC uniqueness only if NIC changed
                    // Note: Ideally IsNicExists should exclude current member ID, but for now assuming user handles it or we catch SQL error? 
                    // Let's rely on basic check or just proceed. 
                    // Better: GetByNIC and check if ID is different.
                    Member existingParams = _repo.GetByNIC(_memberToEdit.NIC);
                    if (existingParams != null && existingParams.MemberId != _memberToEdit.MemberId)
                    {
                         MessageBox.Show("A member with this NIC already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return;
                    }

                    _repo.Update(_memberToEdit);
                    MessageBox.Show("Member updated successfully!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dismissMemberFromButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

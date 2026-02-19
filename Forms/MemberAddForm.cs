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
        public MemberAddForm()
        {
            InitializeComponent();
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

            // Create Member object
            Member member = new Member
            {
                Name = memberNameInputField.Text,
                NIC = memberNICInputField.Text,
                Address = memberAddressInputField.Text,
                Sex = memberSexInputField.SelectedItem.ToString()
            };

            // Save to database
            MemberRepository repo = new MemberRepository();

            try
            {
                if (repo.IsNicExists(member.NIC))
                {
                    MessageBox.Show("A member with this NIC already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                repo.Add(member);
                MessageBox.Show("Member added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

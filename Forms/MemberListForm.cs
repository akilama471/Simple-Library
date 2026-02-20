using SarasaviLibrary.Data;
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
    public partial class MemberListForm : Form
    {
        public MemberListForm()
        {
            InitializeComponent();
        }

        private void LoadMembers()
        {
            MemberRepository repo = new MemberRepository();
            List<SarasaviLibrary.Models.Member> members = repo.GetAll();
            memberDataGridView.DataSource = members;
        }

        private void MemberListForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void OpenAddMemberButton_Click(object sender, EventArgs e)
        {
            MemberAddForm addForm = new MemberAddForm();
            addForm.ShowDialog();
            LoadMembers();
        }

        private void EditSelectedMemberButton_Click(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedRows.Count > 0)
            {
                SarasaviLibrary.Models.Member selectedMember = (SarasaviLibrary.Models.Member)memberDataGridView.SelectedRows[0].DataBoundItem;
                MemberAddForm editForm = new MemberAddForm(selectedMember);
                editForm.ShowDialog();
                LoadMembers();
            }
            else
            {
                MessageBox.Show("Please select a member to edit.");
            }
        }

        private void DeleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedRows.Count > 0)
            {
                SarasaviLibrary.Models.Member selectedMember = (SarasaviLibrary.Models.Member)memberDataGridView.SelectedRows[0].DataBoundItem;
                
                DialogResult result = MessageBox.Show($"Are you sure you want to delete member {selectedMember.Name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        MemberRepository repo = new MemberRepository();
                        repo.Delete(selectedMember.MemberId);
                        LoadMembers();
                        MessageBox.Show("Member deleted successfully.");
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        if (ex.Number == 547) // Foreign Key violation
                        {
                            MessageBox.Show("Cannot delete this member because they have active loans or other related records.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"Error deleting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a member to delete.");
            }
        }
    }
}

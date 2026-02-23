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
    public partial class AuthorListForm : Form
    {
        public AuthorListForm()
        {
            InitializeComponent();
        }

        private void LoadAuthors()
        {
            AuthorRepository repo = new AuthorRepository();
            List<SarasaviLibrary.Models.Author> authors = repo.GetAll();
            authorDataGridView.DataSource = authors;

            // Optional: Hide unnecessary columns if they exist
            if (authorDataGridView.Columns.Contains("BookCount"))
                authorDataGridView.Columns["BookCount"].HeaderText = "Books";
        }

        private void AuthorListForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }

        private void OpenAddAuthorButton_Click(object sender, EventArgs e)
        {
            using (AuthorAddForm form = new AuthorAddForm())
            {
                form.ShowDialog();
                LoadAuthors();
            }
        }

        private void EditSelectedAuthorButton_Click(object sender, EventArgs e)
        {
            if (authorDataGridView.SelectedRows.Count > 0)
            {
                var author = (SarasaviLibrary.Models.Author)authorDataGridView.SelectedRows[0].DataBoundItem;
                using (AuthorAddForm form = new AuthorAddForm(author))
                {
                    form.ShowDialog();
                    LoadAuthors();
                }
            }
            else
            {
                MessageBox.Show("Please select an author to edit.");
            }
        }

        private void DeleteSelectedAuthorButton_Click(object sender, EventArgs e)
        {
            if (authorDataGridView.SelectedRows.Count > 0)
            {
                var author = (SarasaviLibrary.Models.Author)authorDataGridView.SelectedRows[0].DataBoundItem;
                
                if (author.BookCount > 0)
                {
                    MessageBox.Show($"Cannot delete author '{author.Name}' because they have {author.BookCount} books associated with them.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"Are you sure you want to delete author '{author.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        AuthorRepository repo = new AuthorRepository();
                        repo.Delete(author.AuthorId);
                        LoadAuthors();
                        MessageBox.Show("Author deleted successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting author: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an author to delete.");
            }
        }
    }
}

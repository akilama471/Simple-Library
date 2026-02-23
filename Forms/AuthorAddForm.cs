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
    public partial class AuthorAddForm : Form
    {
        private Author _editingAuthor;

        public AuthorAddForm()
        {
            InitializeComponent();
        }

        public AuthorAddForm(Author author) : this()
        {
            _editingAuthor = author;
            authorNameInputField.Text = author.Name;
            this.Text = "Edit Author";
            submitAuthorFromButton.Text = "Update";
        }

        private void submitAuthorFromButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorNameInputField.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            AuthorRepository repo = new AuthorRepository();

            try
            {
                if (_editingAuthor == null)
                {
                    // Add new author
                    Author newAuthor = new Author { Name = authorNameInputField.Text };
                    repo.Add(newAuthor);
                    MessageBox.Show("Author added successfully!");
                }
                else
                {
                    // Update existing author
                    _editingAuthor.Name = authorNameInputField.Text;
                    repo.Update(_editingAuthor);
                    MessageBox.Show("Author updated successfully!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving author: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dismissAuthorFromButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

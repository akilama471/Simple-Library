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
        public AuthorAddForm()
        {
            InitializeComponent();
        }

        private void submitAuthorFromButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(authorNameInputField.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            // Create Member object
            Author author = new Author
            {
                Name = authorNameInputField.Text,
            };

            // Save to database
            AuthorRepository repo = new AuthorRepository();

            string error;
            bool success = repo.AddAuthor(author, out error);

            if (success)
            {
                MessageBox.Show("Author added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class BookAddForm : Form
    {
        public BookAddForm()
        {
            InitializeComponent();
            LoadMetadata();
            materialSingleLineTextField1.Enabled = false;
            materialSingleLineTextField1.Text = "Auto-Generated";
        }

        private void LoadMetadata()
        {
            try
            {
                // Load Authors
                AuthorRepository authorRepo = new AuthorRepository();
                List<Author> authors = authorRepo.GetAll();
                comboBox1.DataSource = authors;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "AuthorId";
                comboBox1.SelectedIndex = -1;

                // Load Publishers
                PublisherRepository publisherRepo = new PublisherRepository();
                List<Publisher> publishers = publisherRepo.GetAll();
                comboBox2.DataSource = publishers;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "PublisherId";
                comboBox2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBook()
        {
            if (string.IsNullOrWhiteSpace(bookNameInputField.Text) ||
                string.IsNullOrWhiteSpace(bookISBNInputField.Text) || // ISBN Check
                comboBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields (Title, Author, Publisher, ISBN).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Book book = new Book
                {
                     // BookNumber is auto-generated in Repository
                    Title = bookNameInputField.Text,
                    AuthorId = (int)comboBox1.SelectedValue,
                    PublisherId = (int)comboBox2.SelectedValue,
                    Classification = bookClassificationInputField.Text,
                    ISBN = bookISBNInputField.Text,
                    Edition = bookEditionInputField.Text,
                    // Note: IsReferenceOnly on Book is legacy/default, actual check is on Copy
                    IsReferenceOnly = bookRefferanceInputField.Checked,
                    Copies = new List<Copy>()
                };

                foreach (DataGridViewRow row in bookCopyGrid.Rows)
                {
                    if (row.Cells.Count > 1 && row.Cells[0].Value != null)
                    {
                        bool isRefOnly = row.Cells[1].Value != null && Convert.ToBoolean(row.Cells[1].Value);
                        book.Copies.Add(new Copy
                        {
                            IsAvailable = true,
                            IsReferenceOnly = isRefOnly
                        });
                    }
                }

                BookRepository repo = new BookRepository();
                repo.Add(book);

                MessageBox.Show($"Book added successfully!\nBook Number: {book.BookNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                // Check for Unique Constraint Violation (Error 2627 or 2601)
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("ISBN"))
                    {
                        MessageBox.Show("A book with this ISBN already exists. ISBN must be unique.", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("A duplicate record exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBookCopyButton_Click(object sender, EventArgs e)
        {

            // Create copies
            int copyCount = (int)bookCopyCountInputField.Value;
            int rowCount = (int)bookCopyGrid.Rows.Count;

            if (copyCount > 10 || rowCount > 10 || copyCount + rowCount > 10)
            {
                MessageBox.Show("Maximum 10 copies allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (copyCount > 0)
            {
                for (int i = 1; i <= copyCount; i++)
                {
                    bookCopyGrid.Rows.Add(rowCount + i,bookRefferanceInputField.Checked);
                }
            }
        }

        private void bookCopyGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (bookCopyCountInputField.Value > bookCopyCountInputField.Minimum)
            {
                bookCopyCountInputField.Value = bookCopyGrid.Rows.Count;
            }
        }

        private void bookRefferanceInputField_CheckedChanged(object sender, EventArgs e)
        {
            if (bookRefferanceInputField.Checked)
            {
                foreach (DataGridViewRow row in bookCopyGrid.Rows)
                {
                    if (row.Cells.Count > 1)
                    {
                        row.Cells[1].Value = true;
                    }
                }
            }
        }

        private void bookCopyGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        private void bookCopyGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var val = bookCopyGrid.Rows[e.RowIndex].Cells[1].Value;
                bool isChecked = val != null && Convert.ToBoolean(val);
                if (!isChecked)
                {
                    bookRefferanceInputField.Checked = false;
                }
            }
        }
    }
}

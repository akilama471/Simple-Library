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
            // Disable Book Number input as it is auto-generated
            materialSingleLineTextField1.Enabled = false;
            materialSingleLineTextField1.Text = "Auto-Generated";
            button2.Click += AddButton_Click;
            button1.Click += CancelButton_Click;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(materialSingleLineTextField2.Text) ||
                string.IsNullOrWhiteSpace(isbnTextField.Text) || // ISBN Check
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
                    Title = materialSingleLineTextField2.Text,
                    AuthorId = (int)comboBox1.SelectedValue,
                    PublisherId = (int)comboBox2.SelectedValue,
                    Classification = materialSingleLineTextField3.Text, 
                    ISBN = isbnTextField.Text,
                    Edition = editionTextField.Text,
                    // Note: IsReferenceOnly on Book is legacy/default, actual check is on Copy
                    IsReferenceOnly = materialCheckBox1.Checked 
                };

                // Create copies
                int copyCount = (int)numericUpDown1.Value;
                if (copyCount > 10)
                {
                    MessageBox.Show("Maximum 10 copies allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (copyCount > 0)
                {
                    for (int i = 1; i <= copyCount; i++)
                    {
                        book.Copies.Add(new Copy
                        {
                            // CopyNumber prefix will be updated in Repository
                            CopyNumber = $"TEMP-{i}",
                            IsAvailable = true,
                            IsReferenceOnly = materialCheckBox1.Checked // Apply checkbox to initial copies
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
    }
}

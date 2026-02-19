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
            if (string.IsNullOrWhiteSpace(materialSingleLineTextField1.Text) || 
                string.IsNullOrWhiteSpace(materialSingleLineTextField2.Text) ||
                comboBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields (Book Number, Title, Author, Publisher).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Book book = new Book
                {
                    BookNumber = materialSingleLineTextField1.Text,
                    Title = materialSingleLineTextField2.Text,
                    AuthorId = (int)comboBox1.SelectedValue,
                    PublisherId = (int)comboBox2.SelectedValue,
                    Classification = materialSingleLineTextField3.Text, // Using Version Year field as Classification for now
                    IsReferenceOnly = materialCheckBox1.Checked
                };

                // Create copies
                int copyCount = (int)numericUpDown1.Value;
                if (copyCount > 10)
                {
                    MessageBox.Show("Maximum 10 copies allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 1; i <= copyCount; i++)
                {
                    book.Copies.Add(new Copy
                    {
                        CopyNumber = $"{book.BookNumber}-{i}",
                        IsAvailable = true
                    });
                }

                BookRepository repo = new BookRepository();
                repo.Add(book);

                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

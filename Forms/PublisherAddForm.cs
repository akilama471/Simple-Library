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
    public partial class PublisherAddForm : Form
    {
        private Publisher _editingPublisher;

        public PublisherAddForm()
        {
            InitializeComponent();
        }

        public PublisherAddForm(Publisher publisher) : this()
        {
            _editingPublisher = publisher;
            publisherNameInputField.Text = publisher.Name;
            this.Text = "Edit Publisher";
            submitPublisherFromButton.Text = "Update";
        }

        private void submitPublisherFromButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(publisherNameInputField.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            PublisherRepository repo = new PublisherRepository();

            try
            {
                if (_editingPublisher == null)
                {
                    // Add new publisher
                    Publisher newPublisher = new Publisher { Name = publisherNameInputField.Text };
                    repo.Add(newPublisher);
                    MessageBox.Show("Publisher added successfully!");
                }
                else
                {
                    // Update existing publisher
                    _editingPublisher.Name = publisherNameInputField.Text;
                    repo.Update(_editingPublisher);
                    MessageBox.Show("Publisher updated successfully!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving publisher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dismissPublisherFromButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

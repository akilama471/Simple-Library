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
        public PublisherAddForm()
        {
            InitializeComponent();
        }

        private void submitPublisherFromButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(publisherNameInputField.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            // Create Publisher object
            Publisher publisher = new Publisher
            {
                Name = publisherNameInputField.Text,
            };

            // Save to database
            PublisherRepository repo = new PublisherRepository();

            try
            {
                repo.Add(publisher);
                MessageBox.Show("Publisher added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding publisher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dismissPublisherFromButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

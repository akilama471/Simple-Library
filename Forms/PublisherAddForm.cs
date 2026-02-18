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

            // Create Member object
            Publisher publisher = new Publisher
            {
                Name = publisherNameInputField.Text,
            };

            // Save to database
            PublisherRepository repo = new PublisherRepository();

            string error;
            bool success = repo.AddPublisher(publisher, out error);

            if (success)
            {
                MessageBox.Show("Publisher added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

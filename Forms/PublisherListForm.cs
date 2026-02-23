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
    public partial class PublisherListForm : Form
    {
        public PublisherListForm()
        {
            InitializeComponent();
        }

        private void LoadPublishers()
        {
            PublisherRepository repo = new PublisherRepository();
            List<SarasaviLibrary.Models.Publisher> publishers = repo.GetAll();

            publisherDataGridView.DataSource = publishers;

            // Optional: Customize columns
            if (publisherDataGridView.Columns.Contains("BookCount"))
                publisherDataGridView.Columns["BookCount"].HeaderText = "Books";
        }

        private void PublisherListForm_Load(object sender, EventArgs e)
        {
            LoadPublishers();
        }

        private void OpenAddPublisherButton_Click(object sender, EventArgs e)
        {
            using (PublisherAddForm form = new PublisherAddForm())
            {
                form.ShowDialog();
                LoadPublishers();
            }
        }

        private void EditSelectedPublisherButton_Click(object sender, EventArgs e)
        {
            if (publisherDataGridView.SelectedRows.Count > 0)
            {
                var publisher = (SarasaviLibrary.Models.Publisher)publisherDataGridView.SelectedRows[0].DataBoundItem;
                using (PublisherAddForm form = new PublisherAddForm(publisher))
                {
                    form.ShowDialog();
                    LoadPublishers();
                }
            }
            else
            {
                MessageBox.Show("Please select a publisher to edit.");
            }
        }

        private void DeleteSelectedPublisherButton_Click(object sender, EventArgs e)
        {
            if (publisherDataGridView.SelectedRows.Count > 0)
            {
                var publisher = (SarasaviLibrary.Models.Publisher)publisherDataGridView.SelectedRows[0].DataBoundItem;

                if (publisher.BookCount > 0)
                {
                    MessageBox.Show($"Cannot delete publisher '{publisher.Name}' because they have {publisher.BookCount} books associated with them.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"Are you sure you want to delete publisher '{publisher.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        PublisherRepository repo = new PublisherRepository();
                        repo.Delete(publisher.PublisherId);
                        LoadPublishers();
                        MessageBox.Show("Publisher deleted successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting publisher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a publisher to delete.");
            }
        }
    }
}

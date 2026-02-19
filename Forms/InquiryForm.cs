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
    public partial class InquiryForm : Form
    {

        public InquiryForm()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchType = "Title";
                if (rdoAuthor.Checked) searchType = "Author";
                else if (rdoCopy.Checked) searchType = "CopyNumber";

                BookRepository repo = new BookRepository();
                DataTable results = repo.SearchBooks(txtSearch.Text.Trim(), searchType);

                dataGridView1.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

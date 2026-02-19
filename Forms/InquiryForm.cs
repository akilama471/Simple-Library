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
        private TextBox txtSearch;
        private Button btnSearch;
        private RadioButton rdoTitle;
        private RadioButton rdoAuthor;
        private RadioButton rdoCopy;
        private DataGridView dataGridView1;

        public InquiryForm()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            this.Size = new Size(800, 500);
            this.Text = "Book Inquiry";
            this.StartPosition = FormStartPosition.CenterParent;

            Label lblSearch = new Label { Text = "Search:", Location = new Point(20, 20), AutoSize = true };
            txtSearch = new TextBox { Location = new Point(80, 17), Width = 200 };
            btnSearch = new Button { Text = "Search", Location = new Point(300, 15), Width = 80 };

            rdoTitle = new RadioButton { Text = "Title", Location = new Point(400, 20), Checked = true, AutoSize = true };
            rdoAuthor = new RadioButton { Text = "Author", Location = new Point(460, 20), AutoSize = true };
            rdoCopy = new RadioButton { Text = "Copy Num", Location = new Point(530, 20), AutoSize = true };

            dataGridView1 = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(740, 380),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            btnSearch.Click += BtnSearch_Click;

            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnSearch);
            this.Controls.Add(rdoTitle);
            this.Controls.Add(rdoAuthor);
            this.Controls.Add(rdoCopy);
            this.Controls.Add(dataGridView1);
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

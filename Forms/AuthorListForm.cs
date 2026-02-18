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
    public partial class AuthorListForm : Form
    {
        public AuthorListForm()
        {
            InitializeComponent();
        }
        private void LoadAuthors()
        {
            AuthorRepository repo = new AuthorRepository();
            DataTable dt = repo.GetAllAuthors();

            authorDataGridView.DataSource = dt;
        }

        private void AuthorListForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }
    }
}

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
            List<SarasaviLibrary.Models.Author> authors = repo.GetAll();

            // Convert List to DataTable or use BindingSource if needed, but direct list binding works for grids mostly.
            // However, to match previous behavior if it expected DataTable, we might need to adjust.
            // Let's bind the List directly.
            authorDataGridView.DataSource = authors;
        }

        private void AuthorListForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }
    }
}

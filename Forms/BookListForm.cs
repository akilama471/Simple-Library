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
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
        }

        private void LoadBooks()
        {
            BookRepository repo = new BookRepository();
            // Now fetching COPIES, not just Books
            List<SarasaviLibrary.Models.Copy> copies = repo.GetAllCopies();
            
            // We might need a flat view model, but for now specific columns bindings should work 
            // if we manually map or if the grid supports nested properties (it usually doesn't strictly support "Book.Title" without work).
            // To be safe and quick, let's shape the data or hide columns.
            // Actually, standard DataGridView doesn't support "Book.Title" data property directly.
            // We need a projection or a flattened list.
            
            var displayList = copies.Select(c => new 
            {
                c.CopyId,
                c.CopyNumber,
                Title = c.Book.Title,
                Author = c.Book.Author.Name,
                Publisher = c.Book.Publisher.Name,
                ISBN = c.Book.ISBN,
                Edition = c.Book.Edition,
                IsReferenceOnly = c.IsReferenceOnly ? "Yes" : "No",
                Status = c.IsAvailable ? "Available" : "Borrowed"
            }).ToList();

            bookDataGridView.DataSource = displayList;

            // Configure columns
            if (bookDataGridView.Columns["CopyId"] != null)
                bookDataGridView.Columns["CopyId"].Visible = false;

            // Ensure headers are nice
            if (bookDataGridView.Columns["CopyNumber"] != null)
                bookDataGridView.Columns["CopyNumber"].HeaderText = "Copy Number";

            if (bookDataGridView.Columns["IsReferenceOnly"] != null)
                bookDataGridView.Columns["IsReferenceOnly"].HeaderText = "Reference Only";
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}

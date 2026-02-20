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
            searchBookButton.Click += SearchBookButton_Click;
        }

        private async Task LoadFilterDataAsync()
        {
            try
            {
                if (this.MdiParent is MainForm main)
                {
                    main.ShowLoadingProgress(true);
                }

                // Run db queries on a background thread
                var data = await Task.Run(() =>
                {
                    BookRepository bookRepo = new BookRepository();
                    AuthorRepository authorRepo = new AuthorRepository();
                    PublisherRepository publisherRepo = new PublisherRepository();
                    
                    return new 
                    {
                        Copies = bookRepo.SearchBooks(null, null, null, null), // Initial load
                        Books = bookRepo.GetAll(),
                        Authors = authorRepo.GetAll(),
                        Publishers = publisherRepo.GetAll()
                    };
                });

                // Bind Book Name ComboBox
                var booksList = data.Books.Select(b => b.Title).Distinct().ToList();
                booksList.Insert(0, "-- All Books --");
                searchBookNameInput.DataSource = booksList;

                // Bind Author ComboBox
                var authorsList = data.Authors.ToList();
                authorsList.Insert(0, new Models.Author { AuthorId = 0, Name = "-- All Authors --" });
                searchBookAuthorInput.DataSource = authorsList;
                searchBookAuthorInput.DisplayMember = "Name";
                searchBookAuthorInput.ValueMember = "AuthorId";
                searchBookAuthorInput.SelectedIndex = 0;

                // Bind Publisher ComboBox
                var publishersList = data.Publishers.ToList();
                publishersList.Insert(0, new Models.Publisher { PublisherId = 0, Name = "-- All Publishers --" });
                searchBookPublisherInput.DataSource = publishersList;
                searchBookPublisherInput.DisplayMember = "Name";
                searchBookPublisherInput.ValueMember = "PublisherId";
                searchBookPublisherInput.SelectedIndex = 0;

                // Bind Grid
                BindGridData(data.Copies);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error");
            }
            finally
            {
                if (this.MdiParent is MainForm main)
                {
                    main.ShowLoadingProgress(false);
                }
            }
        }

        private async void SearchBookButton_Click(object sender, EventArgs e)
        {
            string number = searchBookNumberInput.Text.Trim();
            string name = searchBookNameInput.Text.Trim();
            int? authorId = searchBookAuthorInput.SelectedValue as int?;
            int? publisherId = searchBookPublisherInput.SelectedValue as int?;

            // Reset IDs if the user selected the "-- All --" default options
            if (authorId == 0) authorId = null;
            if (publisherId == 0) publisherId = null;

            try
            {
                if (this.MdiParent is MainForm main)
                {
                    main.ShowLoadingProgress(true);
                }

                BookRepository repo = new BookRepository();
                DataTable results = await Task.Run(() => repo.SearchBooks(number, name, authorId, publisherId));
                
                BindGridData(results);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Error");
            }
            finally
            {
                if (this.MdiParent is MainForm main)
                {
                    main.ShowLoadingProgress(false);
                }
            }
        }

        private void BindGridData(DataTable data)
        {
            bookDataGridView.DataSource = data;
            
            if (bookDataGridView.Columns.Count > 0)
            {
                bookDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private async void BookListForm_Load(object sender, EventArgs e)
        {
            await LoadFilterDataAsync();
        }
    }
}

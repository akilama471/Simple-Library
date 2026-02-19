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


        private void LoadAuthors()
        {
            PublisherRepository repo = new PublisherRepository();
            List<SarasaviLibrary.Models.Publisher> publishers = repo.GetAll();

            publisherDataGridView.DataSource = publishers;
        }

        private void PublisherListForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }
    }
}

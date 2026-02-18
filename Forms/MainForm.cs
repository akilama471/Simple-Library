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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addMemberRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is MemberAddForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            MemberAddForm memberAdd = new MemberAddForm();
            memberAdd.MdiParent = this;
            memberAdd.StartPosition = FormStartPosition.CenterParent;
            memberAdd.Show();
        }

        private void addPublisherRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is PublisherAddForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            PublisherAddForm publisherAdd = new PublisherAddForm();
            publisherAdd.MdiParent = this;
            publisherAdd.StartPosition = FormStartPosition.CenterParent;
            publisherAdd.Show();

        }

        private void addAuthorRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is AuthorAddForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            AuthorAddForm authorAdd = new AuthorAddForm();
            authorAdd.MdiParent = this;
            authorAdd.StartPosition = FormStartPosition.CenterParent;
            authorAdd.Show();
        }

        private void addBookRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is BookAddForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            BookAddForm bookAdd = new BookAddForm();
            bookAdd.MdiParent = this;
            bookAdd.StartPosition = FormStartPosition.CenterParent;
            bookAdd.Show();
        }

        private void findMemberRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is MemberListForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            MemberListForm memberList = new MemberListForm();
            memberList.MdiParent = this;
            memberList.StartPosition = FormStartPosition.CenterParent;
            memberList.Show();
        }

        private void findPublisherRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is PublisherListForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            PublisherListForm publisherList = new PublisherListForm();
            publisherList.MdiParent = this;
            publisherList.StartPosition = FormStartPosition.CenterParent;
            publisherList.Show();
        }

        private void findAuthorRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is AuthorListForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            AuthorListForm authorList = new AuthorListForm();
            authorList.MdiParent = this;
            authorList.StartPosition = FormStartPosition.CenterParent;
            authorList.Show();
        }
    }
}

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
            InitializeMenu();
        }

        private void InitializeMenu(){}
        

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

        private void InquiryRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is InquiryForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            InquiryForm inquiryForm = new InquiryForm();
            inquiryForm.MdiParent = this;
            inquiryForm.StartPosition = FormStartPosition.CenterParent;
            inquiryForm.Show();
        }

        private void loanRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is LoanForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            LoanForm loanForm = new LoanForm();
            loanForm.MdiParent = this;
            loanForm.StartPosition = FormStartPosition.CenterParent;
            loanForm.Show();
        }

        private void returnRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is ReturnForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            ReturnForm returnForm = new ReturnForm();
            returnForm.MdiParent = this;
            returnForm.StartPosition = FormStartPosition.CenterParent;
            returnForm.Show();
        }

        private void findBookRibbonButton_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is BookListForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            BookListForm bookListForm = new BookListForm();
            bookListForm.MdiParent = this;
            bookListForm.StartPosition = FormStartPosition.CenterParent;
            bookListForm.Show();
        }

        private void borrowBookHistoryRibbonButton_Click(object sender, EventArgs e)
        {

            foreach (Form child in this.MdiChildren)
            {
                if (child is ReportForm)
                {
                    child.Focus(); // Bring it to front
                    return;        // Exit, don’t open new
                }
            }
            ReportForm reportForm = new ReportForm();
            reportForm.MdiParent = this;
            reportForm.StartPosition = FormStartPosition.CenterParent;
            reportForm.Show();
        }
    }
}

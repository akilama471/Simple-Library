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
    public partial class MemberListForm : Form
    {
        public MemberListForm()
        {
            InitializeComponent();
        }
        private void LoadMembers()
        {
            MemberRepository repo = new MemberRepository();
            List<SarasaviLibrary.Models.Member> members = repo.GetAll();

            memberDataGridView.DataSource = members;
        }

        private void MemberListForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }
    }
}

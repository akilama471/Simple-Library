using SarasaviLibrary.Services;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameInput.Text.Trim();
            string password = txtPasswordInput.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Services.AuthService.ValidateLogin(username, password))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPasswordInput.Clear();
                    txtPasswordInput.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login:\n\n{ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

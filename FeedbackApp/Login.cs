using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                if (username == "Admin" && password == "admin987")
                {
                    this.Hide();
                    new Admin().Show();

                }
                else if (username == "User" && password == "user987")
                {
                    this.Hide();
                    new User().Show();

                }
                else if (username == "" && password == "")
                {
                    MessageBox.Show("Username and password cannot be empty.");
                }
                else if (username == "")
                {
                    MessageBox.Show("Username cannot be empty.");
                }
                else if (password == "")
                {
                    MessageBox.Show("Password cannot be empty.");
                }
                else
                {
                    MessageBox.Show("Please enter correct username and password.");
                }
            }
            catch
            {
                MessageBox.Show("Unexpected Exception.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Username_Click(object sender, MouseEventArgs e)
        {
            txtUsername.Clear();
        }

        private void Password_Click(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }
    }
}

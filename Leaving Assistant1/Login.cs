using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaving_Assistant1
{
    public partial class Login : Form
    {
        public static string type;
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            {
                type = "admin";
                this.Hide();
                Admin ad = new Admin();
                ad.Show();
            }
            else
            {
                type = "user";
                this.Hide();
                User us = new User();
                us.Show();
            }
        }

        private void CPassword_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.ShowDialog();
        }
    }
}

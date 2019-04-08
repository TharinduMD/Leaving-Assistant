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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            dashBoard1.BringToFront();
            labelTitle1.Text = "Dashboard";
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            dashBoard1.BringToFront();
            labelTitle1.Text = "Dashboard";
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            calendar1.BringToFront();
            labelTitle1.Text = "Request a Leave";
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            todayOnline1.BringToFront();
            labelTitle1.Text = "Who are Coming Today to Work";
        }

        private void btnUs_Click(object sender, EventArgs e)
        {
            aboutUs1.BringToFront();
            labelTitle1.Text = "About";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

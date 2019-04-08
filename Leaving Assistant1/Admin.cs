using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Leaving_Assistant1
{
    public partial class Admin : Form
    {
        static int n=1;
        public Admin()
        {
            InitializeComponent();

            dashBoard1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        private void btnDash_Click(object sender, EventArgs e)
        {
            dashBoard1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            calendar1.BringToFront();
            labelTitle.Text = "Calendar";
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            addUsers1.BringToFront();
            labelTitle.Text = "Add Users to the Database"; 
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            todayOnline1.BringToFront();
            labelTitle.Text = "Who are Coming Today to Work";
        }

        private void btnUs_Click(object sender, EventArgs e)
        {
            aboutUs1.BringToFront();
            labelTitle.Text = "About";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        System.Timers.Timer newtimer = new System.Timers.Timer(3000);
        private void Admin_Load(object sender, EventArgs e)
        {
            newtimer.Elapsed += UpdateLabel;
            newtimer.Start();
        }
        private void UpdateLabel(object sender,ElapsedEventArgs e)
            
        {
            if (ControlInvokeRequired(Notification, () => UpdateLabel(sender, e))) return;
            Notification.Text = n.ToString();
            n++;
        }
        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;
            return true;
        }  
    }
}

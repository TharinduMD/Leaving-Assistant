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
    public partial class ViewLeave : Form
    {
        public ViewLeave()
        {
            InitializeComponent();
        }

        public ViewLeave(string date, string month, string year)
        {
            InitializeComponent();
            dateLabel.Text = date + " " + month + " " + year;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Alert at = new Alert("Leave Accepted", AlertType.success);
            at.BackColor = Color.Blue;
            at.Show();

            this.Close();
        }

        private void btnDenied_Click(object sender, EventArgs e)
        {
            Alert at = new Alert("Leave Denied", AlertType.cancel);
            at.Show();

            this.Close();
        }
    }
}

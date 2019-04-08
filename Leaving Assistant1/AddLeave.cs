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
    public partial class AddLeave : Form
    {
        public AddLeave()
        {
            InitializeComponent();
        }
        public AddLeave(String date,String month,String year)
        {
            InitializeComponent();
            txtDate.Text = date+" "+month+" "+year;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtReason.Text = "";
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            this.Close();

            
            DateTime dt1 = DateTime.Now;
            

            CustomDialog cd = new CustomDialog();
            cd.ShowDialog();

            /*DialogWrong dw = new DialogWrong();
            dw.ShowDialog();*/
        }
    }
}

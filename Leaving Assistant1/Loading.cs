using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaving_Assistant1
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        
        private void Loading_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            FlatButton1.Visible = true;
           
        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
        }

    }
}

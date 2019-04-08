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
    public partial class DialogWrong : Form
    {
        public DialogWrong()
        {
            InitializeComponent();
        }

        private void DialogWrong_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            timer1.Start();
            icon.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            timer1.Stop();
            btnok.Visible = true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

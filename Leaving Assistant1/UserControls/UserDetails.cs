using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaving_Assistant1.UserControls
{
    public partial class UserDetails : UserControl
    {
        ViewLeave vl = new ViewLeave();
        public UserDetails()
        {
            InitializeComponent();
            //vl.Visible = false;
        }

        private void ThinButtonOk_Click(object sender, EventArgs e)
        {
           //vl.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Leaving_Assistant1.UserControls
{
    public partial class AddUsers : UserControl
    {
        
        public AddUsers()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtID.Text = "";
            txtMobile.Text = "";
            txtHome.Text = "";
            DropdownOccupation.Text = "";
            DropdownGender.Text = "";

            Alert at = new Alert("Added Cancel", AlertType.warning);
            at.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Alert at = new Alert("Added Success", AlertType.success);
            at.Show();


        }

        private void txtMobile_OnValueChanged(object sender, EventArgs e)
        {
            string telNo = txtMobile.Text;
            if (Regex.Match(telNo, @"^(\+[0-9])$").Success)
            {
                errorProvider1.Clear();
            }
            else
                errorProvider1.SetError(txtMobile, "Enter a proper phone number!");
        }
    }
}

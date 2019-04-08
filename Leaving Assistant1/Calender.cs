using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaving_Assistant
{
    public partial class Calender : UserControl
    {
        
        Button []btnarray;
        string monthnme;
        int clickday;
        int yearname;
        int monthname;
        int dayname;
        public Calender()
        {
            InitializeComponent();
            btnarray = new Button[] {btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9,btn10,btn11,btn12,btn13,btn14,btn15,btn16,btn17,btn18,btn19,btn20,btn21,btn22,btn23,btn24,
            btn25,btn26,btn27,btn28,btn29,btn30,btn31,btn32,btn33,btn34,btn35,btn36,btn37,btn38};

            DateTime today = DateTime.Today;
            convert(today);
           
        }
        public int day()
        {
            return clickday;
        }
        public int month()
        {
            return monthname;
        }
        public int year()
        {
            return yearname;
        }
        void click(int click)
        {
            clickday = click;
        }
        private void convert(DateTime ob)
        {
            string []part = ob.ToString("dd-MM-yyyy").Split('-');
            yearname =Convert.ToInt32( part[2]);
            monthname =Convert.ToInt32(part[1]) ;
            dayname = Convert.ToInt32(part[0]);
            
            monthdetails(monthname,yearname);

            if (dayname == Convert.ToInt32(DateTime.Today.ToString("dd")))
                    presentmonthdate(dayname);
        }
        private void presentmonthdate(int day)
        {
            DateTime dd = new DateTime(yearname, monthname, day);
            lbl2.Text = dd.DayOfWeek.ToString();
            clickday = day;
            if (day.ToString() == "1" || day.ToString() == "2" || day.ToString() == "3" || day.ToString() == "4" || day.ToString() == "5" || day.ToString() == "6" ||
                day.ToString() == "7" || day.ToString() == "8" || day.ToString() == "9")
            {
                lbl1.Text = "0"+day.ToString();
            }
            else
            {
                lbl1.Text = day.ToString();
            }
            
            lbl3.Text = monthnme.ToString();
            lbl4.Text = yearname.ToString();

            for (int index = 0; index < btnarray.Length; index++)
            {
                if (btnarray[index].Text == day.ToString())
                {
                    btnarray[index].BackColor = Color.FromArgb(39, 174, 96);
                    btnarray[index].ForeColor = Color.Black;
                }
            }
        }
        private void monthdetails(int month, int year)
        {
            int startday = 0;

            DateTime dd = new DateTime(year, month, 1);
            startday = Convert.ToInt16(dd.DayOfWeek);
            int daysinmonth = DateTime.DaysInMonth(year, month);

            System.Globalization.DateTimeFormatInfo mfi = new System.Globalization.DateTimeFormatInfo();
            monthnme = mfi.GetMonthName(month).ToString();
            label1.Text = monthnme.ToString();
            label9.Text=yearname.ToString();
           
           

            for (int index = 0; index <btnarray.Length; index++)
            {
                btnarray[index].Text = "";
            }

            for(int index=1;index<=daysinmonth;index++)
            {
                btnarray[startday].Text = index.ToString();
                startday++;
            }
            for (int index = 0; index < btnarray.Length; index++)
            {
                if (btnarray[index].Text != "")
                    btnarray[index].Show();
                else
                    btnarray[index].Hide();

            }
        }

        private void changecolor(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
                return;

            clickday = Convert.ToInt32(button.Text);
            
            if(button.Text=="1"||button.Text=="2"||button.Text=="3"||button.Text=="4"||button.Text=="5"||button.Text=="6"||
                button.Text=="7"||button.Text=="8"||button.Text=="9")
            {
                lbl1.Text = "0"+button.Text;
            }
            else
            {
                lbl1.Text = button.Text;
            }
            DateTime dd = new DateTime(yearname, monthname, Convert.ToInt16(button.Text));
            string day = dd.DayOfWeek.ToString();
            lbl2.Text = day.ToString();
            lbl3.Text = monthnme;
            lbl4.Text = yearname.ToString();

            for (int index = 0; index < btnarray.Length; index++)
            {
                if (button == btnarray[index])
                {
                    btnarray[index].BackColor = Color.FromArgb(39, 174, 96);
                }
                else
                {
                    btnarray[index].BackColor = Color.Transparent;
                }
                    
            }

        }

        private void picbx2_Click(object sender, EventArgs e)
        {
            DateTime dat = new DateTime(yearname, monthname, 1);
             dat = dat.AddMonths(1);
             convert(dat);

             for (int index = 0; index < btnarray.Length; index++)
             {
                 btnarray[index].BackColor = Color.Transparent;
             }
        }

        private void picbx1_Click(object sender, EventArgs e)
        {
            DateTime dat = new DateTime(yearname, monthname, 1);
            dat = dat.AddMonths(-1);
            convert(dat);

            for (int index = 0; index < btnarray.Length; index++)
            {
                btnarray[index].BackColor = Color.Transparent;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void todaybtn_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            convert(today);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn38_Click(object sender, EventArgs e)
        {

        }

        private void btn37_Click(object sender, EventArgs e)
        {

        }

        private void btn36_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
           
        }

        private void all_btn(object sender, EventArgs e)
        {
            //this.Hide();
            Button btn = (Button)sender;
            Leaving_Assistant1.AddLeave addl = new Leaving_Assistant1.AddLeave();
            addl.Show();
            Console.WriteLine(btn.Text);
            Leaving_Assistant1.Form1 f1 = new Leaving_Assistant1.Form1();
            //f1.Hide();
        }
       
    }
}

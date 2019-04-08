namespace Leaving_Assistant1
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUs = new System.Windows.Forms.Button();
            this.btnOnline = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.calendar1 = new Leaving_Assistant1.UserControls.calendar();
            this.aboutUs1 = new Leaving_Assistant1.UserControls.aboutUs();
            this.todayOnline1 = new Leaving_Assistant1.UserControls.TodayOnline();
            this.dashBoard1 = new Leaving_Assistant1.UserControls.DashBoard();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnUs);
            this.panel1.Controls.Add(this.btnOnline);
            this.panel1.Controls.Add(this.btnLeave);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 478);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnUs
            // 
            this.btnUs.FlatAppearance.BorderSize = 0;
            this.btnUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUs.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUs.Location = new System.Drawing.Point(0, 333);
            this.btnUs.Name = "btnUs";
            this.btnUs.Size = new System.Drawing.Size(197, 52);
            this.btnUs.TabIndex = 5;
            this.btnUs.Text = "About";
            this.btnUs.UseVisualStyleBackColor = true;
            this.btnUs.Click += new System.EventHandler(this.btnUs_Click);
            // 
            // btnOnline
            // 
            this.btnOnline.FlatAppearance.BorderSize = 0;
            this.btnOnline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOnline.Location = new System.Drawing.Point(0, 275);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(197, 52);
            this.btnOnline.TabIndex = 4;
            this.btnOnline.Text = "Today Online";
            this.btnOnline.UseVisualStyleBackColor = true;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLeave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLeave.Location = new System.Drawing.Point(0, 217);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(197, 52);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "Request Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnDash
            // 
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDash.Location = new System.Drawing.Point(0, 159);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(197, 52);
            this.btnDash.TabIndex = 2;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 17);
            this.panel2.TabIndex = 1;
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitle1.Location = new System.Drawing.Point(212, 21);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(108, 22);
            this.labelTitle1.TabIndex = 3;
            this.labelTitle1.Text = "Dashboard";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.calendar1);
            this.panel3.Controls.Add(this.aboutUs1);
            this.panel3.Controls.Add(this.todayOnline1);
            this.panel3.Controls.Add(this.dashBoard1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(197, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 429);
            this.panel3.TabIndex = 8;
            // 
            // calendar1
            // 
            this.calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar1.Location = new System.Drawing.Point(0, 0);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(739, 429);
            this.calendar1.TabIndex = 3;
            // 
            // aboutUs1
            // 
            this.aboutUs1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutUs1.BackgroundImage")));
            this.aboutUs1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutUs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUs1.Location = new System.Drawing.Point(0, 0);
            this.aboutUs1.Name = "aboutUs1";
            this.aboutUs1.Size = new System.Drawing.Size(739, 429);
            this.aboutUs1.TabIndex = 2;
            // 
            // todayOnline1
            // 
            this.todayOnline1.AutoScroll = true;
            this.todayOnline1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todayOnline1.BackgroundImage")));
            this.todayOnline1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.todayOnline1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todayOnline1.Location = new System.Drawing.Point(0, 0);
            this.todayOnline1.Name = "todayOnline1";
            this.todayOnline1.Size = new System.Drawing.Size(739, 429);
            this.todayOnline1.TabIndex = 1;
            // 
            // dashBoard1
            // 
            this.dashBoard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.dashBoard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashBoard1.BackgroundImage")));
            this.dashBoard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoard1.Location = new System.Drawing.Point(0, 0);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(739, 429);
            this.dashBoard1.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(866, 14);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(23, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 10;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(896, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(936, 478);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelTitle1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUs;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private UserControls.DashBoard dashBoard1;
        private UserControls.TodayOnline todayOnline1;
        private UserControls.aboutUs aboutUs1;
        private UserControls.calendar calendar1;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
    }
}
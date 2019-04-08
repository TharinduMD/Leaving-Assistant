namespace Leaving_Assistant1
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.version = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.FlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.version.Location = new System.Drawing.Point(363, 172);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(105, 21);
            this.version.TabIndex = 2;
            this.version.Text = "Version 1.0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 0;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // FlatButton1
            // 
            this.FlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.FlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatButton1.BorderRadius = 1;
            this.FlatButton1.ButtonText = "LOGIN";
            this.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatButton1.DisabledColor = System.Drawing.Color.Black;
            this.FlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.FlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("FlatButton1.Iconimage")));
            this.FlatButton1.Iconimage_right = null;
            this.FlatButton1.Iconimage_right_Selected = null;
            this.FlatButton1.Iconimage_Selected = null;
            this.FlatButton1.IconMarginLeft = 0;
            this.FlatButton1.IconMarginRight = 0;
            this.FlatButton1.IconRightVisible = true;
            this.FlatButton1.IconRightZoom = 0D;
            this.FlatButton1.IconVisible = true;
            this.FlatButton1.IconZoom = 60D;
            this.FlatButton1.IsTab = false;
            this.FlatButton1.Location = new System.Drawing.Point(162, 213);
            this.FlatButton1.Name = "FlatButton1";
            this.FlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.FlatButton1.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.FlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.FlatButton1.selected = false;
            this.FlatButton1.Size = new System.Drawing.Size(179, 64);
            this.FlatButton1.TabIndex = 3;
            this.FlatButton1.Text = "LOGIN";
            this.FlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlatButton1.Textcolor = System.Drawing.Color.White;
            this.FlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.FlatButton1.Visible = false;
            this.FlatButton1.Click += new System.EventHandler(this.FlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Loading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 315);
            this.Controls.Add(this.FlatButton1);
            this.Controls.Add(this.version);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuFlatButton FlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


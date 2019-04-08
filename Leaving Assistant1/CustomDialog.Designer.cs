namespace Leaving_Assistant1
{
    partial class CustomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDialog));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnok = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
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
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 0;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // icon
            // 
            this.icon.Enabled = false;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(13, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(337, 210);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnok
            // 
            this.btnok.ActiveBorderThickness = 1;
            this.btnok.ActiveCornerRadius = 20;
            this.btnok.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnok.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnok.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnok.BackColor = System.Drawing.Color.White;
            this.btnok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnok.BackgroundImage")));
            this.btnok.ButtonText = "OK";
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnok.IdleBorderThickness = 1;
            this.btnok.IdleCornerRadius = 30;
            this.btnok.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnok.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnok.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnok.Location = new System.Drawing.Point(112, 276);
            this.btnok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(135, 57);
            this.btnok.TabIndex = 1;
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnok.Visible = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "LEAVE SENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomDialog";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomDialog";
            this.Load += new System.EventHandler(this.CustomDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnok;
        private System.Windows.Forms.Label label1;
    }
}
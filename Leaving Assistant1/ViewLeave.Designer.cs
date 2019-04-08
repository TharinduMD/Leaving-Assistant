namespace Leaving_Assistant1
{
    partial class ViewLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLeave));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.descrip = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.btnDenied = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAccept = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(97, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requested Leave";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 90);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(404, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(156, 110);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 25);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID No";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.BackColor = System.Drawing.Color.Transparent;
            this.lblOccupation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOccupation.Location = new System.Drawing.Point(160, 140);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(106, 21);
            this.lblOccupation.TabIndex = 3;
            this.lblOccupation.Text = "Occupation";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // descrip
            // 
            this.descrip.AutoSize = true;
            this.descrip.BackColor = System.Drawing.Color.Transparent;
            this.descrip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.descrip.Location = new System.Drawing.Point(39, 344);
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(94, 19);
            this.descrip.TabIndex = 25;
            this.descrip.Text = "description";
            // 
            // reason
            // 
            this.reason.AutoSize = true;
            this.reason.BackColor = System.Drawing.Color.Transparent;
            this.reason.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.reason.Location = new System.Drawing.Point(39, 281);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(132, 19);
            this.reason.TabIndex = 24;
            this.reason.Text = "reason for leave";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateLabel.Location = new System.Drawing.Point(232, 204);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 21);
            this.dateLabel.TabIndex = 23;
            // 
            // btnDenied
            // 
            this.btnDenied.ActiveBorderThickness = 1;
            this.btnDenied.ActiveCornerRadius = 20;
            this.btnDenied.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDenied.ActiveForecolor = System.Drawing.Color.White;
            this.btnDenied.ActiveLineColor = System.Drawing.Color.Black;
            this.btnDenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(10)))), ((int)(((byte)(23)))));
            this.btnDenied.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDenied.BackgroundImage")));
            this.btnDenied.ButtonText = "DENIED";
            this.btnDenied.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDenied.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenied.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDenied.IdleBorderThickness = 1;
            this.btnDenied.IdleCornerRadius = 20;
            this.btnDenied.IdleFillColor = System.Drawing.Color.Red;
            this.btnDenied.IdleForecolor = System.Drawing.Color.White;
            this.btnDenied.IdleLineColor = System.Drawing.Color.Black;
            this.btnDenied.Location = new System.Drawing.Point(233, 455);
            this.btnDenied.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDenied.Name = "btnDenied";
            this.btnDenied.Size = new System.Drawing.Size(179, 54);
            this.btnDenied.TabIndex = 22;
            this.btnDenied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDenied.Click += new System.EventHandler(this.btnDenied_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.ActiveBorderThickness = 1;
            this.btnAccept.ActiveCornerRadius = 20;
            this.btnAccept.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnAccept.ActiveForecolor = System.Drawing.Color.White;
            this.btnAccept.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(10)))), ((int)(((byte)(23)))));
            this.btnAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccept.BackgroundImage")));
            this.btnAccept.ButtonText = "ACCEPT";
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAccept.IdleBorderThickness = 1;
            this.btnAccept.IdleCornerRadius = 20;
            this.btnAccept.IdleFillColor = System.Drawing.Color.Blue;
            this.btnAccept.IdleForecolor = System.Drawing.Color.White;
            this.btnAccept.IdleLineColor = System.Drawing.Color.Black;
            this.btnAccept.Location = new System.Drawing.Point(34, 455);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(179, 54);
            this.btnAccept.TabIndex = 21;
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Short Description :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Reason For Leave :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(157, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 443);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(447, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 443);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 528);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 5);
            this.panel4.TabIndex = 29;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.SeaGreen;
            this.btnImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImage.BackgroundImage")));
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnImage.ImageActive")));
            this.btnImage.InitialImage = null;
            this.btnImage.Location = new System.Drawing.Point(13, 97);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(136, 153);
            this.btnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnImage.TabIndex = 32;
            this.btnImage.TabStop = false;
            this.btnImage.Zoom = 5;
            // 
            // ViewLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(10)))), ((int)(((byte)(23)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 533);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.descrip);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.btnDenied);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewLeave";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewLeave";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblID;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label descrip;
        private System.Windows.Forms.Label reason;
        private System.Windows.Forms.Label dateLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDenied;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAccept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        //private Bunifu.Framework.UI.BunifuImageButton ImageButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuImageButton btnImage;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
    }
}
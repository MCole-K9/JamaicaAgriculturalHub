namespace JAHub_Winforms
{
    partial class FrmGrantStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrantStatus));
            this.btncheck = new System.Windows.Forms.Button();
            this.lbltrn = new System.Windows.Forms.Label();
            this.txttrn = new System.Windows.Forms.TextBox();
            this.rtbtrackinfo = new System.Windows.Forms.RichTextBox();
            this.pansidebarfhc = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(476, 630);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(75, 23);
            this.btncheck.TabIndex = 37;
            this.btncheck.Text = "Chaeck";
            this.btncheck.UseVisualStyleBackColor = true;
            // 
            // lbltrn
            // 
            this.lbltrn.AutoSize = true;
            this.lbltrn.Location = new System.Drawing.Point(230, 578);
            this.lbltrn.Name = "lbltrn";
            this.lbltrn.Size = new System.Drawing.Size(42, 16);
            this.lbltrn.TabIndex = 36;
            this.lbltrn.Text = "TRN :\r\n";
            this.lbltrn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txttrn
            // 
            this.txttrn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txttrn.Location = new System.Drawing.Point(312, 578);
            this.txttrn.Name = "txttrn";
            this.txttrn.Size = new System.Drawing.Size(364, 22);
            this.txttrn.TabIndex = 35;
            this.txttrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbtrackinfo
            // 
            this.rtbtrackinfo.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbtrackinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbtrackinfo.Location = new System.Drawing.Point(210, 476);
            this.rtbtrackinfo.Name = "rtbtrackinfo";
            this.rtbtrackinfo.Size = new System.Drawing.Size(665, 96);
            this.rtbtrackinfo.TabIndex = 34;
            this.rtbtrackinfo.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud" +
    " exercitation";
            // 
            // pansidebarfhc
            // 
            this.pansidebarfhc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pansidebarfhc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pansidebarfhc.Location = new System.Drawing.Point(0, 0);
            this.pansidebarfhc.Name = "pansidebarfhc";
            this.pansidebarfhc.Size = new System.Drawing.Size(191, 953);
            this.pansidebarfhc.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(525, 334);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 8);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 389);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGrantStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 953);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.lbltrn);
            this.Controls.Add(this.txttrn);
            this.Controls.Add(this.rtbtrackinfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pansidebarfhc);
            this.Name = "FrmGrantStatus";
            this.Text = "FrmGrantStatus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label lbltrn;
        private System.Windows.Forms.TextBox txttrn;
        private System.Windows.Forms.RichTextBox rtbtrackinfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pansidebarfhc;
    }
}
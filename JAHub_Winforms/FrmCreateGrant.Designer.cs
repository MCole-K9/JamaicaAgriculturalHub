namespace JAHub_Winforms
{
    partial class FrmCreateGrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateGrant));
            this.btnuploadfile = new System.Windows.Forms.Button();
            this.pbfile = new System.Windows.Forms.PictureBox();
            this.rtbdescription = new System.Windows.Forms.RichTextBox();
            this.pansidebarcwj = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGrant = new System.Windows.Forms.Button();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.dtpExpirydate = new System.Windows.Forms.DateTimePicker();
            this.rtbrequirement = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnuploadfile
            // 
            this.btnuploadfile.Location = new System.Drawing.Point(366, 973);
            this.btnuploadfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuploadfile.Name = "btnuploadfile";
            this.btnuploadfile.Size = new System.Drawing.Size(115, 50);
            this.btnuploadfile.TabIndex = 0;
            this.btnuploadfile.Text = "Upload File";
            this.btnuploadfile.UseVisualStyleBackColor = true;
            // 
            // pbfile
            // 
            this.pbfile.Image = ((System.Drawing.Image)(resources.GetObject("pbfile.Image")));
            this.pbfile.Location = new System.Drawing.Point(285, 763);
            this.pbfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbfile.Name = "pbfile";
            this.pbfile.Size = new System.Drawing.Size(315, 194);
            this.pbfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbfile.TabIndex = 10;
            this.pbfile.TabStop = false;
            // 
            // rtbdescription
            // 
            this.rtbdescription.Location = new System.Drawing.Point(284, 148);
            this.rtbdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbdescription.Name = "rtbdescription";
            this.rtbdescription.Size = new System.Drawing.Size(705, 181);
            this.rtbdescription.TabIndex = 9;
            this.rtbdescription.Text = "";
            // 
            // pansidebarcwj
            // 
            this.pansidebarcwj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pansidebarcwj.Dock = System.Windows.Forms.DockStyle.Left;
            this.pansidebarcwj.Location = new System.Drawing.Point(0, 0);
            this.pansidebarcwj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pansidebarcwj.Name = "pansidebarcwj";
            this.pansidebarcwj.Size = new System.Drawing.Size(191, 1055);
            this.pansidebarcwj.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter Grant Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Grant Description";
            // 
            // btnCreateGrant
            // 
            this.btnCreateGrant.Location = new System.Drawing.Point(921, 983);
            this.btnCreateGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateGrant.Name = "btnCreateGrant";
            this.btnCreateGrant.Size = new System.Drawing.Size(100, 43);
            this.btnCreateGrant.TabIndex = 32;
            this.btnCreateGrant.Text = "Create Grant";
            this.btnCreateGrant.UseVisualStyleBackColor = true;
            this.btnCreateGrant.Click += new System.EventHandler(this.btnCreateGrant_Click);
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(281, 665);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(98, 16);
            this.lblExpirationDate.TabIndex = 33;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // dtpExpirydate
            // 
            this.dtpExpirydate.Location = new System.Drawing.Point(285, 705);
            this.dtpExpirydate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpirydate.Name = "dtpExpirydate";
            this.dtpExpirydate.Size = new System.Drawing.Size(265, 22);
            this.dtpExpirydate.TabIndex = 34;
            // 
            // rtbrequirement
            // 
            this.rtbrequirement.Location = new System.Drawing.Point(283, 424);
            this.rtbrequirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbrequirement.Name = "rtbrequirement";
            this.rtbrequirement.Size = new System.Drawing.Size(706, 151);
            this.rtbrequirement.TabIndex = 35;
            this.rtbrequirement.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Requirements";
            // 
            // FrmCreateGrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbrequirement);
            this.Controls.Add(this.dtpExpirydate);
            this.Controls.Add(this.btnuploadfile);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.btnCreateGrant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbfile);
            this.Controls.Add(this.rtbdescription);
            this.Controls.Add(this.pansidebarcwj);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateGrant";
            this.Load += new System.EventHandler(this.FrmCreateGrant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnuploadfile;
        private System.Windows.Forms.PictureBox pbfile;
        private System.Windows.Forms.RichTextBox rtbdescription;
        private System.Windows.Forms.Panel pansidebarcwj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateGrant;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpExpirydate;
        private System.Windows.Forms.RichTextBox rtbrequirement;
        private System.Windows.Forms.Label label3;
    }
}
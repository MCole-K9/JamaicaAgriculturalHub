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
            this.btnuploadfile = new System.Windows.Forms.Button();
            this.rtbdescription = new System.Windows.Forms.RichTextBox();
            this.lbltitlcreategrant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGrant = new System.Windows.Forms.Button();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.dtpExpirydate = new System.Windows.Forms.DateTimePicker();
            this.rtbrequirement = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcreategranttitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileinfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnuploadfile
            // 
            this.btnuploadfile.Location = new System.Drawing.Point(398, 851);
            this.btnuploadfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuploadfile.Name = "btnuploadfile";
            this.btnuploadfile.Size = new System.Drawing.Size(88, 38);
            this.btnuploadfile.TabIndex = 0;
            this.btnuploadfile.Text = "Upload File";
            this.btnuploadfile.UseVisualStyleBackColor = true;
            this.btnuploadfile.Click += new System.EventHandler(this.btnuploadfile_Click);
            // 
            // rtbdescription
            // 
            this.rtbdescription.Location = new System.Drawing.Point(288, 148);
            this.rtbdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbdescription.Name = "rtbdescription";
            this.rtbdescription.Size = new System.Drawing.Size(705, 181);
            this.rtbdescription.TabIndex = 9;
            this.rtbdescription.Text = "";
            // 
            // lbltitlcreategrant
            // 
            this.lbltitlcreategrant.AutoSize = true;
            this.lbltitlcreategrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlcreategrant.Location = new System.Drawing.Point(544, 37);
            this.lbltitlcreategrant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitlcreategrant.Name = "lbltitlcreategrant";
            this.lbltitlcreategrant.Size = new System.Drawing.Size(0, 29);
            this.lbltitlcreategrant.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Grant Description";
            // 
            // btnCreateGrant
            // 
            this.btnCreateGrant.Location = new System.Drawing.Point(935, 938);
            this.btnCreateGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateGrant.Name = "btnCreateGrant";
            this.btnCreateGrant.Size = new System.Drawing.Size(82, 38);
            this.btnCreateGrant.TabIndex = 32;
            this.btnCreateGrant.Text = "Submit";
            this.btnCreateGrant.UseVisualStyleBackColor = true;
            this.btnCreateGrant.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(285, 662);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(181, 27);
            this.lblExpirationDate.TabIndex = 33;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // dtpExpirydate
            // 
            this.dtpExpirydate.CustomFormat = "yyyy-MM-dd";
            this.dtpExpirydate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpExpirydate.Location = new System.Drawing.Point(289, 705);
            this.dtpExpirydate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpirydate.Name = "dtpExpirydate";
            this.dtpExpirydate.Size = new System.Drawing.Size(265, 22);
            this.dtpExpirydate.TabIndex = 34;
            // 
            // rtbrequirement
            // 
            this.rtbrequirement.Location = new System.Drawing.Point(287, 424);
            this.rtbrequirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbrequirement.Name = "rtbrequirement";
            this.rtbrequirement.Size = new System.Drawing.Size(706, 151);
            this.rtbrequirement.TabIndex = 35;
            this.rtbrequirement.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "Requirements";
            // 
            // txtcreategranttitle
            // 
            this.txtcreategranttitle.Location = new System.Drawing.Point(289, 37);
            this.txtcreategranttitle.Name = "txtcreategranttitle";
            this.txtcreategranttitle.Size = new System.Drawing.Size(266, 22);
            this.txtcreategranttitle.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 27);
            this.label4.TabIndex = 67;
            this.label4.Text = "Title";
            // 
            // txtFileinfo
            // 
            this.txtFileinfo.Location = new System.Drawing.Point(492, 858);
            this.txtFileinfo.Multiline = true;
            this.txtFileinfo.Name = "txtFileinfo";
            this.txtFileinfo.Size = new System.Drawing.Size(230, 30);
            this.txtFileinfo.TabIndex = 68;
            // 
            // FrmCreateGrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.txtFileinfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcreategranttitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbrequirement);
            this.Controls.Add(this.dtpExpirydate);
            this.Controls.Add(this.btnuploadfile);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.btnCreateGrant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitlcreategrant);
            this.Controls.Add(this.rtbdescription);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateGrant";
            this.Text = "Create Grant";
            this.Load += new System.EventHandler(this.FrmCreateGrant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnuploadfile;
        private System.Windows.Forms.RichTextBox rtbdescription;
        private System.Windows.Forms.Label lbltitlcreategrant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateGrant;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpExpirydate;
        private System.Windows.Forms.RichTextBox rtbrequirement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcreategranttitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileinfo;
    }
}
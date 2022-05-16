namespace JAHub_Winforms
{
    partial class FrmEditGrantInfo
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
            this.txtapplicationnumber = new System.Windows.Forms.TextBox();
            this.txtcreategranttitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpExpirydate = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitlcreategrant = new System.Windows.Forms.Label();
            this.rtbrequirement = new System.Windows.Forms.RichTextBox();
            this.btnuploadfile = new System.Windows.Forms.Button();
            this.rtbdescription = new System.Windows.Forms.RichTextBox();
            this.txtFileInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtapplicationnumber
            // 
            this.txtapplicationnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapplicationnumber.Location = new System.Drawing.Point(980, -69);
            this.txtapplicationnumber.Name = "txtapplicationnumber";
            this.txtapplicationnumber.Size = new System.Drawing.Size(118, 15);
            this.txtapplicationnumber.TabIndex = 78;
            this.txtapplicationnumber.Text = "Application  #";
            // 
            // txtcreategranttitle
            // 
            this.txtcreategranttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcreategranttitle.Location = new System.Drawing.Point(258, -69);
            this.txtcreategranttitle.Name = "txtcreategranttitle";
            this.txtcreategranttitle.Size = new System.Drawing.Size(266, 15);
            this.txtcreategranttitle.TabIndex = 76;
            this.txtcreategranttitle.Text = "Enter Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 75;
            this.label3.Text = "Requirements";
            // 
            // dtpExpirydate
            // 
            this.dtpExpirydate.Location = new System.Drawing.Point(326, 721);
            this.dtpExpirydate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpirydate.Name = "dtpExpirydate";
            this.dtpExpirydate.Size = new System.Drawing.Size(265, 22);
            this.dtpExpirydate.TabIndex = 73;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(322, 678);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(181, 27);
            this.lblExpirationDate.TabIndex = 72;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(922, 941);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 38);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Submit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 70;
            this.label1.Text = "Grant Description";
            // 
            // lbltitlcreategrant
            // 
            this.lbltitlcreategrant.AutoSize = true;
            this.lbltitlcreategrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlcreategrant.Location = new System.Drawing.Point(1001, -135);
            this.lbltitlcreategrant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitlcreategrant.Name = "lbltitlcreategrant";
            this.lbltitlcreategrant.Size = new System.Drawing.Size(0, 29);
            this.lbltitlcreategrant.TabIndex = 69;
            // 
            // rtbrequirement
            // 
            this.rtbrequirement.Location = new System.Drawing.Point(324, 440);
            this.rtbrequirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbrequirement.Name = "rtbrequirement";
            this.rtbrequirement.Size = new System.Drawing.Size(706, 151);
            this.rtbrequirement.TabIndex = 74;
            this.rtbrequirement.Text = "";
            // 
            // btnuploadfile
            // 
            this.btnuploadfile.Location = new System.Drawing.Point(324, 861);
            this.btnuploadfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuploadfile.Name = "btnuploadfile";
            this.btnuploadfile.Size = new System.Drawing.Size(88, 38);
            this.btnuploadfile.TabIndex = 66;
            this.btnuploadfile.Text = "Upload File";
            this.btnuploadfile.UseVisualStyleBackColor = true;
            // 
            // rtbdescription
            // 
            this.rtbdescription.Location = new System.Drawing.Point(325, 164);
            this.rtbdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbdescription.Name = "rtbdescription";
            this.rtbdescription.Size = new System.Drawing.Size(705, 181);
            this.rtbdescription.TabIndex = 67;
            this.rtbdescription.Text = "";
            // 
            // txtFileInfo
            // 
            this.txtFileInfo.Location = new System.Drawing.Point(421, 870);
            this.txtFileInfo.Name = "txtFileInfo";
            this.txtFileInfo.Size = new System.Drawing.Size(215, 22);
            this.txtFileInfo.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 27);
            this.label4.TabIndex = 82;
            this.label4.Text = "Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 81;
            // 
            // FrmEditGrantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 960);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtFileInfo);
            this.Controls.Add(this.txtapplicationnumber);
            this.Controls.Add(this.txtcreategranttitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpExpirydate);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitlcreategrant);
            this.Controls.Add(this.rtbrequirement);
            this.Controls.Add(this.btnuploadfile);
            this.Controls.Add(this.rtbdescription);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditGrantInfo";
            this.Text = "Update Grant";
            this.Load += new System.EventHandler(this.FrmEditGrantInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtapplicationnumber;
        private System.Windows.Forms.TextBox txtcreategranttitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpExpirydate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltitlcreategrant;
        private System.Windows.Forms.RichTextBox rtbrequirement;
        private System.Windows.Forms.Button btnuploadfile;
        private System.Windows.Forms.RichTextBox rtbdescription;
        private System.Windows.Forms.TextBox txtFileInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}
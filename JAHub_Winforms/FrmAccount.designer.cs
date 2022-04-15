namespace JAHub_Winforms
{
    partial class FrmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccount));
            this.panelAccountHeader = new System.Windows.Forms.Panel();
            this.lblInfoAboutYouLabel = new System.Windows.Forms.Label();
            this.lblYourAccountLabel = new System.Windows.Forms.Label();
            this.panelBasicInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiaplayGender = new System.Windows.Forms.Label();
            this.lblDisplaysUserName = new System.Windows.Forms.Label();
            this.panelBasicInfoTitle = new System.Windows.Forms.Panel();
            this.lblBasicInfolabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelContactInfo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDisplayemail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContactInfoTitle = new System.Windows.Forms.Panel();
            this.lblContactInformationLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateGender = new System.Windows.Forms.Button();
            this.btnUpdateBirthday = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.panelAccountHeader.SuspendLayout();
            this.panelBasicInfo.SuspendLayout();
            this.panelBasicInfoTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelContactInfo.SuspendLayout();
            this.panelContactInfoTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAccountHeader
            // 
            this.panelAccountHeader.Controls.Add(this.lblInfoAboutYouLabel);
            this.panelAccountHeader.Controls.Add(this.lblYourAccountLabel);
            this.panelAccountHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccountHeader.Location = new System.Drawing.Point(0, 0);
            this.panelAccountHeader.Name = "panelAccountHeader";
            this.panelAccountHeader.Size = new System.Drawing.Size(906, 98);
            this.panelAccountHeader.TabIndex = 0;
            // 
            // lblInfoAboutYouLabel
            // 
            this.lblInfoAboutYouLabel.AutoSize = true;
            this.lblInfoAboutYouLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAboutYouLabel.Location = new System.Drawing.Point(322, 55);
            this.lblInfoAboutYouLabel.Name = "lblInfoAboutYouLabel";
            this.lblInfoAboutYouLabel.Size = new System.Drawing.Size(129, 15);
            this.lblInfoAboutYouLabel.TabIndex = 1;
            this.lblInfoAboutYouLabel.Text = "Information About You";
            // 
            // lblYourAccountLabel
            // 
            this.lblYourAccountLabel.AutoSize = true;
            this.lblYourAccountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAccountLabel.Location = new System.Drawing.Point(321, 21);
            this.lblYourAccountLabel.Name = "lblYourAccountLabel";
            this.lblYourAccountLabel.Size = new System.Drawing.Size(133, 25);
            this.lblYourAccountLabel.TabIndex = 0;
            this.lblYourAccountLabel.Text = "Your Account\r\n";
            // 
            // panelBasicInfo
            // 
            this.panelBasicInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBasicInfo.Controls.Add(this.label1);
            this.panelBasicInfo.Controls.Add(this.lblDiaplayGender);
            this.panelBasicInfo.Controls.Add(this.btnUpdateGender);
            this.panelBasicInfo.Controls.Add(this.btnUpdateBirthday);
            this.panelBasicInfo.Controls.Add(this.lblDisplaysUserName);
            this.panelBasicInfo.Controls.Add(this.btnUpdateName);
            this.panelBasicInfo.Controls.Add(this.panelBasicInfoTitle);
            this.panelBasicInfo.Location = new System.Drawing.Point(17, 220);
            this.panelBasicInfo.Name = "panelBasicInfo";
            this.panelBasicInfo.Size = new System.Drawing.Size(664, 313);
            this.panelBasicInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "March 16, 2022";
            // 
            // lblDiaplayGender
            // 
            this.lblDiaplayGender.AutoSize = true;
            this.lblDiaplayGender.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaplayGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaplayGender.Location = new System.Drawing.Point(126, 253);
            this.lblDiaplayGender.Name = "lblDiaplayGender";
            this.lblDiaplayGender.Size = new System.Drawing.Size(110, 17);
            this.lblDiaplayGender.TabIndex = 26;
            this.lblDiaplayGender.Text = "I\'d rather not say.";
            // 
            // lblDisplaysUserName
            // 
            this.lblDisplaysUserName.AutoSize = true;
            this.lblDisplaysUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplaysUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplaysUserName.Location = new System.Drawing.Point(137, 106);
            this.lblDisplaysUserName.Name = "lblDisplaysUserName";
            this.lblDisplaysUserName.Size = new System.Drawing.Size(89, 17);
            this.lblDisplaysUserName.TabIndex = 20;
            this.lblDisplaysUserName.Text = "Farmer Brown";
            // 
            // panelBasicInfoTitle
            // 
            this.panelBasicInfoTitle.Controls.Add(this.lblBasicInfolabel);
            this.panelBasicInfoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBasicInfoTitle.Location = new System.Drawing.Point(0, 0);
            this.panelBasicInfoTitle.Name = "panelBasicInfoTitle";
            this.panelBasicInfoTitle.Size = new System.Drawing.Size(662, 68);
            this.panelBasicInfoTitle.TabIndex = 0;
            // 
            // lblBasicInfolabel
            // 
            this.lblBasicInfolabel.AutoSize = true;
            this.lblBasicInfolabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicInfolabel.Location = new System.Drawing.Point(13, 13);
            this.lblBasicInfolabel.Name = "lblBasicInfolabel";
            this.lblBasicInfolabel.Size = new System.Drawing.Size(68, 17);
            this.lblBasicInfolabel.TabIndex = 0;
            this.lblBasicInfolabel.Text = "Basic Info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 108);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 51);
            this.label4.TabIndex = 1;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your Account Profile Info";
            // 
            // panelContactInfo
            // 
            this.panelContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContactInfo.Controls.Add(this.label7);
            this.panelContactInfo.Controls.Add(this.label6);
            this.panelContactInfo.Controls.Add(this.button2);
            this.panelContactInfo.Controls.Add(this.lblDisplayemail);
            this.panelContactInfo.Controls.Add(this.label3);
            this.panelContactInfo.Controls.Add(this.button1);
            this.panelContactInfo.Controls.Add(this.panelContactInfoTitle);
            this.panelContactInfo.Location = new System.Drawing.Point(33, 577);
            this.panelContactInfo.Name = "panelContactInfo";
            this.panelContactInfo.Size = new System.Drawing.Size(653, 227);
            this.panelContactInfo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Add a  Telephone Number to recieve SMS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "TELEPHONE";
            // 
            // lblDisplayemail
            // 
            this.lblDisplayemail.AutoSize = true;
            this.lblDisplayemail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayemail.Location = new System.Drawing.Point(49, 86);
            this.lblDisplayemail.Name = "lblDisplayemail";
            this.lblDisplayemail.Size = new System.Drawing.Size(177, 17);
            this.lblDisplayemail.TabIndex = 25;
            this.lblDisplayemail.Text = "farmerbrown123@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "EMAIL";
            // 
            // panelContactInfoTitle
            // 
            this.panelContactInfoTitle.Controls.Add(this.lblContactInformationLabel);
            this.panelContactInfoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContactInfoTitle.Location = new System.Drawing.Point(0, 0);
            this.panelContactInfoTitle.Name = "panelContactInfoTitle";
            this.panelContactInfoTitle.Size = new System.Drawing.Size(651, 53);
            this.panelContactInfoTitle.TabIndex = 0;
            // 
            // lblContactInformationLabel
            // 
            this.lblContactInformationLabel.AutoSize = true;
            this.lblContactInformationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInformationLabel.Location = new System.Drawing.Point(11, 11);
            this.lblContactInformationLabel.Name = "lblContactInformationLabel";
            this.lblContactInformationLabel.Size = new System.Drawing.Size(133, 17);
            this.lblContactInformationLabel.TabIndex = 0;
            this.lblContactInformationLabel.Text = "Contact Information";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Image = global::JAHub_Winforms.Properties.Resources.right_arrows__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(651, 80);
            this.button2.TabIndex = 26;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = global::JAHub_Winforms.Properties.Resources.right_arrows__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(651, 80);
            this.button1.TabIndex = 24;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JAHub_Winforms.Properties.Resources.concept_of_user_profile;
            this.pictureBox1.Location = new System.Drawing.Point(542, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateGender
            // 
            this.btnUpdateGender.BackColor = System.Drawing.Color.White;
            this.btnUpdateGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateGender.FlatAppearance.BorderSize = 0;
            this.btnUpdateGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGender.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdateGender.Image = global::JAHub_Winforms.Properties.Resources.right_arrows__2_;
            this.btnUpdateGender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateGender.Location = new System.Drawing.Point(0, 228);
            this.btnUpdateGender.Name = "btnUpdateGender";
            this.btnUpdateGender.Size = new System.Drawing.Size(662, 66);
            this.btnUpdateGender.TabIndex = 23;
            this.btnUpdateGender.Text = "GENDER";
            this.btnUpdateGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGender.UseVisualStyleBackColor = false;
            this.btnUpdateGender.Click += new System.EventHandler(this.btnUpdateGender_Click);
            // 
            // btnUpdateBirthday
            // 
            this.btnUpdateBirthday.BackColor = System.Drawing.Color.White;
            this.btnUpdateBirthday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateBirthday.FlatAppearance.BorderSize = 0;
            this.btnUpdateBirthday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBirthday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBirthday.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdateBirthday.Image = global::JAHub_Winforms.Properties.Resources.right_arrows__2_;
            this.btnUpdateBirthday.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateBirthday.Location = new System.Drawing.Point(0, 148);
            this.btnUpdateBirthday.Name = "btnUpdateBirthday";
            this.btnUpdateBirthday.Size = new System.Drawing.Size(662, 80);
            this.btnUpdateBirthday.TabIndex = 22;
            this.btnUpdateBirthday.Text = "BIRTHDAY          ";
            this.btnUpdateBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateBirthday.UseVisualStyleBackColor = false;
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.BackColor = System.Drawing.Color.White;
            this.btnUpdateName.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateName.FlatAppearance.BorderSize = 0;
            this.btnUpdateName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateName.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdateName.Image = global::JAHub_Winforms.Properties.Resources.right_arrows__2_;
            this.btnUpdateName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateName.Location = new System.Drawing.Point(0, 68);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(662, 80);
            this.btnUpdateName.TabIndex = 18;
            this.btnUpdateName.Text = "NAME              ";
            this.btnUpdateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateName.UseVisualStyleBackColor = false;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 753);
            this.Controls.Add(this.panelContactInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBasicInfo);
            this.Controls.Add(this.panelAccountHeader);
            this.Name = "FrmAccount";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            this.panelAccountHeader.ResumeLayout(false);
            this.panelAccountHeader.PerformLayout();
            this.panelBasicInfo.ResumeLayout(false);
            this.panelBasicInfo.PerformLayout();
            this.panelBasicInfoTitle.ResumeLayout(false);
            this.panelBasicInfoTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContactInfo.ResumeLayout(false);
            this.panelContactInfo.PerformLayout();
            this.panelContactInfoTitle.ResumeLayout(false);
            this.panelContactInfoTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccountHeader;
        private System.Windows.Forms.Label lblYourAccountLabel;
        private System.Windows.Forms.Panel panelBasicInfo;
        private System.Windows.Forms.Panel panelBasicInfoTitle;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.Label lblDisplaysUserName;
        private System.Windows.Forms.Button btnUpdateGender;
        private System.Windows.Forms.Button btnUpdateBirthday;
        private System.Windows.Forms.Label lblInfoAboutYouLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiaplayGender;
        private System.Windows.Forms.Label lblBasicInfolabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContactInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelContactInfoTitle;
        private System.Windows.Forms.Label lblContactInformationLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisplayemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}
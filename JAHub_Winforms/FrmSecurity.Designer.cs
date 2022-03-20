﻿namespace JAHub_Winforms
{
    partial class FrmSecurity
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbkSecuritylabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPasswordConditionlabel = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPasswordlabel = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPasswordlabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblChangePasswordlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbkSecuritylabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 0;
            // 
            // lbkSecuritylabel
            // 
            this.lbkSecuritylabel.AutoSize = true;
            this.lbkSecuritylabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkSecuritylabel.Location = new System.Drawing.Point(354, 18);
            this.lbkSecuritylabel.Name = "lbkSecuritylabel";
            this.lbkSecuritylabel.Size = new System.Drawing.Size(53, 17);
            this.lbkSecuritylabel.TabIndex = 0;
            this.lbkSecuritylabel.Text = "Security";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblPasswordConditionlabel);
            this.panel2.Controls.Add(this.btnUpdatePassword);
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Controls.Add(this.txtConfirmNewPassword);
            this.panel2.Controls.Add(this.txtNewPassword);
            this.panel2.Controls.Add(this.lblNewPasswordlabel);
            this.panel2.Controls.Add(this.txtOldPassword);
            this.panel2.Controls.Add(this.lblOldPasswordlabel);
            this.panel2.Location = new System.Drawing.Point(108, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 345);
            this.panel2.TabIndex = 1;
            // 
            // lblPasswordConditionlabel
            // 
            this.lblPasswordConditionlabel.AutoSize = true;
            this.lblPasswordConditionlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConditionlabel.Location = new System.Drawing.Point(32, 221);
            this.lblPasswordConditionlabel.Name = "lblPasswordConditionlabel";
            this.lblPasswordConditionlabel.Size = new System.Drawing.Size(391, 34);
            this.lblPasswordConditionlabel.TabIndex = 7;
            this.lblPasswordConditionlabel.Text = "Make sure it\'s at  least 8 characters including Numbers, Symbols, \r\nand Uppercase" +
    " or Lowercase letters.";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(186, 285);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(139, 25);
            this.btnUpdatePassword.TabIndex = 6;
            this.btnUpdatePassword.Text = "&Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(33, 182);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(359, 20);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.AutoSize = true;
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(25, 160);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(148, 17);
            this.txtConfirmNewPassword.TabIndex = 4;
            this.txtConfirmNewPassword.Text = "Comfirm New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(34, 110);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(359, 20);
            this.txtNewPassword.TabIndex = 3;
            // 
            // lblNewPasswordlabel
            // 
            this.lblNewPasswordlabel.AutoSize = true;
            this.lblNewPasswordlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordlabel.Location = new System.Drawing.Point(26, 88);
            this.lblNewPasswordlabel.Name = "lblNewPasswordlabel";
            this.lblNewPasswordlabel.Size = new System.Drawing.Size(94, 17);
            this.lblNewPasswordlabel.TabIndex = 2;
            this.lblNewPasswordlabel.Text = "New Password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(29, 40);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(359, 20);
            this.txtOldPassword.TabIndex = 1;
            // 
            // lblOldPasswordlabel
            // 
            this.lblOldPasswordlabel.AutoSize = true;
            this.lblOldPasswordlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPasswordlabel.Location = new System.Drawing.Point(21, 18);
            this.lblOldPasswordlabel.Name = "lblOldPasswordlabel";
            this.lblOldPasswordlabel.Size = new System.Drawing.Size(89, 17);
            this.lblOldPasswordlabel.TabIndex = 0;
            this.lblOldPasswordlabel.Text = "Old Password";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblChangePasswordlabel);
            this.panel3.Location = new System.Drawing.Point(108, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 90);
            this.panel3.TabIndex = 2;
            // 
            // lblChangePasswordlabel
            // 
            this.lblChangePasswordlabel.AutoSize = true;
            this.lblChangePasswordlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePasswordlabel.Location = new System.Drawing.Point(13, 8);
            this.lblChangePasswordlabel.Name = "lblChangePasswordlabel";
            this.lblChangePasswordlabel.Size = new System.Drawing.Size(124, 17);
            this.lblChangePasswordlabel.TabIndex = 0;
            this.lblChangePasswordlabel.Text = " Change Password ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JAHub_Winforms.Properties.Resources.security_settings_I_;
            this.pictureBox1.Location = new System.Drawing.Point(400, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "You may configure and change the security settings for login \r\nin this section. U" +
    "se a strong, unique password to keep your JAH \r\naccount safe.";
            // 
            // FrmSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSecurity";
            this.Text = "FrmSecurity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbkSecuritylabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPasswordConditionlabel;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label txtConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPasswordlabel;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPasswordlabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChangePasswordlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
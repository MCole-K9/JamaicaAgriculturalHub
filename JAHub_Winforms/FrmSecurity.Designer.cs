namespace JAHub_Winforms
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbkSecuritylabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPasswordConditionlabel = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPasswordLabel = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPasswordlabel = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPasswordlabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPasswordTiplabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblChangePasswordlabel = new System.Windows.Forms.Label();
            this.errorProviderOldPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbkSecuritylabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 78);
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
            this.panel2.Controls.Add(this.lblConfirmNewPasswordLabel);
            this.panel2.Controls.Add(this.txtNewPassword);
            this.panel2.Controls.Add(this.lblNewPasswordlabel);
            this.panel2.Controls.Add(this.txtOldPassword);
            this.panel2.Controls.Add(this.lblOldPasswordlabel);
            this.panel2.Location = new System.Drawing.Point(111, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 420);
            this.panel2.TabIndex = 1;
            // 
            // lblPasswordConditionlabel
            // 
            this.lblPasswordConditionlabel.AutoSize = true;
            this.lblPasswordConditionlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConditionlabel.Location = new System.Drawing.Point(32, 262);
            this.lblPasswordConditionlabel.Name = "lblPasswordConditionlabel";
            this.lblPasswordConditionlabel.Size = new System.Drawing.Size(391, 34);
            this.lblPasswordConditionlabel.TabIndex = 7;
            this.lblPasswordConditionlabel.Text = "Make sure it\'s at  least 8 characters including Numbers, Symbols, \r\nand Uppercase" +
    " or Lowercase letters.";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(186, 326);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(139, 25);
            this.btnUpdatePassword.TabIndex = 6;
            this.btnUpdatePassword.Text = "&Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(33, 201);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(359, 20);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // lblConfirmNewPasswordLabel
            // 
            this.lblConfirmNewPasswordLabel.AutoSize = true;
            this.lblConfirmNewPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPasswordLabel.Location = new System.Drawing.Point(25, 179);
            this.lblConfirmNewPasswordLabel.Name = "lblConfirmNewPasswordLabel";
            this.lblConfirmNewPasswordLabel.Size = new System.Drawing.Size(144, 17);
            this.lblConfirmNewPasswordLabel.TabIndex = 4;
            this.lblConfirmNewPasswordLabel.Text = "Confirm New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(34, 125);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(359, 20);
            this.txtNewPassword.TabIndex = 3;
            // 
            // lblNewPasswordlabel
            // 
            this.lblNewPasswordlabel.AutoSize = true;
            this.lblNewPasswordlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordlabel.Location = new System.Drawing.Point(26, 103);
            this.lblNewPasswordlabel.Name = "lblNewPasswordlabel";
            this.lblNewPasswordlabel.Size = new System.Drawing.Size(94, 17);
            this.lblNewPasswordlabel.TabIndex = 2;
            this.lblNewPasswordlabel.Text = "New Password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(29, 51);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(359, 20);
            this.txtOldPassword.TabIndex = 1;
            // 
            // lblOldPasswordlabel
            // 
            this.lblOldPasswordlabel.AutoSize = true;
            this.lblOldPasswordlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPasswordlabel.Location = new System.Drawing.Point(21, 29);
            this.lblOldPasswordlabel.Name = "lblOldPasswordlabel";
            this.lblOldPasswordlabel.Size = new System.Drawing.Size(89, 17);
            this.lblOldPasswordlabel.TabIndex = 0;
            this.lblOldPasswordlabel.Text = "Old Password";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblPasswordTiplabel);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblChangePasswordlabel);
            this.panel3.Location = new System.Drawing.Point(73, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 95);
            this.panel3.TabIndex = 2;
            // 
            // lblPasswordTiplabel
            // 
            this.lblPasswordTiplabel.AutoSize = true;
            this.lblPasswordTiplabel.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordTiplabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTiplabel.Location = new System.Drawing.Point(18, 27);
            this.lblPasswordTiplabel.Name = "lblPasswordTiplabel";
            this.lblPasswordTiplabel.Size = new System.Drawing.Size(384, 51);
            this.lblPasswordTiplabel.TabIndex = 2;
            this.lblPasswordTiplabel.Text = "You may configure and change the security settings for login \r\nin this section. U" +
    "se a strong, unique password to keep your JAH \r\naccount safe.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JAHub_Winforms.Properties.Resources.security_settings_I_;
            this.pictureBox1.Location = new System.Drawing.Point(434, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // errorProviderOldPassword
            // 
            this.errorProviderOldPassword.ContainerControl = this;
            // 
            // errorProviderNewPassword
            // 
            this.errorProviderNewPassword.ContainerControl = this;
            // 
            // errorProviderConfirmPassword
            // 
            this.errorProviderConfirmPassword.ContainerControl = this;
            // 
            // FrmSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(766, 633);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSecurity";
            this.Text = "Security";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbkSecuritylabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPasswordConditionlabel;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmNewPasswordLabel;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPasswordlabel;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPasswordlabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChangePasswordlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPasswordTiplabel;
        private System.Windows.Forms.ErrorProvider errorProviderOldPassword;
        private System.Windows.Forms.ErrorProvider errorProviderNewPassword;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPassword;
    }
}
namespace JAHub_Winforms
{
    partial class FrmLogin
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
            this.flpLogin = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLoginHeading = new System.Windows.Forms.Label();
            this.lblLoginInstruction = new System.Windows.Forms.Label();
            this.tblLoginCredentials = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblCredentialEntryError = new System.Windows.Forms.Label();
            this.flpLogin.SuspendLayout();
            this.tblLoginCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpLogin
            // 
            this.flpLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpLogin.Controls.Add(this.lblLoginHeading);
            this.flpLogin.Controls.Add(this.lblLoginInstruction);
            this.flpLogin.Controls.Add(this.tblLoginCredentials);
            this.flpLogin.Controls.Add(this.btnLogin);
            this.flpLogin.Controls.Add(this.lblCredentialEntryError);
            this.flpLogin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLogin.Location = new System.Drawing.Point(0, 0);
            this.flpLogin.Margin = new System.Windows.Forms.Padding(0);
            this.flpLogin.Name = "flpLogin";
            this.flpLogin.Size = new System.Drawing.Size(384, 384);
            this.flpLogin.TabIndex = 0;
            this.flpLogin.WrapContents = false;
            // 
            // lblLoginHeading
            // 
            this.lblLoginHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoginHeading.AutoSize = true;
            this.lblLoginHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeading.Location = new System.Drawing.Point(86, 0);
            this.lblLoginHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginHeading.Name = "lblLoginHeading";
            this.lblLoginHeading.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lblLoginHeading.Size = new System.Drawing.Size(207, 53);
            this.lblLoginHeading.TabIndex = 0;
            this.lblLoginHeading.Text = "Log in to Continue";
            // 
            // lblLoginInstruction
            // 
            this.lblLoginInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoginInstruction.AutoSize = true;
            this.lblLoginInstruction.Location = new System.Drawing.Point(4, 53);
            this.lblLoginInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginInstruction.Name = "lblLoginInstruction";
            this.lblLoginInstruction.Padding = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.lblLoginInstruction.Size = new System.Drawing.Size(372, 112);
            this.lblLoginInstruction.TabIndex = 1;
            this.lblLoginInstruction.Text = "To continue, please log into your account using your User ID and password\r\n\r\n(jus" +
    "t enter \'1\' for user ID and \"test\" for password)";
            // 
            // tblLoginCredentials
            // 
            this.tblLoginCredentials.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblLoginCredentials.ColumnCount = 2;
            this.tblLoginCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLoginCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLoginCredentials.Controls.Add(this.txtPassword, 1, 1);
            this.tblLoginCredentials.Controls.Add(this.txtUserId, 1, 0);
            this.tblLoginCredentials.Controls.Add(this.lblUserId, 0, 0);
            this.tblLoginCredentials.Controls.Add(this.lblLoginPassword, 0, 1);
            this.tblLoginCredentials.Location = new System.Drawing.Point(9, 168);
            this.tblLoginCredentials.Name = "tblLoginCredentials";
            this.tblLoginCredentials.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.tblLoginCredentials.RowCount = 2;
            this.tblLoginCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLoginCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLoginCredentials.Size = new System.Drawing.Size(362, 72);
            this.tblLoginCredentials.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(110, 40);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(191, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserId.Location = new System.Drawing.Point(110, 4);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(191, 27);
            this.txtUserId.TabIndex = 4;
            // 
            // lblUserId
            // 
            this.lblUserId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(31, 7);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(72, 20);
            this.lblUserId.TabIndex = 6;
            this.lblUserId.Text = "User ID:";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(15, 43);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(88, 20);
            this.lblLoginPassword.TabIndex = 7;
            this.lblLoginPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.Location = new System.Drawing.Point(143, 247);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblCredentialEntryError
            // 
            this.lblCredentialEntryError.AutoSize = true;
            this.lblCredentialEntryError.ForeColor = System.Drawing.Color.Red;
            this.lblCredentialEntryError.Location = new System.Drawing.Point(3, 280);
            this.lblCredentialEntryError.Name = "lblCredentialEntryError";
            this.lblCredentialEntryError.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblCredentialEntryError.Size = new System.Drawing.Size(275, 20);
            this.lblCredentialEntryError.TabIndex = 7;
            this.lblCredentialEntryError.Text = "You shouldn\'t be able to see this";
            this.lblCredentialEntryError.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 384);
            this.Controls.Add(this.flpLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(384, 384);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(384, 384);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.flpLogin.ResumeLayout(false);
            this.flpLogin.PerformLayout();
            this.tblLoginCredentials.ResumeLayout(false);
            this.tblLoginCredentials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLogin;
        private System.Windows.Forms.Label lblLoginHeading;
        private System.Windows.Forms.Label lblLoginInstruction;
        private System.Windows.Forms.TableLayoutPanel tblLoginCredentials;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCredentialEntryError;
    }
}
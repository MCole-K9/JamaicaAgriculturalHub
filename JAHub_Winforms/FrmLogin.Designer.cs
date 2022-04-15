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
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblCredentialEntryError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWelcomeToJAH = new System.Windows.Forms.Label();
            this.flpLogin.SuspendLayout();
            this.tblLoginCredentials.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.flpLogin.Location = new System.Drawing.Point(168, 0);
            this.flpLogin.Margin = new System.Windows.Forms.Padding(0);
            this.flpLogin.Name = "flpLogin";
            this.flpLogin.Size = new System.Drawing.Size(432, 340);
            this.flpLogin.TabIndex = 0;
            this.flpLogin.WrapContents = false;
            // 
            // lblLoginHeading
            // 
            this.lblLoginHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoginHeading.AutoSize = true;
            this.lblLoginHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeading.Location = new System.Drawing.Point(123, 0);
            this.lblLoginHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginHeading.Name = "lblLoginHeading";
            this.lblLoginHeading.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lblLoginHeading.Size = new System.Drawing.Size(163, 48);
            this.lblLoginHeading.TabIndex = 0;
            this.lblLoginHeading.Text = "Log in to Continue";
            // 
            // lblLoginInstruction
            // 
            this.lblLoginInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoginInstruction.AutoSize = true;
            this.lblLoginInstruction.Location = new System.Drawing.Point(4, 48);
            this.lblLoginInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginInstruction.Name = "lblLoginInstruction";
            this.lblLoginInstruction.Padding = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.lblLoginInstruction.Size = new System.Drawing.Size(402, 46);
            this.lblLoginInstruction.TabIndex = 1;
            this.lblLoginInstruction.Text = "To continue, please log into your account using your User ID and password";
            // 
            // tblLoginCredentials
            // 
            this.tblLoginCredentials.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblLoginCredentials.ColumnCount = 2;
            this.tblLoginCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLoginCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLoginCredentials.Controls.Add(this.txtPassword, 1, 1);
            this.tblLoginCredentials.Controls.Add(this.txtEmailAddress, 1, 0);
            this.tblLoginCredentials.Controls.Add(this.lblEmailAddress, 0, 0);
            this.tblLoginCredentials.Controls.Add(this.lblLoginPassword, 0, 1);
            this.tblLoginCredentials.Location = new System.Drawing.Point(24, 97);
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
            this.txtPassword.Location = new System.Drawing.Point(95, 40);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(191, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmailAddress.Location = new System.Drawing.Point(95, 4);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(191, 23);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(42, 7);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(46, 17);
            this.lblEmailAddress.TabIndex = 6;
            this.lblEmailAddress.Text = "Email:";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(15, 43);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(73, 17);
            this.lblLoginPassword.TabIndex = 7;
            this.lblLoginPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.Location = new System.Drawing.Point(158, 176);
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
            this.lblCredentialEntryError.Location = new System.Drawing.Point(3, 209);
            this.lblCredentialEntryError.Name = "lblCredentialEntryError";
            this.lblCredentialEntryError.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblCredentialEntryError.Size = new System.Drawing.Size(238, 17);
            this.lblCredentialEntryError.TabIndex = 7;
            this.lblCredentialEntryError.Text = "You shouldn\'t be able to see this";
            this.lblCredentialEntryError.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblSignUp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblWelcomeToJAH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 340);
            this.panel1.TabIndex = 1;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(110, 218);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(57, 20);
            this.lblSignUp.TabIndex = 4;
            this.lblSignUp.Text = "&SignUp";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Not a Member?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "All Local Products in One Place";
            // 
            // lblWelcomeToJAH
            // 
            this.lblWelcomeToJAH.AutoSize = true;
            this.lblWelcomeToJAH.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblWelcomeToJAH.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeToJAH.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeToJAH.Location = new System.Drawing.Point(3, 103);
            this.lblWelcomeToJAH.Name = "lblWelcomeToJAH";
            this.lblWelcomeToJAH.Size = new System.Drawing.Size(164, 36);
            this.lblWelcomeToJAH.TabIndex = 0;
            this.lblWelcomeToJAH.Text = "           Welcome To\r\nJamaica Agricultural Hub\r\n";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(590, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(590, 340);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.flpLogin.ResumeLayout(false);
            this.flpLogin.PerformLayout();
            this.tblLoginCredentials.ResumeLayout(false);
            this.tblLoginCredentials.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLogin;
        private System.Windows.Forms.Label lblLoginHeading;
        private System.Windows.Forms.Label lblLoginInstruction;
        private System.Windows.Forms.TableLayoutPanel tblLoginCredentials;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCredentialEntryError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWelcomeToJAH;
    }
}
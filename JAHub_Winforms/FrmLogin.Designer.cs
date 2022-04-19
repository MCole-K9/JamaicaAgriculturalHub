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
            this.tlpLoginCredentials = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblCredentialEntryError = new System.Windows.Forms.Label();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblNotAMember = new System.Windows.Forms.Label();
            this.lblAllProducts = new System.Windows.Forms.Label();
            this.lblWelcomeToJAH = new System.Windows.Forms.Label();
            this.flpLogin.SuspendLayout();
            this.tlpLoginCredentials.SuspendLayout();
            this.pnlSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpLogin
            // 
            this.flpLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpLogin.Controls.Add(this.lblLoginHeading);
            this.flpLogin.Controls.Add(this.lblLoginInstruction);
            this.flpLogin.Controls.Add(this.tlpLoginCredentials);
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
            this.lblLoginHeading.Location = new System.Drawing.Point(105, 0);
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
            this.lblLoginInstruction.Size = new System.Drawing.Size(409, 52);
            this.lblLoginInstruction.TabIndex = 1;
            this.lblLoginInstruction.Text = "To continue, please log into your account using your Email and password";
            // 
            // tlpLoginCredentials
            // 
            this.tlpLoginCredentials.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpLoginCredentials.ColumnCount = 2;
            this.tlpLoginCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLoginCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLoginCredentials.Controls.Add(this.txtPassword, 1, 1);
            this.tlpLoginCredentials.Controls.Add(this.txtEmailAddress, 1, 0);
            this.tlpLoginCredentials.Controls.Add(this.lblEmailAddress, 0, 0);
            this.tlpLoginCredentials.Controls.Add(this.lblLoginPassword, 0, 1);
            this.tlpLoginCredentials.Location = new System.Drawing.Point(27, 108);
            this.tlpLoginCredentials.Name = "tlpLoginCredentials";
            this.tlpLoginCredentials.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.tlpLoginCredentials.RowCount = 2;
            this.tlpLoginCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLoginCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLoginCredentials.Size = new System.Drawing.Size(362, 72);
            this.tlpLoginCredentials.TabIndex = 6;
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
            // txtEmailAddress
            // 
            this.txtEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmailAddress.Location = new System.Drawing.Point(110, 4);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(191, 27);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(47, 7);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(56, 20);
            this.lblEmailAddress.TabIndex = 6;
            this.lblEmailAddress.Text = "Email:";
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
            this.btnLogin.Location = new System.Drawing.Point(161, 187);
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
            this.lblCredentialEntryError.Location = new System.Drawing.Point(3, 220);
            this.lblCredentialEntryError.Name = "lblCredentialEntryError";
            this.lblCredentialEntryError.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblCredentialEntryError.Size = new System.Drawing.Size(275, 20);
            this.lblCredentialEntryError.TabIndex = 7;
            this.lblCredentialEntryError.Text = "You shouldn\'t be able to see this";
            this.lblCredentialEntryError.Visible = false;
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlSignUp.Controls.Add(this.lblSignUp);
            this.pnlSignUp.Controls.Add(this.lblNotAMember);
            this.pnlSignUp.Controls.Add(this.lblAllProducts);
            this.pnlSignUp.Controls.Add(this.lblWelcomeToJAH);
            this.pnlSignUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSignUp.Location = new System.Drawing.Point(0, 0);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(168, 340);
            this.pnlSignUp.TabIndex = 1;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(110, 218);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(73, 25);
            this.lblSignUp.TabIndex = 4;
            this.lblSignUp.Text = "&SignUp";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblNotAMember
            // 
            this.lblNotAMember.AutoSize = true;
            this.lblNotAMember.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotAMember.Location = new System.Drawing.Point(0, 219);
            this.lblNotAMember.Name = "lblNotAMember";
            this.lblNotAMember.Size = new System.Drawing.Size(143, 25);
            this.lblNotAMember.TabIndex = 3;
            this.lblNotAMember.Text = "Not a Member?";
            // 
            // lblAllProducts
            // 
            this.lblAllProducts.AutoSize = true;
            this.lblAllProducts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblAllProducts.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllProducts.ForeColor = System.Drawing.Color.White;
            this.lblAllProducts.Location = new System.Drawing.Point(2, 141);
            this.lblAllProducts.Name = "lblAllProducts";
            this.lblAllProducts.Size = new System.Drawing.Size(206, 19);
            this.lblAllProducts.TabIndex = 2;
            this.lblAllProducts.Text = "All Local Products in One Place";
            // 
            // lblWelcomeToJAH
            // 
            this.lblWelcomeToJAH.AutoSize = true;
            this.lblWelcomeToJAH.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblWelcomeToJAH.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeToJAH.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeToJAH.Location = new System.Drawing.Point(3, 103);
            this.lblWelcomeToJAH.Name = "lblWelcomeToJAH";
            this.lblWelcomeToJAH.Size = new System.Drawing.Size(211, 48);
            this.lblWelcomeToJAH.TabIndex = 0;
            this.lblWelcomeToJAH.Text = "           Welcome To\r\nJamaica Agricultural Hub\r\n";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 340);
            this.Controls.Add(this.pnlSignUp);
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
            this.tlpLoginCredentials.ResumeLayout(false);
            this.tlpLoginCredentials.PerformLayout();
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLogin;
        private System.Windows.Forms.Label lblLoginHeading;
        private System.Windows.Forms.Label lblLoginInstruction;
        private System.Windows.Forms.TableLayoutPanel tlpLoginCredentials;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCredentialEntryError;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblNotAMember;
        private System.Windows.Forms.Label lblAllProducts;
        private System.Windows.Forms.Label lblWelcomeToJAH;
    }
}
namespace JAHub_Winforms
{
    partial class FrmSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcomeToJAHlabel = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSignUplable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSignUP = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPasswordlabel = new System.Windows.Forms.Label();
            this.lblPasswordlabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.rbtnratherNotSay = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblMiddleNamelabel = new System.Windows.Forms.Label();
            this.lblEmaillabel = new System.Windows.Forms.Label();
            this.lblLastNamelabel = new System.Windows.Forms.Label();
            this.lblFirstNamelabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblWelcomeToJAHlabel);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 418);
            this.panel1.TabIndex = 0;
            // 
            // lblWelcomeToJAHlabel
            // 
            this.lblWelcomeToJAHlabel.AutoSize = true;
            this.lblWelcomeToJAHlabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeToJAHlabel.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeToJAHlabel.Location = new System.Drawing.Point(9, 136);
            this.lblWelcomeToJAHlabel.Name = "lblWelcomeToJAHlabel";
            this.lblWelcomeToJAHlabel.Size = new System.Drawing.Size(187, 40);
            this.lblWelcomeToJAHlabel.TabIndex = 5;
            this.lblWelcomeToJAHlabel.Text = "           Welcome To\r\nJamaica Agricultural Hub\r\n";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(143, 317);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 20);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "&Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Already a Member?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "All Local Products in One Place";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnSignUP);
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.lblConfirmPasswordlabel);
            this.panel2.Controls.Add(this.lblPasswordlabel);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtMiddleName);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.groupBoxGender);
            this.panel2.Controls.Add(this.lblMiddleNamelabel);
            this.panel2.Controls.Add(this.lblEmaillabel);
            this.panel2.Controls.Add(this.lblLastNamelabel);
            this.panel2.Controls.Add(this.lblFirstNamelabel);
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 418);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSignUplable);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 51);
            this.panel3.TabIndex = 14;
            // 
            // lblSignUplable
            // 
            this.lblSignUplable.AutoSize = true;
            this.lblSignUplable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUplable.Location = new System.Drawing.Point(242, 12);
            this.lblSignUplable.Name = "lblSignUplable";
            this.lblSignUplable.Size = new System.Drawing.Size(83, 25);
            this.lblSignUplable.TabIndex = 1;
            this.lblSignUplable.Text = "Sign Up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            // 
            // btnSignUP
            // 
            this.btnSignUP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSignUP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSignUP.Location = new System.Drawing.Point(239, 361);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.Size = new System.Drawing.Size(91, 30);
            this.btnSignUP.TabIndex = 13;
            this.btnSignUP.Text = "&Sign Up";
            this.btnSignUP.UseVisualStyleBackColor = false;
            this.btnSignUP.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(347, 275);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(210, 20);
            this.txtConfirmPassword.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(347, 213);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // lblConfirmPasswordlabel
            // 
            this.lblConfirmPasswordlabel.AutoSize = true;
            this.lblConfirmPasswordlabel.Location = new System.Drawing.Point(347, 252);
            this.lblConfirmPasswordlabel.Name = "lblConfirmPasswordlabel";
            this.lblConfirmPasswordlabel.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPasswordlabel.TabIndex = 10;
            this.lblConfirmPasswordlabel.Text = "Confirm Password";
            // 
            // lblPasswordlabel
            // 
            this.lblPasswordlabel.AutoSize = true;
            this.lblPasswordlabel.Location = new System.Drawing.Point(347, 189);
            this.lblPasswordlabel.Name = "lblPasswordlabel";
            this.lblPasswordlabel.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordlabel.TabIndex = 9;
            this.lblPasswordlabel.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(40, 279);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(40, 212);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(223, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(40, 139);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(223, 20);
            this.txtMiddleName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(40, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(223, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.rbtnratherNotSay);
            this.groupBoxGender.Controls.Add(this.rbtnFemale);
            this.groupBoxGender.Controls.Add(this.rbtnMale);
            this.groupBoxGender.Location = new System.Drawing.Point(356, 71);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(171, 107);
            this.groupBoxGender.TabIndex = 4;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // rbtnratherNotSay
            // 
            this.rbtnratherNotSay.AutoSize = true;
            this.rbtnratherNotSay.Checked = true;
            this.rbtnratherNotSay.Location = new System.Drawing.Point(14, 76);
            this.rbtnratherNotSay.Name = "rbtnratherNotSay";
            this.rbtnratherNotSay.Size = new System.Drawing.Size(103, 17);
            this.rbtnratherNotSay.TabIndex = 2;
            this.rbtnratherNotSay.TabStop = true;
            this.rbtnratherNotSay.Text = "I\'d rather not say";
            this.rbtnratherNotSay.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(15, 48);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(15, 24);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // lblMiddleNamelabel
            // 
            this.lblMiddleNamelabel.AutoSize = true;
            this.lblMiddleNamelabel.Location = new System.Drawing.Point(39, 122);
            this.lblMiddleNamelabel.Name = "lblMiddleNamelabel";
            this.lblMiddleNamelabel.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleNamelabel.TabIndex = 3;
            this.lblMiddleNamelabel.Text = "Middle Name";
            // 
            // lblEmaillabel
            // 
            this.lblEmaillabel.AutoSize = true;
            this.lblEmaillabel.Location = new System.Drawing.Point(40, 258);
            this.lblEmaillabel.Name = "lblEmaillabel";
            this.lblEmaillabel.Size = new System.Drawing.Size(32, 13);
            this.lblEmaillabel.TabIndex = 2;
            this.lblEmaillabel.Text = "Email";
            // 
            // lblLastNamelabel
            // 
            this.lblLastNamelabel.AutoSize = true;
            this.lblLastNamelabel.Location = new System.Drawing.Point(40, 190);
            this.lblLastNamelabel.Name = "lblLastNamelabel";
            this.lblLastNamelabel.Size = new System.Drawing.Size(58, 13);
            this.lblLastNamelabel.TabIndex = 1;
            this.lblLastNamelabel.Text = "Last Name";
            // 
            // lblFirstNamelabel
            // 
            this.lblFirstNamelabel.AutoSize = true;
            this.lblFirstNamelabel.Location = new System.Drawing.Point(37, 64);
            this.lblFirstNamelabel.Name = "lblFirstNamelabel";
            this.lblFirstNamelabel.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNamelabel.TabIndex = 0;
            this.lblFirstNamelabel.Text = "First Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FrmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(832, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSignup";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.FrmSignup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPasswordlabel;
        private System.Windows.Forms.Label lblPasswordlabel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton rbtnratherNotSay;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblMiddleNamelabel;
        private System.Windows.Forms.Label lblEmaillabel;
        private System.Windows.Forms.Label lblLastNamelabel;
        private System.Windows.Forms.Label lblFirstNamelabel;
        private System.Windows.Forms.Button btnSignUP;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSignUplable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWelcomeToJAHlabel;
    }
}
namespace JAHub_Winforms
{
    partial class FrmAdminCreateNewUser
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
            this.flpAdminCreateNewUser = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCreateUser = new System.Windows.Forms.Label();
            this.flpSelectUserRole = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.flpControlsHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.flpUserCreationFields = new System.Windows.Forms.FlowLayoutPanel();
            this.usrNameBlock1 = new JAHub_Winforms.Verification.usrNameBlock();
            this.tlpEmailEntry = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmailEntry = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tlpPasswordEntry = new System.Windows.Forms.TableLayoutPanel();
            this.txtPasswordSecondEntry = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.txtPasswordFirstEntry = new System.Windows.Forms.TextBox();
            this.btnSubmitRecord = new System.Windows.Forms.Button();
            this.errCreateNewUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.flpAdminCreateNewUser.SuspendLayout();
            this.flpSelectUserRole.SuspendLayout();
            this.flpUserCreationFields.SuspendLayout();
            this.tlpEmailEntry.SuspendLayout();
            this.tlpPasswordEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCreateNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // flpAdminCreateNewUser
            // 
            this.flpAdminCreateNewUser.AutoSize = true;
            this.flpAdminCreateNewUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpAdminCreateNewUser.Controls.Add(this.lblCreateUser);
            this.flpAdminCreateNewUser.Controls.Add(this.flpSelectUserRole);
            this.flpAdminCreateNewUser.Controls.Add(this.flpControlsHolder);
            this.flpAdminCreateNewUser.Controls.Add(this.flpUserCreationFields);
            this.flpAdminCreateNewUser.Controls.Add(this.btnSubmitRecord);
            this.flpAdminCreateNewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAdminCreateNewUser.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAdminCreateNewUser.Location = new System.Drawing.Point(0, 0);
            this.flpAdminCreateNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.flpAdminCreateNewUser.Name = "flpAdminCreateNewUser";
            this.flpAdminCreateNewUser.Size = new System.Drawing.Size(607, 498);
            this.flpAdminCreateNewUser.TabIndex = 0;
            this.flpAdminCreateNewUser.WrapContents = false;
            // 
            // lblCreateUser
            // 
            this.lblCreateUser.AutoSize = true;
            this.lblCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateUser.Location = new System.Drawing.Point(4, 0);
            this.lblCreateUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateUser.Name = "lblCreateUser";
            this.lblCreateUser.Size = new System.Drawing.Size(198, 29);
            this.lblCreateUser.TabIndex = 0;
            this.lblCreateUser.Text = "Create New User";
            // 
            // flpSelectUserRole
            // 
            this.flpSelectUserRole.AutoSize = true;
            this.flpSelectUserRole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpSelectUserRole.Controls.Add(this.lblUserRole);
            this.flpSelectUserRole.Controls.Add(this.cmbUserRole);
            this.flpSelectUserRole.Location = new System.Drawing.Point(4, 33);
            this.flpSelectUserRole.Margin = new System.Windows.Forms.Padding(4);
            this.flpSelectUserRole.Name = "flpSelectUserRole";
            this.flpSelectUserRole.Size = new System.Drawing.Size(260, 36);
            this.flpSelectUserRole.TabIndex = 1;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(4, 8);
            this.lblUserRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(94, 20);
            this.lblUserRole.TabIndex = 1;
            this.lblUserRole.Text = "User Role: ";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "General User",
            "Farmer",
            "Customer",
            "Grant Agent",
            "Administrator"});
            this.cmbUserRole.Location = new System.Drawing.Point(106, 4);
            this.cmbUserRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(150, 28);
            this.cmbUserRole.TabIndex = 0;
            // 
            // flpControlsHolder
            // 
            this.flpControlsHolder.AutoSize = true;
            this.flpControlsHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpControlsHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpControlsHolder.Location = new System.Drawing.Point(3, 76);
            this.flpControlsHolder.Name = "flpControlsHolder";
            this.flpControlsHolder.Size = new System.Drawing.Size(0, 0);
            this.flpControlsHolder.TabIndex = 2;
            this.flpControlsHolder.WrapContents = false;
            // 
            // flpUserCreationFields
            // 
            this.flpUserCreationFields.AutoSize = true;
            this.flpUserCreationFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpUserCreationFields.Controls.Add(this.usrNameBlock1);
            this.flpUserCreationFields.Controls.Add(this.tlpEmailEntry);
            this.flpUserCreationFields.Controls.Add(this.tlpPasswordEntry);
            this.flpUserCreationFields.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpUserCreationFields.Location = new System.Drawing.Point(3, 82);
            this.flpUserCreationFields.Name = "flpUserCreationFields";
            this.flpUserCreationFields.Size = new System.Drawing.Size(425, 258);
            this.flpUserCreationFields.TabIndex = 4;
            this.flpUserCreationFields.WrapContents = false;
            // 
            // usrNameBlock1
            // 
            this.usrNameBlock1.AutoSize = true;
            this.usrNameBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrNameBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrNameBlock1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usrNameBlock1.Location = new System.Drawing.Point(0, 0);
            this.usrNameBlock1.Margin = new System.Windows.Forms.Padding(0);
            this.usrNameBlock1.Name = "usrNameBlock1";
            this.usrNameBlock1.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.usrNameBlock1.Size = new System.Drawing.Size(425, 124);
            this.usrNameBlock1.TabIndex = 1;
            // 
            // tlpEmailEntry
            // 
            this.tlpEmailEntry.ColumnCount = 2;
            this.tlpEmailEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpEmailEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmailEntry.Controls.Add(this.lblEmailEntry, 0, 0);
            this.tlpEmailEntry.Controls.Add(this.txtEmail, 1, 0);
            this.tlpEmailEntry.Location = new System.Drawing.Point(3, 127);
            this.tlpEmailEntry.Name = "tlpEmailEntry";
            this.tlpEmailEntry.RowCount = 1;
            this.tlpEmailEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmailEntry.Size = new System.Drawing.Size(363, 48);
            this.tlpEmailEntry.TabIndex = 2;
            // 
            // lblEmailEntry
            // 
            this.lblEmailEntry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmailEntry.AutoSize = true;
            this.lblEmailEntry.Location = new System.Drawing.Point(28, 14);
            this.lblEmailEntry.Name = "lblEmailEntry";
            this.lblEmailEntry.Size = new System.Drawing.Size(129, 20);
            this.lblEmailEntry.TabIndex = 0;
            this.lblEmailEntry.Text = "Email Address*:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(163, 10);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 27);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // tlpPasswordEntry
            // 
            this.tlpPasswordEntry.ColumnCount = 2;
            this.tlpPasswordEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpPasswordEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPasswordEntry.Controls.Add(this.txtPasswordSecondEntry, 1, 1);
            this.tlpPasswordEntry.Controls.Add(this.lblPassword, 0, 0);
            this.tlpPasswordEntry.Controls.Add(this.lblRetypePassword, 0, 1);
            this.tlpPasswordEntry.Controls.Add(this.txtPasswordFirstEntry, 1, 0);
            this.tlpPasswordEntry.Location = new System.Drawing.Point(3, 181);
            this.tlpPasswordEntry.Name = "tlpPasswordEntry";
            this.tlpPasswordEntry.RowCount = 2;
            this.tlpPasswordEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPasswordEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPasswordEntry.Size = new System.Drawing.Size(363, 74);
            this.tlpPasswordEntry.TabIndex = 5;
            // 
            // txtPasswordSecondEntry
            // 
            this.txtPasswordSecondEntry.Location = new System.Drawing.Point(163, 36);
            this.txtPasswordSecondEntry.Name = "txtPasswordSecondEntry";
            this.txtPasswordSecondEntry.PasswordChar = '*';
            this.txtPasswordSecondEntry.Size = new System.Drawing.Size(161, 27);
            this.txtPasswordSecondEntry.TabIndex = 4;
            this.txtPasswordSecondEntry.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordSecondEntry_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(63, 6);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password*:";
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Location = new System.Drawing.Point(5, 43);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(152, 20);
            this.lblRetypePassword.TabIndex = 2;
            this.lblRetypePassword.Text = "Repeat Password*:";
            // 
            // txtPasswordFirstEntry
            // 
            this.txtPasswordFirstEntry.Location = new System.Drawing.Point(163, 3);
            this.txtPasswordFirstEntry.Name = "txtPasswordFirstEntry";
            this.txtPasswordFirstEntry.PasswordChar = '*';
            this.txtPasswordFirstEntry.Size = new System.Drawing.Size(161, 27);
            this.txtPasswordFirstEntry.TabIndex = 3;
            this.txtPasswordFirstEntry.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordFirstEntry_Validating);
            // 
            // btnSubmitRecord
            // 
            this.btnSubmitRecord.Location = new System.Drawing.Point(3, 346);
            this.btnSubmitRecord.Name = "btnSubmitRecord";
            this.btnSubmitRecord.Size = new System.Drawing.Size(199, 39);
            this.btnSubmitRecord.TabIndex = 5;
            this.btnSubmitRecord.Text = "Create New Account";
            this.btnSubmitRecord.UseVisualStyleBackColor = true;
            this.btnSubmitRecord.Click += new System.EventHandler(this.btnSubmitRecord_Click);
            // 
            // errCreateNewUser
            // 
            this.errCreateNewUser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCreateNewUser.ContainerControl = this;
            // 
            // FrmAdminCreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 498);
            this.Controls.Add(this.flpAdminCreateNewUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminCreateNewUser";
            this.Text = "FrmAdminCreateNewUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdminCreateNewUser_Load);
            this.flpAdminCreateNewUser.ResumeLayout(false);
            this.flpAdminCreateNewUser.PerformLayout();
            this.flpSelectUserRole.ResumeLayout(false);
            this.flpSelectUserRole.PerformLayout();
            this.flpUserCreationFields.ResumeLayout(false);
            this.flpUserCreationFields.PerformLayout();
            this.tlpEmailEntry.ResumeLayout(false);
            this.tlpEmailEntry.PerformLayout();
            this.tlpPasswordEntry.ResumeLayout(false);
            this.tlpPasswordEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCreateNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAdminCreateNewUser;
        private System.Windows.Forms.Label lblCreateUser;
        private System.Windows.Forms.FlowLayoutPanel flpSelectUserRole;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.FlowLayoutPanel flpControlsHolder;
        private System.Windows.Forms.Button btnSubmitRecord;
        private System.Windows.Forms.FlowLayoutPanel flpUserCreationFields;
        private Verification.usrNameBlock usrNameBlock1;
        private System.Windows.Forms.TableLayoutPanel tlpPasswordEntry;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.TableLayoutPanel tlpEmailEntry;
        private System.Windows.Forms.Label lblEmailEntry;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ErrorProvider errCreateNewUser;
        private System.Windows.Forms.TextBox txtPasswordSecondEntry;
        private System.Windows.Forms.TextBox txtPasswordFirstEntry;
    }
}
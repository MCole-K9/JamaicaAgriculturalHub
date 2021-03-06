namespace JAHub_Winforms
{
    partial class FrmAdminEditUser
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
            this.flpAdminEditUser = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEditUser = new System.Windows.Forms.Label();
            this.flwControlsHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpEmailEntry = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmailEntry = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.tlpPasswordEntry = new System.Windows.Forms.TableLayoutPanel();
            this.txtPasswordSecondEntry = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.txtPasswordFirstEntry = new System.Windows.Forms.TextBox();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.errEditUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.flpAdminEditUser.SuspendLayout();
            this.flwControlsHolder.SuspendLayout();
            this.tlpEmailEntry.SuspendLayout();
            this.tlpPasswordEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEditUser)).BeginInit();
            this.SuspendLayout();
            // 
            // flpAdminEditUser
            // 
            this.flpAdminEditUser.Controls.Add(this.lblEditUser);
            this.flpAdminEditUser.Controls.Add(this.flwControlsHolder);
            this.flpAdminEditUser.Controls.Add(this.btnUpdateRecord);
            this.flpAdminEditUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAdminEditUser.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAdminEditUser.Location = new System.Drawing.Point(0, 0);
            this.flpAdminEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.flpAdminEditUser.Name = "flpAdminEditUser";
            this.flpAdminEditUser.Size = new System.Drawing.Size(489, 388);
            this.flpAdminEditUser.TabIndex = 1;
            // 
            // lblEditUser
            // 
            this.lblEditUser.AutoSize = true;
            this.lblEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUser.Location = new System.Drawing.Point(4, 0);
            this.lblEditUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditUser.Name = "lblEditUser";
            this.lblEditUser.Size = new System.Drawing.Size(249, 29);
            this.lblEditUser.TabIndex = 0;
            this.lblEditUser.Text = "Edit User: [Username]";
            // 
            // flwControlsHolder
            // 
            this.flwControlsHolder.AutoSize = true;
            this.flwControlsHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwControlsHolder.Controls.Add(this.tlpEmailEntry);
            this.flwControlsHolder.Controls.Add(this.chkShowPassword);
            this.flwControlsHolder.Controls.Add(this.tlpPasswordEntry);
            this.flwControlsHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwControlsHolder.Location = new System.Drawing.Point(3, 32);
            this.flwControlsHolder.Name = "flwControlsHolder";
            this.flwControlsHolder.Size = new System.Drawing.Size(369, 164);
            this.flwControlsHolder.TabIndex = 2;
            this.flwControlsHolder.WrapContents = false;
            // 
            // tlpEmailEntry
            // 
            this.tlpEmailEntry.ColumnCount = 2;
            this.tlpEmailEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpEmailEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmailEntry.Controls.Add(this.lblEmailEntry, 0, 0);
            this.tlpEmailEntry.Controls.Add(this.txtEmail, 1, 0);
            this.tlpEmailEntry.Location = new System.Drawing.Point(3, 3);
            this.tlpEmailEntry.Name = "tlpEmailEntry";
            this.tlpEmailEntry.RowCount = 1;
            this.tlpEmailEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmailEntry.Size = new System.Drawing.Size(363, 48);
            this.tlpEmailEntry.TabIndex = 7;
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
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShowPassword.Location = new System.Drawing.Point(3, 57);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(161, 24);
            this.chkShowPassword.TabIndex = 1;
            this.chkShowPassword.Text = "Show Password: ";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
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
            this.tlpPasswordEntry.Location = new System.Drawing.Point(3, 87);
            this.tlpPasswordEntry.Name = "tlpPasswordEntry";
            this.tlpPasswordEntry.RowCount = 2;
            this.tlpPasswordEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPasswordEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPasswordEntry.Size = new System.Drawing.Size(363, 74);
            this.tlpPasswordEntry.TabIndex = 8;
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
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(3, 202);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(129, 32);
            this.btnUpdateRecord.TabIndex = 3;
            this.btnUpdateRecord.Text = "Update";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // errEditUser
            // 
            this.errEditUser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errEditUser.ContainerControl = this;
            // 
            // FrmAdminEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 388);
            this.Controls.Add(this.flpAdminEditUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminEditUser";
            this.Text = "FrmAdminEditUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flpAdminEditUser.ResumeLayout(false);
            this.flpAdminEditUser.PerformLayout();
            this.flwControlsHolder.ResumeLayout(false);
            this.flwControlsHolder.PerformLayout();
            this.tlpEmailEntry.ResumeLayout(false);
            this.tlpEmailEntry.PerformLayout();
            this.tlpPasswordEntry.ResumeLayout(false);
            this.tlpPasswordEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEditUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAdminEditUser;
        private System.Windows.Forms.Label lblEditUser;
        private System.Windows.Forms.FlowLayoutPanel flwControlsHolder;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.TableLayoutPanel tlpEmailEntry;
        private System.Windows.Forms.Label lblEmailEntry;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TableLayoutPanel tlpPasswordEntry;
        private System.Windows.Forms.TextBox txtPasswordSecondEntry;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.TextBox txtPasswordFirstEntry;
        private System.Windows.Forms.ErrorProvider errEditUser;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}
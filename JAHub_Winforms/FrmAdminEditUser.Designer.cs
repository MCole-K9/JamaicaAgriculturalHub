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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEditUser = new System.Windows.Forms.Label();
            this.flwControlsHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.tblEmailEntry = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmailEntry = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tblPasswordEntry = new System.Windows.Forms.TableLayoutPanel();
            this.txtPasswordSecondEntry = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.txtPasswordFirstEntry = new System.Windows.Forms.TextBox();
            this.errEditUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.flwControlsHolder.SuspendLayout();
            this.tblEmailEntry.SuspendLayout();
            this.tblPasswordEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEditUser)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblEditUser);
            this.flowLayoutPanel1.Controls.Add(this.flwControlsHolder);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateRecord);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 388);
            this.flowLayoutPanel1.TabIndex = 1;
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
            this.flwControlsHolder.Controls.Add(this.tblEmailEntry);
            this.flwControlsHolder.Controls.Add(this.tblPasswordEntry);
            this.flwControlsHolder.Location = new System.Drawing.Point(3, 32);
            this.flwControlsHolder.Name = "flwControlsHolder";
            this.flwControlsHolder.Size = new System.Drawing.Size(369, 134);
            this.flwControlsHolder.TabIndex = 2;
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(3, 172);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(129, 32);
            this.btnUpdateRecord.TabIndex = 3;
            this.btnUpdateRecord.Text = "Update";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // tblEmailEntry
            // 
            this.tblEmailEntry.ColumnCount = 2;
            this.tblEmailEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblEmailEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEmailEntry.Controls.Add(this.lblEmailEntry, 0, 0);
            this.tblEmailEntry.Controls.Add(this.txtEmail, 1, 0);
            this.tblEmailEntry.Location = new System.Drawing.Point(3, 3);
            this.tblEmailEntry.Name = "tblEmailEntry";
            this.tblEmailEntry.RowCount = 1;
            this.tblEmailEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEmailEntry.Size = new System.Drawing.Size(363, 48);
            this.tblEmailEntry.TabIndex = 7;
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
            // 
            // tblPasswordEntry
            // 
            this.tblPasswordEntry.ColumnCount = 2;
            this.tblPasswordEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblPasswordEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPasswordEntry.Controls.Add(this.txtPasswordSecondEntry, 1, 1);
            this.tblPasswordEntry.Controls.Add(this.lblPassword, 0, 0);
            this.tblPasswordEntry.Controls.Add(this.lblRetypePassword, 0, 1);
            this.tblPasswordEntry.Controls.Add(this.txtPasswordFirstEntry, 1, 0);
            this.tblPasswordEntry.Location = new System.Drawing.Point(3, 57);
            this.tblPasswordEntry.Name = "tblPasswordEntry";
            this.tblPasswordEntry.RowCount = 2;
            this.tblPasswordEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPasswordEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPasswordEntry.Size = new System.Drawing.Size(363, 74);
            this.tblPasswordEntry.TabIndex = 8;
            // 
            // txtPasswordSecondEntry
            // 
            this.txtPasswordSecondEntry.Location = new System.Drawing.Point(163, 36);
            this.txtPasswordSecondEntry.Name = "txtPasswordSecondEntry";
            this.txtPasswordSecondEntry.PasswordChar = '*';
            this.txtPasswordSecondEntry.Size = new System.Drawing.Size(161, 27);
            this.txtPasswordSecondEntry.TabIndex = 4;
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
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminEditUser";
            this.Text = "FrmAdminEditUser";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flwControlsHolder.ResumeLayout(false);
            this.tblEmailEntry.ResumeLayout(false);
            this.tblEmailEntry.PerformLayout();
            this.tblPasswordEntry.ResumeLayout(false);
            this.tblPasswordEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEditUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblEditUser;
        private System.Windows.Forms.FlowLayoutPanel flwControlsHolder;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.TableLayoutPanel tblEmailEntry;
        private System.Windows.Forms.Label lblEmailEntry;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TableLayoutPanel tblPasswordEntry;
        private System.Windows.Forms.TextBox txtPasswordSecondEntry;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.TextBox txtPasswordFirstEntry;
        private System.Windows.Forms.ErrorProvider errEditUser;
    }
}
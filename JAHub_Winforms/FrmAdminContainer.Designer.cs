namespace JAHub_Winforms
{
    partial class FrmAdminContainer
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
            this.flpOptionsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpCurrentUser = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserIdValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRoleValue = new System.Windows.Forms.Label();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnViewModeration = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.pnlFormHolder = new System.Windows.Forms.Panel();
            this.flpOptionsContainer.SuspendLayout();
            this.tlpCurrentUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpOptionsContainer
            // 
            this.flpOptionsContainer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.flpOptionsContainer.Controls.Add(this.tlpCurrentUser);
            this.flpOptionsContainer.Controls.Add(this.btnSelectUser);
            this.flpOptionsContainer.Controls.Add(this.btnEditUser);
            this.flpOptionsContainer.Controls.Add(this.btnViewModeration);
            this.flpOptionsContainer.Controls.Add(this.btnDeleteUser);
            this.flpOptionsContainer.Controls.Add(this.btnCreateNewUser);
            this.flpOptionsContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpOptionsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOptionsContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpOptionsContainer.Location = new System.Drawing.Point(0, 0);
            this.flpOptionsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.flpOptionsContainer.Name = "flpOptionsContainer";
            this.flpOptionsContainer.Size = new System.Drawing.Size(200, 451);
            this.flpOptionsContainer.TabIndex = 0;
            // 
            // tlpCurrentUser
            // 
            this.tlpCurrentUser.AutoSize = true;
            this.tlpCurrentUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCurrentUser.ColumnCount = 2;
            this.tlpCurrentUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurrentUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurrentUser.Controls.Add(this.lblCurrentUser, 0, 0);
            this.tlpCurrentUser.Controls.Add(this.lblUserId, 0, 1);
            this.tlpCurrentUser.Controls.Add(this.lblUserIdValue, 1, 1);
            this.tlpCurrentUser.Controls.Add(this.lblName, 0, 2);
            this.tlpCurrentUser.Controls.Add(this.lblNameValue, 1, 2);
            this.tlpCurrentUser.Controls.Add(this.lblRole, 0, 3);
            this.tlpCurrentUser.Controls.Add(this.lblRoleValue, 1, 3);
            this.tlpCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpCurrentUser.Location = new System.Drawing.Point(3, 3);
            this.tlpCurrentUser.Name = "tlpCurrentUser";
            this.tlpCurrentUser.RowCount = 4;
            this.tlpCurrentUser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCurrentUser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentUser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentUser.Size = new System.Drawing.Size(140, 85);
            this.tlpCurrentUser.TabIndex = 6;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.tlpCurrentUser.SetColumnSpan(this.lblCurrentUser, 2);
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(3, 0);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(134, 25);
            this.lblCurrentUser.TabIndex = 5;
            this.lblCurrentUser.Text = "Current User: ";
            // 
            // lblUserId
            // 
            this.lblUserId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(3, 25);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(72, 20);
            this.lblUserId.TabIndex = 6;
            this.lblUserId.Text = "User ID:";
            // 
            // lblUserIdValue
            // 
            this.lblUserIdValue.AutoSize = true;
            this.lblUserIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIdValue.Location = new System.Drawing.Point(81, 25);
            this.lblUserIdValue.Name = "lblUserIdValue";
            this.lblUserIdValue.Size = new System.Drawing.Size(0, 20);
            this.lblUserIdValue.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(81, 45);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(0, 20);
            this.lblNameValue.TabIndex = 9;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(27, 65);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 20);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Role:";
            // 
            // lblRoleValue
            // 
            this.lblRoleValue.AutoSize = true;
            this.lblRoleValue.Location = new System.Drawing.Point(81, 65);
            this.lblRoleValue.Name = "lblRoleValue";
            this.lblRoleValue.Size = new System.Drawing.Size(0, 20);
            this.lblRoleValue.TabIndex = 7;
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Location = new System.Drawing.Point(3, 94);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(191, 42);
            this.btnSelectUser.TabIndex = 0;
            this.btnSelectUser.Text = "Select User";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(3, 142);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(191, 39);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.Text = "Edit User Information";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Visible = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnViewModeration
            // 
            this.btnViewModeration.Location = new System.Drawing.Point(3, 187);
            this.btnViewModeration.Name = "btnViewModeration";
            this.btnViewModeration.Size = new System.Drawing.Size(191, 34);
            this.btnViewModeration.TabIndex = 2;
            this.btnViewModeration.Text = "View Moderation Log";
            this.btnViewModeration.UseVisualStyleBackColor = true;
            this.btnViewModeration.Visible = false;
            this.btnViewModeration.Click += new System.EventHandler(this.btnViewModeration_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(3, 227);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(191, 36);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "Delete User Account";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Visible = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.Location = new System.Drawing.Point(3, 269);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(191, 42);
            this.btnCreateNewUser.TabIndex = 4;
            this.btnCreateNewUser.Text = "Create New User";
            this.btnCreateNewUser.UseVisualStyleBackColor = true;
            this.btnCreateNewUser.Click += new System.EventHandler(this.btnCreateNewUser_Click);
            // 
            // pnlFormHolder
            // 
            this.pnlFormHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFormHolder.Location = new System.Drawing.Point(200, 0);
            this.pnlFormHolder.Name = "pnlFormHolder";
            this.pnlFormHolder.Size = new System.Drawing.Size(724, 451);
            this.pnlFormHolder.TabIndex = 1;
            this.pnlFormHolder.SizeChanged += new System.EventHandler(this.pnlFormHolder_SizeChanged);
            // 
            // FrmAdminContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 451);
            this.Controls.Add(this.pnlFormHolder);
            this.Controls.Add(this.flpOptionsContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdminContainer";
            this.Text = "Admininstration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flpOptionsContainer.ResumeLayout(false);
            this.flpOptionsContainer.PerformLayout();
            this.tlpCurrentUser.ResumeLayout(false);
            this.tlpCurrentUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpOptionsContainer;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Button btnCreateNewUser;
        private System.Windows.Forms.Button btnViewModeration;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.TableLayoutPanel tlpCurrentUser;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUserIdValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblRoleValue;
        private System.Windows.Forms.Panel pnlFormHolder;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}
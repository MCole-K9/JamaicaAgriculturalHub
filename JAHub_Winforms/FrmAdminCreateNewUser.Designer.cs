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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCreateUser = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.flwControlsHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmitRecord = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCreateUser);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flwControlsHolder);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmitRecord);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 381);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.lblUserRole);
            this.flowLayoutPanel2.Controls.Add(this.cmbUserRole);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 33);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(260, 36);
            this.flowLayoutPanel2.TabIndex = 1;
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
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flwControlsHolder
            // 
            this.flwControlsHolder.AutoSize = true;
            this.flwControlsHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwControlsHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwControlsHolder.Location = new System.Drawing.Point(3, 76);
            this.flwControlsHolder.Name = "flwControlsHolder";
            this.flwControlsHolder.Size = new System.Drawing.Size(0, 0);
            this.flwControlsHolder.TabIndex = 2;
            // 
            // btnSubmitRecord
            // 
            this.btnSubmitRecord.Location = new System.Drawing.Point(3, 82);
            this.btnSubmitRecord.Name = "btnSubmitRecord";
            this.btnSubmitRecord.Size = new System.Drawing.Size(99, 39);
            this.btnSubmitRecord.TabIndex = 3;
            this.btnSubmitRecord.Text = "button1";
            this.btnSubmitRecord.UseVisualStyleBackColor = true;
            // 
            // FrmAdminCreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 381);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminCreateNewUser";
            this.Text = "FrmAdminCreateNewUser";
            this.Load += new System.EventHandler(this.FrmAdminCreateNewUser_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCreateUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.FlowLayoutPanel flwControlsHolder;
        private System.Windows.Forms.Button btnSubmitRecord;
    }
}
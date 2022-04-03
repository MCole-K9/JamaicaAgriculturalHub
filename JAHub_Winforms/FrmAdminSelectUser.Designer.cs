namespace JAHub_Winforms
{
    partial class FrmAdminSelectUser
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
            this.dgvUserInformation = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GovernmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnClearSearchTerm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInformation)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserInformation
            // 
            this.dgvUserInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.GovernmentName,
            this.userRole,
            this.selectUser});
            this.dgvUserInformation.Location = new System.Drawing.Point(4, 51);
            this.dgvUserInformation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserInformation.Name = "dgvUserInformation";
            this.dgvUserInformation.RowHeadersWidth = 51;
            this.dgvUserInformation.RowTemplate.Height = 24;
            this.dgvUserInformation.Size = new System.Drawing.Size(552, 188);
            this.dgvUserInformation.TabIndex = 0;
            this.dgvUserInformation.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserInformation_CellMouseClick);
            // 
            // userId
            // 
            this.userId.HeaderText = "User ID";
            this.userId.MinimumWidth = 6;
            this.userId.Name = "userId";
            this.userId.Width = 125;
            // 
            // GovernmentName
            // 
            this.GovernmentName.HeaderText = "Name";
            this.GovernmentName.MinimumWidth = 6;
            this.GovernmentName.Name = "GovernmentName";
            this.GovernmentName.Width = 125;
            // 
            // userRole
            // 
            this.userRole.HeaderText = "Role";
            this.userRole.MinimumWidth = 6;
            this.userRole.Name = "userRole";
            this.userRole.Width = 125;
            // 
            // selectUser
            // 
            this.selectUser.HeaderText = "Select User";
            this.selectUser.MinimumWidth = 6;
            this.selectUser.Name = "selectUser";
            this.selectUser.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.dgvUserInformation);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(849, 443);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearSearchTerm, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 39);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(70, 10);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(138, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search by Name:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearchBox.Location = new System.Drawing.Point(216, 6);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(204, 27);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // btnClearSearchTerm
            // 
            this.btnClearSearchTerm.Location = new System.Drawing.Point(428, 4);
            this.btnClearSearchTerm.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearSearchTerm.Name = "btnClearSearchTerm";
            this.btnClearSearchTerm.Size = new System.Drawing.Size(124, 32);
            this.btnClearSearchTerm.TabIndex = 2;
            this.btnClearSearchTerm.Text = "Clear Search";
            this.btnClearSearchTerm.UseVisualStyleBackColor = true;
            this.btnClearSearchTerm.Click += new System.EventHandler(this.btnClearSearchTerm_Click);
            // 
            // FrmAdminSelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 443);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminSelectUser";
            this.Text = "Select User (This should not be visible!)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdminSelectUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInformation)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserInformation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnClearSearchTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GovernmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectUser;
    }
}
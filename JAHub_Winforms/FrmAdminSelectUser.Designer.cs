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
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGovernmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpAdminSelectUser = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpSearchOption = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnClearSearchTerm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInformation)).BeginInit();
            this.flpAdminSelectUser.SuspendLayout();
            this.tlpSearchOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserInformation
            // 
            this.dgvUserInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserId,
            this.colGovernmentName,
            this.colUserRole,
            this.colSelectUser});
            this.dgvUserInformation.Location = new System.Drawing.Point(4, 51);
            this.dgvUserInformation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserInformation.Name = "dgvUserInformation";
            this.dgvUserInformation.RowHeadersWidth = 51;
            this.dgvUserInformation.RowTemplate.Height = 24;
            this.dgvUserInformation.Size = new System.Drawing.Size(552, 188);
            this.dgvUserInformation.TabIndex = 0;
            this.dgvUserInformation.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserInformation_CellMouseClick);
            // 
            // colUserId
            // 
            this.colUserId.HeaderText = "User ID";
            this.colUserId.MinimumWidth = 6;
            this.colUserId.Name = "colUserId";
            this.colUserId.Width = 125;
            // 
            // colGovernmentName
            // 
            this.colGovernmentName.HeaderText = "Name";
            this.colGovernmentName.MinimumWidth = 6;
            this.colGovernmentName.Name = "colGovernmentName";
            this.colGovernmentName.Width = 125;
            // 
            // colUserRole
            // 
            this.colUserRole.HeaderText = "Role";
            this.colUserRole.MinimumWidth = 6;
            this.colUserRole.Name = "colUserRole";
            this.colUserRole.Width = 125;
            // 
            // colSelectUser
            // 
            this.colSelectUser.HeaderText = "Select User";
            this.colSelectUser.MinimumWidth = 6;
            this.colSelectUser.Name = "colSelectUser";
            this.colSelectUser.Width = 125;
            // 
            // flpAdminSelectUser
            // 
            this.flpAdminSelectUser.BackColor = System.Drawing.Color.White;
            this.flpAdminSelectUser.Controls.Add(this.tlpSearchOption);
            this.flpAdminSelectUser.Controls.Add(this.dgvUserInformation);
            this.flpAdminSelectUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAdminSelectUser.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAdminSelectUser.Location = new System.Drawing.Point(0, 0);
            this.flpAdminSelectUser.Margin = new System.Windows.Forms.Padding(4);
            this.flpAdminSelectUser.Name = "flpAdminSelectUser";
            this.flpAdminSelectUser.Size = new System.Drawing.Size(849, 443);
            this.flpAdminSelectUser.TabIndex = 1;
            // 
            // tlpSearchOption
            // 
            this.tlpSearchOption.ColumnCount = 3;
            this.tlpSearchOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSearchOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpSearchOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpSearchOption.Controls.Add(this.lblSearch, 0, 0);
            this.tlpSearchOption.Controls.Add(this.txtSearchBox, 1, 0);
            this.tlpSearchOption.Controls.Add(this.btnClearSearchTerm, 2, 0);
            this.tlpSearchOption.Location = new System.Drawing.Point(4, 4);
            this.tlpSearchOption.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSearchOption.Name = "tlpSearchOption";
            this.tlpSearchOption.RowCount = 1;
            this.tlpSearchOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearchOption.Size = new System.Drawing.Size(637, 39);
            this.tlpSearchOption.TabIndex = 1;
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
            this.Controls.Add(this.flpAdminSelectUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminSelectUser";
            this.Text = "Select User (This should not be visible!)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdminSelectUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInformation)).EndInit();
            this.flpAdminSelectUser.ResumeLayout(false);
            this.tlpSearchOption.ResumeLayout(false);
            this.tlpSearchOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserInformation;
        private System.Windows.Forms.FlowLayoutPanel flpAdminSelectUser;
        private System.Windows.Forms.TableLayoutPanel tlpSearchOption;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnClearSearchTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGovernmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectUser;
    }
}
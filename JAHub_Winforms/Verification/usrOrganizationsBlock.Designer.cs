namespace JAHub_Winforms.Verification
{
    partial class usrOrganizationsBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblOrganizationsBlock = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrganizations = new System.Windows.Forms.Label();
            this.lblPleaseListOrganizations = new System.Windows.Forms.Label();
            this.btnAddAnotherOrganization = new System.Windows.Forms.Button();
            this.txtOrganizationEntry = new System.Windows.Forms.TextBox();
            this.tblOrganizationsBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblOrganizationsBlock
            // 
            this.tblOrganizationsBlock.ColumnCount = 2;
            this.tblOrganizationsBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOrganizationsBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOrganizationsBlock.Controls.Add(this.lblOrganizations, 0, 0);
            this.tblOrganizationsBlock.Controls.Add(this.btnAddAnotherOrganization, 0, 3);
            this.tblOrganizationsBlock.Controls.Add(this.lblPleaseListOrganizations, 0, 1);
            this.tblOrganizationsBlock.Controls.Add(this.txtOrganizationEntry, 0, 2);
            this.tblOrganizationsBlock.Location = new System.Drawing.Point(3, 3);
            this.tblOrganizationsBlock.Name = "tblOrganizationsBlock";
            this.tblOrganizationsBlock.RowCount = 4;
            this.tblOrganizationsBlock.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrganizationsBlock.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrganizationsBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblOrganizationsBlock.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrganizationsBlock.Size = new System.Drawing.Size(442, 146);
            this.tblOrganizationsBlock.TabIndex = 0;
            this.tblOrganizationsBlock.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblOrganizations
            // 
            this.lblOrganizations.AutoSize = true;
            this.lblOrganizations.Location = new System.Drawing.Point(3, 0);
            this.lblOrganizations.Name = "lblOrganizations";
            this.lblOrganizations.Size = new System.Drawing.Size(89, 16);
            this.lblOrganizations.TabIndex = 0;
            this.lblOrganizations.Text = "Organizations";
            // 
            // lblPleaseListOrganizations
            // 
            this.lblPleaseListOrganizations.AutoSize = true;
            this.tblOrganizationsBlock.SetColumnSpan(this.lblPleaseListOrganizations, 2);
            this.lblPleaseListOrganizations.Location = new System.Drawing.Point(3, 16);
            this.lblPleaseListOrganizations.Name = "lblPleaseListOrganizations";
            this.lblPleaseListOrganizations.Size = new System.Drawing.Size(436, 48);
            this.lblPleaseListOrganizations.TabIndex = 1;
            this.lblPleaseListOrganizations.Text = "Please list any relevant Organizations or Commodity Boards you may be a part of, " +
    "(for example: The Coffee Growers Association). If you are not a part of any orga" +
    "nization, leave this field blank";
            // 
            // btnAddAnotherOrganization
            // 
            this.btnAddAnotherOrganization.Location = new System.Drawing.Point(3, 87);
            this.btnAddAnotherOrganization.Name = "btnAddAnotherOrganization";
            this.btnAddAnotherOrganization.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnotherOrganization.TabIndex = 2;
            this.btnAddAnotherOrganization.Text = "button1";
            this.btnAddAnotherOrganization.UseVisualStyleBackColor = true;
            // 
            // txtOrganizationEntry
            // 
            this.txtOrganizationEntry.Location = new System.Drawing.Point(3, 67);
            this.txtOrganizationEntry.Name = "txtOrganizationEntry";
            this.txtOrganizationEntry.Size = new System.Drawing.Size(100, 22);
            this.txtOrganizationEntry.TabIndex = 3;
            // 
            // usrOrganizationsBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tblOrganizationsBlock);
            this.Name = "usrOrganizationsBlock";
            this.Size = new System.Drawing.Size(448, 152);
            this.tblOrganizationsBlock.ResumeLayout(false);
            this.tblOrganizationsBlock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblOrganizationsBlock;
        private System.Windows.Forms.Label lblOrganizations;
        private System.Windows.Forms.Label lblPleaseListOrganizations;
        private System.Windows.Forms.Button btnAddAnotherOrganization;
        private System.Windows.Forms.TextBox txtOrganizationEntry;
    }
}

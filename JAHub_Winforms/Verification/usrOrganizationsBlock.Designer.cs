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
            this.components = new System.ComponentModel.Container();
            this.lblOrganizations = new System.Windows.Forms.Label();
            this.btnAddAnotherOrganization = new System.Windows.Forms.Button();
            this.lblPleaseListOrganizations = new System.Windows.Forms.Label();
            this.txtOrganizationEntry = new System.Windows.Forms.TextBox();
            this.flwOrganizationBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.flwOrganizationsTextHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveOrganization = new System.Windows.Forms.Button();
            this.errOrganizationsBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.flwOrganizationBlock.SuspendLayout();
            this.flwOrganizationsTextHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errOrganizationsBlock)).BeginInit();
            this.SuspendLayout();
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
            // btnAddAnotherOrganization
            // 
            this.btnAddAnotherOrganization.Location = new System.Drawing.Point(3, 101);
            this.btnAddAnotherOrganization.Name = "btnAddAnotherOrganization";
            this.btnAddAnotherOrganization.Size = new System.Drawing.Size(178, 23);
            this.btnAddAnotherOrganization.TabIndex = 2;
            this.btnAddAnotherOrganization.Text = "Add Another Organization";
            this.btnAddAnotherOrganization.UseVisualStyleBackColor = true;
            // 
            // lblPleaseListOrganizations
            // 
            this.lblPleaseListOrganizations.Location = new System.Drawing.Point(3, 16);
            this.lblPleaseListOrganizations.Name = "lblPleaseListOrganizations";
            this.lblPleaseListOrganizations.Size = new System.Drawing.Size(500, 48);
            this.lblPleaseListOrganizations.TabIndex = 1;
            this.lblPleaseListOrganizations.Text = "Please list any relevant Organizations or Commodity Boards you may be a part of, " +
    "(for example: The Coffee Growers Association). If you are not a part of any orga" +
    "nization, leave this field blank";
            // 
            // txtOrganizationEntry
            // 
            this.txtOrganizationEntry.Location = new System.Drawing.Point(3, 3);
            this.txtOrganizationEntry.Name = "txtOrganizationEntry";
            this.txtOrganizationEntry.Size = new System.Drawing.Size(175, 22);
            this.txtOrganizationEntry.TabIndex = 3;
            // 
            // flwOrganizationBlock
            // 
            this.flwOrganizationBlock.AutoSize = true;
            this.flwOrganizationBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwOrganizationBlock.Controls.Add(this.lblOrganizations);
            this.flwOrganizationBlock.Controls.Add(this.lblPleaseListOrganizations);
            this.flwOrganizationBlock.Controls.Add(this.flwOrganizationsTextHolder);
            this.flwOrganizationBlock.Controls.Add(this.btnAddAnotherOrganization);
            this.flwOrganizationBlock.Controls.Add(this.btnRemoveOrganization);
            this.flwOrganizationBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwOrganizationBlock.Location = new System.Drawing.Point(3, 3);
            this.flwOrganizationBlock.Name = "flwOrganizationBlock";
            this.flwOrganizationBlock.Size = new System.Drawing.Size(506, 156);
            this.flwOrganizationBlock.TabIndex = 1;
            // 
            // flwOrganizationsTextHolder
            // 
            this.flwOrganizationsTextHolder.AutoSize = true;
            this.flwOrganizationsTextHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwOrganizationsTextHolder.Controls.Add(this.txtOrganizationEntry);
            this.flwOrganizationsTextHolder.Location = new System.Drawing.Point(3, 67);
            this.flwOrganizationsTextHolder.Name = "flwOrganizationsTextHolder";
            this.flwOrganizationsTextHolder.Size = new System.Drawing.Size(181, 28);
            this.flwOrganizationsTextHolder.TabIndex = 0;
            // 
            // btnRemoveOrganization
            // 
            this.btnRemoveOrganization.Location = new System.Drawing.Point(3, 130);
            this.btnRemoveOrganization.Name = "btnRemoveOrganization";
            this.btnRemoveOrganization.Size = new System.Drawing.Size(178, 23);
            this.btnRemoveOrganization.TabIndex = 3;
            this.btnRemoveOrganization.Text = "Remove Last Organization";
            this.btnRemoveOrganization.UseVisualStyleBackColor = true;
            // 
            // errOrganizationsBlock
            // 
            this.errOrganizationsBlock.ContainerControl = this;
            // 
            // usrOrganizationsBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flwOrganizationBlock);
            this.Name = "usrOrganizationsBlock";
            this.Size = new System.Drawing.Size(512, 162);
            this.flwOrganizationBlock.ResumeLayout(false);
            this.flwOrganizationBlock.PerformLayout();
            this.flwOrganizationsTextHolder.ResumeLayout(false);
            this.flwOrganizationsTextHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errOrganizationsBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrganizations;
        private System.Windows.Forms.Label lblPleaseListOrganizations;
        private System.Windows.Forms.Button btnAddAnotherOrganization;
        private System.Windows.Forms.TextBox txtOrganizationEntry;
        private System.Windows.Forms.FlowLayoutPanel flwOrganizationBlock;
        private System.Windows.Forms.FlowLayoutPanel flwOrganizationsTextHolder;
        private System.Windows.Forms.Button btnRemoveOrganization;
        private System.Windows.Forms.ErrorProvider errOrganizationsBlock;
    }
}

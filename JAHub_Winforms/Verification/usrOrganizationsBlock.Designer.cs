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
            this.lblOrganizations = new System.Windows.Forms.Label();
            this.btnAddAnotherOrganization = new System.Windows.Forms.Button();
            this.lblPleaseListOrganizations = new System.Windows.Forms.Label();
            this.txtOrganizationEntry = new System.Windows.Forms.TextBox();
            this.flpOrganizationBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.flpOrganizationsTextHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveOrganization = new System.Windows.Forms.Button();
            this.flpOrganizationBlock.SuspendLayout();
            this.flpOrganizationsTextHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrganizations
            // 
            this.lblOrganizations.AutoSize = true;
            this.lblOrganizations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizations.Location = new System.Drawing.Point(3, 0);
            this.lblOrganizations.Name = "lblOrganizations";
            this.lblOrganizations.Size = new System.Drawing.Size(133, 25);
            this.lblOrganizations.TabIndex = 0;
            this.lblOrganizations.Text = "Organizations";
            // 
            // btnAddAnotherOrganization
            // 
            this.btnAddAnotherOrganization.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAnotherOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherOrganization.Location = new System.Drawing.Point(125, 137);
            this.btnAddAnotherOrganization.Name = "btnAddAnotherOrganization";
            this.btnAddAnotherOrganization.Size = new System.Drawing.Size(256, 32);
            this.btnAddAnotherOrganization.TabIndex = 2;
            this.btnAddAnotherOrganization.Text = "Add Another Organization";
            this.btnAddAnotherOrganization.UseVisualStyleBackColor = true;
            this.btnAddAnotherOrganization.Click += new System.EventHandler(this.btnAddAnotherOrganization_Click);
            // 
            // lblPleaseListOrganizations
            // 
            this.lblPleaseListOrganizations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseListOrganizations.Location = new System.Drawing.Point(3, 25);
            this.lblPleaseListOrganizations.Name = "lblPleaseListOrganizations";
            this.lblPleaseListOrganizations.Size = new System.Drawing.Size(500, 76);
            this.lblPleaseListOrganizations.TabIndex = 1;
            this.lblPleaseListOrganizations.Text = "Please list any relevant Organizations or Commodity Boards you may be a part of, " +
    "(for example: The Coffee Growers Association). If you are not a part of any orga" +
    "nization, leave this field blank";
            // 
            // txtOrganizationEntry
            // 
            this.txtOrganizationEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationEntry.Location = new System.Drawing.Point(0, 0);
            this.txtOrganizationEntry.Margin = new System.Windows.Forms.Padding(0);
            this.txtOrganizationEntry.MaxLength = 150;
            this.txtOrganizationEntry.Name = "txtOrganizationEntry";
            this.txtOrganizationEntry.Size = new System.Drawing.Size(400, 27);
            this.txtOrganizationEntry.TabIndex = 3;
            // 
            // flpOrganizationBlock
            // 
            this.flpOrganizationBlock.AutoSize = true;
            this.flpOrganizationBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpOrganizationBlock.BackColor = System.Drawing.Color.Transparent;
            this.flpOrganizationBlock.Controls.Add(this.lblOrganizations);
            this.flpOrganizationBlock.Controls.Add(this.lblPleaseListOrganizations);
            this.flpOrganizationBlock.Controls.Add(this.flpOrganizationsTextHolder);
            this.flpOrganizationBlock.Controls.Add(this.btnAddAnotherOrganization);
            this.flpOrganizationBlock.Controls.Add(this.btnRemoveOrganization);
            this.flpOrganizationBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOrganizationBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpOrganizationBlock.Location = new System.Drawing.Point(0, 0);
            this.flpOrganizationBlock.Margin = new System.Windows.Forms.Padding(0);
            this.flpOrganizationBlock.Name = "flpOrganizationBlock";
            this.flpOrganizationBlock.Size = new System.Drawing.Size(506, 210);
            this.flpOrganizationBlock.TabIndex = 1;
            // 
            // flpOrganizationsTextHolder
            // 
            this.flpOrganizationsTextHolder.AutoSize = true;
            this.flpOrganizationsTextHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpOrganizationsTextHolder.Controls.Add(this.txtOrganizationEntry);
            this.flpOrganizationsTextHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOrganizationsTextHolder.Location = new System.Drawing.Point(3, 104);
            this.flpOrganizationsTextHolder.Name = "flpOrganizationsTextHolder";
            this.flpOrganizationsTextHolder.Size = new System.Drawing.Size(400, 27);
            this.flpOrganizationsTextHolder.TabIndex = 0;
            // 
            // btnRemoveOrganization
            // 
            this.btnRemoveOrganization.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrganization.Location = new System.Drawing.Point(125, 175);
            this.btnRemoveOrganization.Name = "btnRemoveOrganization";
            this.btnRemoveOrganization.Size = new System.Drawing.Size(256, 32);
            this.btnRemoveOrganization.TabIndex = 3;
            this.btnRemoveOrganization.Text = "Remove Last Organization";
            this.btnRemoveOrganization.UseVisualStyleBackColor = true;
            this.btnRemoveOrganization.Visible = false;
            this.btnRemoveOrganization.Click += new System.EventHandler(this.btnRemoveOrganization_Click);
            // 
            // usrOrganizationsBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpOrganizationBlock);
            this.Name = "usrOrganizationsBlock";
            this.Size = new System.Drawing.Size(506, 210);
            this.flpOrganizationBlock.ResumeLayout(false);
            this.flpOrganizationBlock.PerformLayout();
            this.flpOrganizationsTextHolder.ResumeLayout(false);
            this.flpOrganizationsTextHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeFilledComponent()
        {
            this.lblOrganizations = new System.Windows.Forms.Label();
            this.btnAddAnotherOrganization = new System.Windows.Forms.Button();
            this.lblPleaseListOrganizations = new System.Windows.Forms.Label();
            this.flpOrganizationBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.flpOrganizationsTextHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveOrganization = new System.Windows.Forms.Button();
            this.flpOrganizationBlock.SuspendLayout();
            this.flpOrganizationsTextHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrganizations
            // 
            this.lblOrganizations.AutoSize = true;
            this.lblOrganizations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizations.Location = new System.Drawing.Point(3, 0);
            this.lblOrganizations.Name = "lblOrganizations";
            this.lblOrganizations.Size = new System.Drawing.Size(133, 25);
            this.lblOrganizations.TabIndex = 0;
            this.lblOrganizations.Text = "Organizations";
            // 
            // btnAddAnotherOrganization
            // 
            this.btnAddAnotherOrganization.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAnotherOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherOrganization.Location = new System.Drawing.Point(125, 143);
            this.btnAddAnotherOrganization.Name = "btnAddAnotherOrganization";
            this.btnAddAnotherOrganization.Size = new System.Drawing.Size(256, 32);
            this.btnAddAnotherOrganization.TabIndex = 2;
            this.btnAddAnotherOrganization.Text = "Add Another Organization";
            this.btnAddAnotherOrganization.UseVisualStyleBackColor = true;
            this.btnAddAnotherOrganization.Click += new System.EventHandler(this.btnAddAnotherOrganization_Click);
            // 
            // lblPleaseListOrganizations
            // 
            this.lblPleaseListOrganizations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseListOrganizations.Location = new System.Drawing.Point(3, 25);
            this.lblPleaseListOrganizations.Name = "lblPleaseListOrganizations";
            this.lblPleaseListOrganizations.Size = new System.Drawing.Size(500, 76);
            this.lblPleaseListOrganizations.TabIndex = 1;
            this.lblPleaseListOrganizations.Text = "Please list any relevant Organizations or Commodity Boards you may be a part of, " +
    "(for example: The Coffee Growers Association). If you are not a part of any orga" +
    "nization, leave this field blank";
            // 
            // flwOrganizationBlock
            // 
            this.flpOrganizationBlock.AutoSize = true;
            this.flpOrganizationBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpOrganizationBlock.BackColor = System.Drawing.Color.Transparent;
            this.flpOrganizationBlock.Controls.Add(this.lblOrganizations);
            this.flpOrganizationBlock.Controls.Add(this.lblPleaseListOrganizations);
            this.flpOrganizationBlock.Controls.Add(this.flpOrganizationsTextHolder);
            this.flpOrganizationBlock.Controls.Add(this.btnAddAnotherOrganization);
            this.flpOrganizationBlock.Controls.Add(this.btnRemoveOrganization);
            this.flpOrganizationBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOrganizationBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpOrganizationBlock.Location = new System.Drawing.Point(0, 0);
            this.flpOrganizationBlock.Margin = new System.Windows.Forms.Padding(0);
            this.flpOrganizationBlock.Name = "flwOrganizationBlock";
            this.flpOrganizationBlock.Size = new System.Drawing.Size(506, 216);
            this.flpOrganizationBlock.TabIndex = 1;
            // 
            // flwOrganizationsTextHolder
            // 
            this.flpOrganizationsTextHolder.AutoSize = true;
            this.flpOrganizationsTextHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpOrganizationsTextHolder.Controls.Add(this.txtOrganizationEntry);
            this.flpOrganizationsTextHolder.Location = new System.Drawing.Point(3, 104);
            this.flpOrganizationsTextHolder.Name = "flwOrganizationsTextHolder";
            this.flpOrganizationsTextHolder.Size = new System.Drawing.Size(181, 33);
            this.flpOrganizationsTextHolder.TabIndex = 0;
            // 
            // btnRemoveOrganization
            // 
            this.btnRemoveOrganization.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrganization.Location = new System.Drawing.Point(125, 181);
            this.btnRemoveOrganization.Name = "btnRemoveOrganization";
            this.btnRemoveOrganization.Size = new System.Drawing.Size(256, 32);
            this.btnRemoveOrganization.TabIndex = 3;
            this.btnRemoveOrganization.Text = "Remove Last Organization";
            this.btnRemoveOrganization.UseVisualStyleBackColor = true;
            this.btnRemoveOrganization.Visible = false;
            this.btnRemoveOrganization.Click += new System.EventHandler(this.btnRemoveOrganization_Click);
            // 
            // usrOrganizationsBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpOrganizationBlock);
            this.Name = "usrOrganizationsBlock";
            this.Size = new System.Drawing.Size(506, 216);
            this.flpOrganizationBlock.ResumeLayout(false);
            this.flpOrganizationBlock.PerformLayout();
            this.flpOrganizationsTextHolder.ResumeLayout(false);
            this.flpOrganizationsTextHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblOrganizations;
        private System.Windows.Forms.Label lblPleaseListOrganizations;
        private System.Windows.Forms.Button btnAddAnotherOrganization;
        private System.Windows.Forms.TextBox txtOrganizationEntry;
        private System.Windows.Forms.FlowLayoutPanel flpOrganizationBlock;
        private System.Windows.Forms.FlowLayoutPanel flpOrganizationsTextHolder;
        private System.Windows.Forms.Button btnRemoveOrganization;
    }
}

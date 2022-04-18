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
            this.flwOrganizationBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.flwOrganizationsTextHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveOrganization = new System.Windows.Forms.Button();
            this.flwOrganizationBlock.SuspendLayout();
            this.flwOrganizationsTextHolder.SuspendLayout();
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
            this.txtOrganizationEntry.Name = "txtOrganizationEntry";
            this.txtOrganizationEntry.Size = new System.Drawing.Size(400, 27);
            this.txtOrganizationEntry.TabIndex = 3;
            // 
            // flwOrganizationBlock
            // 
            this.flwOrganizationBlock.AutoSize = true;
            this.flwOrganizationBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwOrganizationBlock.BackColor = System.Drawing.Color.Transparent;
            this.flwOrganizationBlock.Controls.Add(this.lblOrganizations);
            this.flwOrganizationBlock.Controls.Add(this.lblPleaseListOrganizations);
            this.flwOrganizationBlock.Controls.Add(this.flwOrganizationsTextHolder);
            this.flwOrganizationBlock.Controls.Add(this.btnAddAnotherOrganization);
            this.flwOrganizationBlock.Controls.Add(this.btnRemoveOrganization);
            this.flwOrganizationBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwOrganizationBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flwOrganizationBlock.Location = new System.Drawing.Point(0, 0);
            this.flwOrganizationBlock.Margin = new System.Windows.Forms.Padding(0);
            this.flwOrganizationBlock.Name = "flwOrganizationBlock";
            this.flwOrganizationBlock.Size = new System.Drawing.Size(506, 210);
            this.flwOrganizationBlock.TabIndex = 1;
            // 
            // flwOrganizationsTextHolder
            // 
            this.flwOrganizationsTextHolder.AutoSize = true;
            this.flwOrganizationsTextHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwOrganizationsTextHolder.Controls.Add(this.txtOrganizationEntry);
            this.flwOrganizationsTextHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwOrganizationsTextHolder.Location = new System.Drawing.Point(3, 104);
            this.flwOrganizationsTextHolder.Name = "flwOrganizationsTextHolder";
            this.flwOrganizationsTextHolder.Size = new System.Drawing.Size(400, 27);
            this.flwOrganizationsTextHolder.TabIndex = 0;
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
            this.Controls.Add(this.flwOrganizationBlock);
            this.Name = "usrOrganizationsBlock";
            this.Size = new System.Drawing.Size(506, 210);
            this.flwOrganizationBlock.ResumeLayout(false);
            this.flwOrganizationBlock.PerformLayout();
            this.flwOrganizationsTextHolder.ResumeLayout(false);
            this.flwOrganizationsTextHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeFilledComponent()
        {
            this.lblOrganizations = new System.Windows.Forms.Label();
            this.btnAddAnotherOrganization = new System.Windows.Forms.Button();
            this.lblPleaseListOrganizations = new System.Windows.Forms.Label();
            this.flwOrganizationBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.flwOrganizationsTextHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveOrganization = new System.Windows.Forms.Button();
            this.flwOrganizationBlock.SuspendLayout();
            this.flwOrganizationsTextHolder.SuspendLayout();
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
            this.flwOrganizationBlock.AutoSize = true;
            this.flwOrganizationBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwOrganizationBlock.BackColor = System.Drawing.Color.Transparent;
            this.flwOrganizationBlock.Controls.Add(this.lblOrganizations);
            this.flwOrganizationBlock.Controls.Add(this.lblPleaseListOrganizations);
            this.flwOrganizationBlock.Controls.Add(this.flwOrganizationsTextHolder);
            this.flwOrganizationBlock.Controls.Add(this.btnAddAnotherOrganization);
            this.flwOrganizationBlock.Controls.Add(this.btnRemoveOrganization);
            this.flwOrganizationBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwOrganizationBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flwOrganizationBlock.Location = new System.Drawing.Point(0, 0);
            this.flwOrganizationBlock.Margin = new System.Windows.Forms.Padding(0);
            this.flwOrganizationBlock.Name = "flwOrganizationBlock";
            this.flwOrganizationBlock.Size = new System.Drawing.Size(506, 216);
            this.flwOrganizationBlock.TabIndex = 1;
            // 
            // flwOrganizationsTextHolder
            // 
            this.flwOrganizationsTextHolder.AutoSize = true;
            this.flwOrganizationsTextHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwOrganizationsTextHolder.Controls.Add(this.txtOrganizationEntry);
            this.flwOrganizationsTextHolder.Location = new System.Drawing.Point(3, 104);
            this.flwOrganizationsTextHolder.Name = "flwOrganizationsTextHolder";
            this.flwOrganizationsTextHolder.Size = new System.Drawing.Size(181, 33);
            this.flwOrganizationsTextHolder.TabIndex = 0;
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
            this.Controls.Add(this.flwOrganizationBlock);
            this.Name = "usrOrganizationsBlock";
            this.Size = new System.Drawing.Size(506, 216);
            this.flwOrganizationBlock.ResumeLayout(false);
            this.flwOrganizationBlock.PerformLayout();
            this.flwOrganizationsTextHolder.ResumeLayout(false);
            this.flwOrganizationsTextHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblOrganizations;
        private System.Windows.Forms.Label lblPleaseListOrganizations;
        private System.Windows.Forms.Button btnAddAnotherOrganization;
        private System.Windows.Forms.TextBox txtOrganizationEntry;
        private System.Windows.Forms.FlowLayoutPanel flwOrganizationBlock;
        private System.Windows.Forms.FlowLayoutPanel flwOrganizationsTextHolder;
        private System.Windows.Forms.Button btnRemoveOrganization;
    }
}

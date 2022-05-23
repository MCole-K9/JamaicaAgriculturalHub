namespace JAHub_Winforms.Grant_Controls
{
    partial class ucGrantDisplay
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
            this.pnlGrantContainer = new System.Windows.Forms.Panel();
            this.txtUcAgencyName = new System.Windows.Forms.TextBox();
            this.rtbGrantDescription = new System.Windows.Forms.RichTextBox();
            this.btnViewGrant = new System.Windows.Forms.Button();
            this.pnlGrantContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrantContainer
            // 
            this.pnlGrantContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGrantContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrantContainer.Controls.Add(this.txtUcAgencyName);
            this.pnlGrantContainer.Controls.Add(this.rtbGrantDescription);
            this.pnlGrantContainer.Controls.Add(this.btnViewGrant);
            this.pnlGrantContainer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGrantContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlGrantContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGrantContainer.Name = "pnlGrantContainer";
            this.pnlGrantContainer.Size = new System.Drawing.Size(738, 247);
            this.pnlGrantContainer.TabIndex = 48;
            // 
            // txtUcAgencyName
            // 
            this.txtUcAgencyName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUcAgencyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUcAgencyName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUcAgencyName.Location = new System.Drawing.Point(11, 9);
            this.txtUcAgencyName.Name = "txtUcAgencyName";
            this.txtUcAgencyName.Size = new System.Drawing.Size(174, 37);
            this.txtUcAgencyName.TabIndex = 53;
            // 
            // rtbGrantDescription
            // 
            this.rtbGrantDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbGrantDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbGrantDescription.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGrantDescription.Location = new System.Drawing.Point(11, 87);
            this.rtbGrantDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtbGrantDescription.Name = "rtbGrantDescription";
            this.rtbGrantDescription.ReadOnly = true;
            this.rtbGrantDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbGrantDescription.Size = new System.Drawing.Size(709, 116);
            this.rtbGrantDescription.TabIndex = 51;
            this.rtbGrantDescription.Text = "";
            // 
            // btnViewGrant
            // 
            this.btnViewGrant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGrant.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGrant.Location = new System.Drawing.Point(600, 18);
            this.btnViewGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewGrant.Name = "btnViewGrant";
            this.btnViewGrant.Size = new System.Drawing.Size(120, 45);
            this.btnViewGrant.TabIndex = 48;
            this.btnViewGrant.Text = "View more";
            this.btnViewGrant.UseVisualStyleBackColor = true;
            this.btnViewGrant.Click += new System.EventHandler(this.btnViewGrant_Click);
            // 
            // ucGrantDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlGrantContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucGrantDisplay";
            this.Size = new System.Drawing.Size(742, 251);
            this.pnlGrantContainer.ResumeLayout(false);
            this.pnlGrantContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlGrantContainer;
        private System.Windows.Forms.Button btnViewGrant;
        private System.Windows.Forms.RichTextBox rtbGrantDescription;
        private System.Windows.Forms.TextBox txtUcAgencyName;
    }
}

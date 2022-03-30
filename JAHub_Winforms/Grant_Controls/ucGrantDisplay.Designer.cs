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
            this.lblGrantAgency = new System.Windows.Forms.Label();
            this.rtbGrantDescription = new System.Windows.Forms.RichTextBox();
            this.btnViewGrant = new System.Windows.Forms.Button();
            this.pnlGrantContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrantContainer
            // 
            this.pnlGrantContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGrantContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrantContainer.Controls.Add(this.lblGrantAgency);
            this.pnlGrantContainer.Controls.Add(this.rtbGrantDescription);
            this.pnlGrantContainer.Controls.Add(this.btnViewGrant);
            this.pnlGrantContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlGrantContainer.Name = "pnlGrantContainer";
            this.pnlGrantContainer.Size = new System.Drawing.Size(554, 112);
            this.pnlGrantContainer.TabIndex = 48;
            // 
            // lblGrantAgency
            // 
            this.lblGrantAgency.AutoSize = true;
            this.lblGrantAgency.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrantAgency.Location = new System.Drawing.Point(14, 15);
            this.lblGrantAgency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrantAgency.Name = "lblGrantAgency";
            this.lblGrantAgency.Size = new System.Drawing.Size(120, 21);
            this.lblGrantAgency.TabIndex = 52;
            this.lblGrantAgency.Text = "Grant Agency";
            // 
            // rtbGrantDescription
            // 
            this.rtbGrantDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbGrantDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbGrantDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGrantDescription.Location = new System.Drawing.Point(18, 47);
            this.rtbGrantDescription.Name = "rtbGrantDescription";
            this.rtbGrantDescription.ReadOnly = true;
            this.rtbGrantDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbGrantDescription.Size = new System.Drawing.Size(522, 52);
            this.rtbGrantDescription.TabIndex = 51;
            this.rtbGrantDescription.Text = "";
            // 
            // btnViewGrant
            // 
            this.btnViewGrant.Location = new System.Drawing.Point(465, 15);
            this.btnViewGrant.Name = "btnViewGrant";
            this.btnViewGrant.Size = new System.Drawing.Size(75, 23);
            this.btnViewGrant.TabIndex = 48;
            this.btnViewGrant.Text = "View more";
            this.btnViewGrant.UseVisualStyleBackColor = true;
            this.btnViewGrant.Click += new System.EventHandler(this.btnViewGrant_Click);
            // 
            // ucGrantDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlGrantContainer);
            this.Name = "ucGrantDisplay";
            this.Size = new System.Drawing.Size(553, 121);
            this.pnlGrantContainer.ResumeLayout(false);
            this.pnlGrantContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlGrantContainer;
        private System.Windows.Forms.Button btnViewGrant;
        private System.Windows.Forms.RichTextBox rtbGrantDescription;
        private System.Windows.Forms.Label lblGrantAgency;
    }
}

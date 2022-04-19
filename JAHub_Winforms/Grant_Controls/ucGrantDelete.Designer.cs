namespace JAHub_Winforms.Grant_Controls
{
    partial class ucGrantDelete
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
            this.btnViewGrant = new System.Windows.Forms.Button();
            this.rtbGrantDescription = new System.Windows.Forms.RichTextBox();
            this.lblGrantAgency = new System.Windows.Forms.Label();
            this.pnlGrantDeleteContainer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlGrantDeleteContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewGrant
            // 
            this.btnViewGrant.Location = new System.Drawing.Point(620, 18);
            this.btnViewGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewGrant.Name = "btnViewGrant";
            this.btnViewGrant.Size = new System.Drawing.Size(100, 28);
            this.btnViewGrant.TabIndex = 48;
            this.btnViewGrant.Text = "View more";
            this.btnViewGrant.UseVisualStyleBackColor = true;
            // 
            // rtbGrantDescription
            // 
            this.rtbGrantDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbGrantDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbGrantDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGrantDescription.Location = new System.Drawing.Point(24, 58);
            this.rtbGrantDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtbGrantDescription.Name = "rtbGrantDescription";
            this.rtbGrantDescription.ReadOnly = true;
            this.rtbGrantDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbGrantDescription.Size = new System.Drawing.Size(696, 64);
            this.rtbGrantDescription.TabIndex = 51;
            this.rtbGrantDescription.Text = "";
            // 
            // lblGrantAgency
            // 
            this.lblGrantAgency.AutoSize = true;
            this.lblGrantAgency.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrantAgency.Location = new System.Drawing.Point(19, 18);
            this.lblGrantAgency.Name = "lblGrantAgency";
            this.lblGrantAgency.Size = new System.Drawing.Size(148, 23);
            this.lblGrantAgency.TabIndex = 52;
            this.lblGrantAgency.Text = "Grant Agency";
            // 
            // pnlGrantDeleteContainer
            // 
            this.pnlGrantDeleteContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGrantDeleteContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrantDeleteContainer.Controls.Add(this.button1);
            this.pnlGrantDeleteContainer.Controls.Add(this.lblGrantAgency);
            this.pnlGrantDeleteContainer.Controls.Add(this.rtbGrantDescription);
            this.pnlGrantDeleteContainer.Controls.Add(this.btnViewGrant);
            this.pnlGrantDeleteContainer.Location = new System.Drawing.Point(0, 7);
            this.pnlGrantDeleteContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGrantDeleteContainer.Name = "pnlGrantDeleteContainer";
            this.pnlGrantDeleteContainer.Size = new System.Drawing.Size(1058, 137);
            this.pnlGrantDeleteContainer.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(727, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucGrantDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrantDeleteContainer);
            this.Name = "ucGrantDelete";
            this.Size = new System.Drawing.Size(1058, 150);
            this.pnlGrantDeleteContainer.ResumeLayout(false);
            this.pnlGrantDeleteContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewGrant;
        private System.Windows.Forms.RichTextBox rtbGrantDescription;
        private System.Windows.Forms.Label lblGrantAgency;
        private System.Windows.Forms.Panel pnlGrantDeleteContainer;
        private System.Windows.Forms.Button button1;
    }
}

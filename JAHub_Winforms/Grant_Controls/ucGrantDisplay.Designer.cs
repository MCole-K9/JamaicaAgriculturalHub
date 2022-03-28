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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewGrant = new System.Windows.Forms.Button();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.rtbGrantDescription = new System.Windows.Forms.RichTextBox();
            this.lblGrantAgency = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblGrantAgency);
            this.panel1.Controls.Add(this.rtbGrantDescription);
            this.panel1.Controls.Add(this.txtExpirationDate);
            this.panel1.Controls.Add(this.lblExpirationDate);
            this.panel1.Controls.Add(this.btnViewGrant);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 152);
            this.panel1.TabIndex = 48;
            // 
            // btnViewGrant
            // 
            this.btnViewGrant.Location = new System.Drawing.Point(465, 15);
            this.btnViewGrant.Name = "btnViewGrant";
            this.btnViewGrant.Size = new System.Drawing.Size(75, 23);
            this.btnViewGrant.TabIndex = 48;
            this.btnViewGrant.Text = "View more";
            this.btnViewGrant.UseVisualStyleBackColor = true;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(15, 125);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(108, 16);
            this.lblExpirationDate.TabIndex = 49;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpirationDate.Location = new System.Drawing.Point(359, 128);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(181, 13);
            this.txtExpirationDate.TabIndex = 50;
            // 
            // rtbGrantDescription
            // 
            this.rtbGrantDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbGrantDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbGrantDescription.Location = new System.Drawing.Point(18, 47);
            this.rtbGrantDescription.Name = "rtbGrantDescription";
            this.rtbGrantDescription.Size = new System.Drawing.Size(522, 68);
            this.rtbGrantDescription.TabIndex = 51;
            this.rtbGrantDescription.Text = "";
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
            // GrantDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "GrantDisplay";
            this.Size = new System.Drawing.Size(560, 167);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewGrant;
        private System.Windows.Forms.RichTextBox rtbGrantDescription;
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblGrantAgency;
    }
}

namespace JAHub_Winforms
{
    partial class FrmViewAllMyApplication
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
            this.pnlContainerAdminViewGrants = new System.Windows.Forms.Panel();
            this.lblAgency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlContainerAdminViewGrants
            // 
            this.pnlContainerAdminViewGrants.AutoScroll = true;
            this.pnlContainerAdminViewGrants.AutoSize = true;
            this.pnlContainerAdminViewGrants.Location = new System.Drawing.Point(27, 112);
            this.pnlContainerAdminViewGrants.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainerAdminViewGrants.Name = "pnlContainerAdminViewGrants";
            this.pnlContainerAdminViewGrants.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.pnlContainerAdminViewGrants.Size = new System.Drawing.Size(1033, 710);
            this.pnlContainerAdminViewGrants.TabIndex = 66;
            // 
            // lblAgency
            // 
            this.lblAgency.AutoSize = true;
            this.lblAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgency.Location = new System.Drawing.Point(21, 48);
            this.lblAgency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.Size = new System.Drawing.Size(189, 31);
            this.lblAgency.TabIndex = 65;
            this.lblAgency.Text = "All My Grants";
            // 
            // FrmViewAllMyApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 822);
            this.Controls.Add(this.pnlContainerAdminViewGrants);
            this.Controls.Add(this.lblAgency);
            this.Name = "FrmViewAllMyApplication";
            this.Text = "FrmViewAllMyApplication";
            this.Load += new System.EventHandler(this.FrmViewAllMyApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainerAdminViewGrants;
        private System.Windows.Forms.Label lblAgency;
    }
}
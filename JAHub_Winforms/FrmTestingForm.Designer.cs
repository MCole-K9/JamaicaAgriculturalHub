﻿namespace JAHub_Winforms
{
    partial class FrmTestingForm
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
            this.lblFarmerID = new System.Windows.Forms.Label();
            this.lblBusinessEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFarmerID
            // 
            this.lblFarmerID.AutoSize = true;
            this.lblFarmerID.Location = new System.Drawing.Point(111, 53);
            this.lblFarmerID.Name = "lblFarmerID";
            this.lblFarmerID.Size = new System.Drawing.Size(0, 13);
            this.lblFarmerID.TabIndex = 0;
            // 
            // lblBusinessEmail
            // 
            this.lblBusinessEmail.AutoSize = true;
            this.lblBusinessEmail.Location = new System.Drawing.Point(111, 97);
            this.lblBusinessEmail.Name = "lblBusinessEmail";
            this.lblBusinessEmail.Size = new System.Drawing.Size(0, 13);
            this.lblBusinessEmail.TabIndex = 0;
            // 
            // FrmTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBusinessEmail);
            this.Controls.Add(this.lblFarmerID);
            this.Name = "FrmTestingForm";
            this.Text = "FrmTestingForm";
            this.Load += new System.EventHandler(this.FrmTestingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFarmerID;
        private System.Windows.Forms.Label lblBusinessEmail;
    }
}
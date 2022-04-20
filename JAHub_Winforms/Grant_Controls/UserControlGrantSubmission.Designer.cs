namespace JAHub_Winforms.Grant_Controls
{
    partial class UserControlGrantSubmission
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblfilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(82, 98);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(96, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download ";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.Location = new System.Drawing.Point(101, 59);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(58, 16);
            this.lblfilename.TabIndex = 3;
            this.lblfilename.Text = "filename";
            // 
            // UserControlGrantSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblfilename);
            this.Controls.Add(this.btnDownload);
            this.Name = "UserControlGrantSubmission";
            this.Size = new System.Drawing.Size(291, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblfilename;
    }
}

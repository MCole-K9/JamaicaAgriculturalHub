namespace JAHub_Winforms
{
    partial class FrmRadaViewRegistration
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
            this.flpRadaViewRegistration = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpRadaViewRegistration
            // 
            this.flpRadaViewRegistration.AutoScroll = true;
            this.flpRadaViewRegistration.AutoSize = true;
            this.flpRadaViewRegistration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpRadaViewRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRadaViewRegistration.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRadaViewRegistration.Location = new System.Drawing.Point(0, 0);
            this.flpRadaViewRegistration.Margin = new System.Windows.Forms.Padding(0);
            this.flpRadaViewRegistration.Name = "flpRadaViewRegistration";
            this.flpRadaViewRegistration.Size = new System.Drawing.Size(630, 753);
            this.flpRadaViewRegistration.TabIndex = 0;
            this.flpRadaViewRegistration.WrapContents = false;
            // 
            // FrmRadaViewRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(630, 753);
            this.Controls.Add(this.flpRadaViewRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmRadaViewRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Information";
            this.Load += new System.EventHandler(this.FrmRadaViewRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRadaViewRegistration;
    }
}
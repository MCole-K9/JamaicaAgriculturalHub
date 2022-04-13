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
            this.flwRadaViewRegistration = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flwRadaViewRegistration
            // 
            this.flwRadaViewRegistration.AutoScroll = true;
            this.flwRadaViewRegistration.AutoSize = true;
            this.flwRadaViewRegistration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwRadaViewRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwRadaViewRegistration.Enabled = false;
            this.flwRadaViewRegistration.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwRadaViewRegistration.Location = new System.Drawing.Point(0, 0);
            this.flwRadaViewRegistration.Margin = new System.Windows.Forms.Padding(0);
            this.flwRadaViewRegistration.Name = "flwRadaViewRegistration";
            this.flwRadaViewRegistration.Size = new System.Drawing.Size(630, 450);
            this.flwRadaViewRegistration.TabIndex = 0;
            this.flwRadaViewRegistration.WrapContents = false;
            // 
            // FrmRadaViewRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.flwRadaViewRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmRadaViewRegistration";
            this.Text = "FrmRadaViewRegistration";
            this.Load += new System.EventHandler(this.FrmRadaViewRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwRadaViewRegistration;
    }
}
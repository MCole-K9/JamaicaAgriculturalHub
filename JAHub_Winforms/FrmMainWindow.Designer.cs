namespace JAHub_Winforms
{
    partial class FrmMainWindow
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
            this.components = new System.ComponentModel.Container();
            this.mnsMainForm = new System.Windows.Forms.MenuStrip();
            this.miHome = new System.Windows.Forms.ToolStripMenuItem();
            this.miShop = new System.Windows.Forms.ToolStripMenuItem();
            this.miBlog = new System.Windows.Forms.ToolStripMenuItem();
            this.grantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssrMainForm = new System.Windows.Forms.StatusStrip();
            this.lblLoggedInAs = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoggedInRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.icnJaHub = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnsMainForm.SuspendLayout();
            this.ssrMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMainForm
            // 
            this.mnsMainForm.Enabled = false;
            this.mnsMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHome,
            this.miShop,
            this.miBlog,
            this.grantsToolStripMenuItem,
            this.miUserProfile,
            this.miAdmin,
            this.miLogOut,
            this.exitToolStripMenuItem});
            this.mnsMainForm.Location = new System.Drawing.Point(0, 0);
            this.mnsMainForm.Name = "mnsMainForm";
            this.mnsMainForm.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnsMainForm.Size = new System.Drawing.Size(1067, 28);
            this.mnsMainForm.TabIndex = 1;
            this.mnsMainForm.Text = "menuStrip1";
            // 
            // miHome
            // 
            this.miHome.Name = "miHome";
            this.miHome.Size = new System.Drawing.Size(64, 24);
            this.miHome.Text = "Home";
            // 
            // miShop
            // 
            this.miShop.Name = "miShop";
            this.miShop.Size = new System.Drawing.Size(57, 24);
            this.miShop.Text = "Shop";
            this.miShop.Click += new System.EventHandler(this.shopToolStripMenuItem_Click);
            // 
            // miBlog
            // 
            this.miBlog.Name = "miBlog";
            this.miBlog.Size = new System.Drawing.Size(54, 24);
            this.miBlog.Text = "Blog";
            this.miBlog.Click += new System.EventHandler(this.blogToolStripMenuItem_Click);
            // 
            // grantsToolStripMenuItem
            // 
            this.grantsToolStripMenuItem.Name = "grantsToolStripMenuItem";
            this.grantsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.grantsToolStripMenuItem.Text = "Grants";
            this.grantsToolStripMenuItem.Click += new System.EventHandler(this.grantsToolStripMenuItem_Click);
            // 
            // miUserProfile
            // 
            this.miUserProfile.Name = "miUserProfile";
            this.miUserProfile.Size = new System.Drawing.Size(94, 24);
            this.miUserProfile.Text = "User Portal";
            this.miUserProfile.Click += new System.EventHandler(this.userPortalToolStripMenuItem_Click);
            // 
            // miAdmin
            // 
            this.miAdmin.Name = "miAdmin";
            this.miAdmin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.miAdmin.Size = new System.Drawing.Size(67, 24);
            this.miAdmin.Text = "Admin";
            this.miAdmin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // miLogOut
            // 
            this.miLogOut.Name = "miLogOut";
            this.miLogOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.miLogOut.Size = new System.Drawing.Size(70, 24);
            this.miLogOut.Text = "Logout";
            this.miLogOut.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ssrMainForm
            // 
            this.ssrMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssrMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoggedInAs,
            this.lblLoggedInRole});
            this.ssrMainForm.Location = new System.Drawing.Point(0, 528);
            this.ssrMainForm.Name = "ssrMainForm";
            this.ssrMainForm.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.ssrMainForm.Size = new System.Drawing.Size(1067, 26);
            this.ssrMainForm.TabIndex = 3;
            this.ssrMainForm.Text = "statusStrip1";
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(105, 20);
            this.lblLoggedInAs.Text = "Not Logged In";
            // 
            // lblLoggedInRole
            // 
            this.lblLoggedInRole.Name = "lblLoggedInRole";
            this.lblLoggedInRole.Size = new System.Drawing.Size(0, 20);
            // 
            // icnJaHub
            // 
            this.icnJaHub.Text = "JAHub";
            this.icnJaHub.Visible = true;
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ssrMainForm);
            this.Controls.Add(this.mnsMainForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMainForm;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMainWindow";
            this.Text = "Jamaica Agricultural Hub";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainWindow_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMainWindow_SizeChanged);
            this.mnsMainForm.ResumeLayout(false);
            this.mnsMainForm.PerformLayout();
            this.ssrMainForm.ResumeLayout(false);
            this.ssrMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMainForm;
        private System.Windows.Forms.ToolStripMenuItem miHome;
        private System.Windows.Forms.ToolStripMenuItem miShop;
        private System.Windows.Forms.ToolStripMenuItem miBlog;
        private System.Windows.Forms.ToolStripMenuItem miUserProfile;
        private System.Windows.Forms.ToolStripMenuItem miAdmin;
        private System.Windows.Forms.ToolStripMenuItem miLogOut;
        private System.Windows.Forms.StatusStrip ssrMainForm;
        private System.Windows.Forms.ToolStripStatusLabel lblLoggedInAs;
        private System.Windows.Forms.ToolStripStatusLabel lblLoggedInRole;
        private System.Windows.Forms.NotifyIcon icnJaHub;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantsToolStripMenuItem;
    }
}


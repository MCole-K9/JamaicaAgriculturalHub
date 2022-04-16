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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnMyBlogs = new FontAwesome.Sharp.IconButton();
            this.btnCreateBlog = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnBlogs = new FontAwesome.Sharp.IconButton();
            this.lblAgency = new System.Windows.Forms.Label();
            this.btntest = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.AutoSize = true;
            this.pnlContainer.Location = new System.Drawing.Point(295, 140);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.pnlContainer.Size = new System.Drawing.Size(765, 628);
            this.pnlContainer.TabIndex = 66;
            // 
            // btnMyBlogs
            // 
            this.btnMyBlogs.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMyBlogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyBlogs.FlatAppearance.BorderSize = 0;
            this.btnMyBlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBlogs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMyBlogs.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnMyBlogs.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMyBlogs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMyBlogs.IconSize = 30;
            this.btnMyBlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyBlogs.Location = new System.Drawing.Point(0, 267);
            this.btnMyBlogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyBlogs.Name = "btnMyBlogs";
            this.btnMyBlogs.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnMyBlogs.Size = new System.Drawing.Size(188, 58);
            this.btnMyBlogs.TabIndex = 4;
            this.btnMyBlogs.Text = "Exit";
            this.btnMyBlogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyBlogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyBlogs.UseVisualStyleBackColor = false;
            // 
            // btnCreateBlog
            // 
            this.btnCreateBlog.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreateBlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateBlog.FlatAppearance.BorderSize = 0;
            this.btnCreateBlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBlog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateBlog.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnCreateBlog.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateBlog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateBlog.IconSize = 30;
            this.btnCreateBlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBlog.Location = new System.Drawing.Point(0, 209);
            this.btnCreateBlog.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateBlog.Name = "btnCreateBlog";
            this.btnCreateBlog.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnCreateBlog.Size = new System.Drawing.Size(188, 58);
            this.btnCreateBlog.TabIndex = 3;
            this.btnCreateBlog.Text = "Apply";
            this.btnCreateBlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateBlog.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(188, 151);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlNav.Controls.Add(this.btnMyBlogs);
            this.pnlNav.Controls.Add(this.btnCreateBlog);
            this.pnlNav.Controls.Add(this.btnBlogs);
            this.pnlNav.Controls.Add(this.pnlLogo);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(188, 822);
            this.pnlNav.TabIndex = 67;
            // 
            // btnBlogs
            // 
            this.btnBlogs.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBlogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBlogs.FlatAppearance.BorderSize = 0;
            this.btnBlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlogs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBlogs.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnBlogs.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBlogs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBlogs.IconSize = 30;
            this.btnBlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlogs.Location = new System.Drawing.Point(0, 151);
            this.btnBlogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlogs.Name = "btnBlogs";
            this.btnBlogs.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnBlogs.Size = new System.Drawing.Size(188, 58);
            this.btnBlogs.TabIndex = 1;
            this.btnBlogs.Text = "Home";
            this.btnBlogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlogs.UseVisualStyleBackColor = false;
            // 
            // lblAgency
            // 
            this.lblAgency.AutoSize = true;
            this.lblAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgency.Location = new System.Drawing.Point(287, 26);
            this.lblAgency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.Size = new System.Drawing.Size(189, 31);
            this.lblAgency.TabIndex = 65;
            this.lblAgency.Text = "All My Grants";
            // 
            // btntest
            // 
            this.btnViewAllMyGrants.Location = new System.Drawing.Point(960, 32);
            this.btnViewAllMyGrants.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAllMyGrants.Name = "btnViewAllMyGrants";
            this.btnViewAllMyGrants.Size = new System.Drawing.Size(100, 28);
            this.btnViewAllMyGrants.TabIndex = 64;
            this.btnViewAllMyGrants.Text = "View";
             
            this.btntest.Location = new System.Drawing.Point(960, 32);
            this.btntest.Margin = new System.Windows.Forms.Padding(4);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(100, 28);
            this.btntest.TabIndex = 64;
            this.btntest.Text = "View";
            // 
            // FrmViewAllMyApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 822);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.lblAgency);
            this.Controls.Add(this.btntest);
            this.Name = "FrmViewAllMyApplication";
            this.Text = "FrmViewAllMyApplication";
            this.Load += new System.EventHandler(this.FrmViewAllMyApplication_Load);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private FontAwesome.Sharp.IconButton btnMyBlogs;
        private FontAwesome.Sharp.IconButton btnCreateBlog;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlNav;
        private FontAwesome.Sharp.IconButton btnBlogs;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.Button btntest;
    }
}
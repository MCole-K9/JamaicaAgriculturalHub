namespace JAHub_Winforms
{
    partial class FrmBlog
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblAgriblogTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearchBar = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.btnMyBlogs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(82, 653);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.Location = new System.Drawing.Point(951, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 33);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblAgriblogTitle
            // 
            this.lblAgriblogTitle.AutoSize = true;
            this.lblAgriblogTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgriblogTitle.Location = new System.Drawing.Point(169, 30);
            this.lblAgriblogTitle.Name = "lblAgriblogTitle";
            this.lblAgriblogTitle.Size = new System.Drawing.Size(286, 37);
            this.lblAgriblogTitle.TabIndex = 13;
            this.lblAgriblogTitle.Text = "Agricultural Blogs";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Location = new System.Drawing.Point(176, 186);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(900, 400);
            this.pnlContainer.TabIndex = 14;
            // 
            // comboSort
            // 
            this.comboSort.FormattingEnabled = true;
            this.comboSort.Items.AddRange(new object[] {
            "Latest",
            "Rating",
            "Oldest",
            "A-Z",
            "Z-A"});
            this.comboSort.Location = new System.Drawing.Point(935, 144);
            this.comboSort.Name = "comboSort";
            this.comboSort.Size = new System.Drawing.Size(121, 21);
            this.comboSort.TabIndex = 15;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(176, 145);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(161, 20);
            this.txtSearchBar.TabIndex = 16;
            // 
            // btnSearchBar
            // 
            this.btnSearchBar.Location = new System.Drawing.Point(343, 143);
            this.btnSearchBar.Name = "btnSearchBar";
            this.btnSearchBar.Size = new System.Drawing.Size(67, 23);
            this.btnSearchBar.TabIndex = 17;
            this.btnSearchBar.Text = "Search";
            this.btnSearchBar.UseVisualStyleBackColor = true;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(885, 146);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(44, 15);
            this.lblSortBy.TabIndex = 18;
            this.lblSortBy.Text = "Sort by";
            // 
            // btnMyBlogs
            // 
            this.btnMyBlogs.Location = new System.Drawing.Point(981, 69);
            this.btnMyBlogs.Name = "btnMyBlogs";
            this.btnMyBlogs.Size = new System.Drawing.Size(75, 22);
            this.btnMyBlogs.TabIndex = 19;
            this.btnMyBlogs.Text = "My Blogs";
            this.btnMyBlogs.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormBlog.Properties.Resources.outline_thumb_up_alt_black_24dp;
            this.pictureBox1.Location = new System.Drawing.Point(743, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMyBlogs);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.btnSearchBar);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.comboSort);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblAgriblogTitle);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBlog";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblAgriblogTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ComboBox comboSort;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnSearchBar;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Button btnMyBlogs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


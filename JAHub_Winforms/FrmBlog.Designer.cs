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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblAgriblogTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearchBar = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.btnMyBlogs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnCreateBlog = new FontAwesome.Sharp.IconButton();
            this.btnBlogs = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.pictureBox1.Image = global::JAHub_Winforms.Properties.Resources.outline_thumb_up_alt_black_24dp;
            this.pictureBox1.Location = new System.Drawing.Point(743, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlNav.Controls.Add(this.iconButton2);
            this.pnlNav.Controls.Add(this.btnCreateBlog);
            this.pnlNav.Controls.Add(this.btnBlogs);
            this.pnlNav.Controls.Add(this.pnlLogo);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(141, 653);
            this.pnlNav.TabIndex = 20;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconButton2.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 217);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.iconButton2.Size = new System.Drawing.Size(141, 47);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "My Blogs";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
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
            this.btnCreateBlog.Location = new System.Drawing.Point(0, 170);
            this.btnCreateBlog.Name = "btnCreateBlog";
            this.btnCreateBlog.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnCreateBlog.Size = new System.Drawing.Size(141, 47);
            this.btnCreateBlog.TabIndex = 3;
            this.btnCreateBlog.Text = "Create";
            this.btnCreateBlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateBlog.UseVisualStyleBackColor = false;
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
            this.btnBlogs.Location = new System.Drawing.Point(0, 123);
            this.btnBlogs.Name = "btnBlogs";
            this.btnBlogs.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnBlogs.Size = new System.Drawing.Size(141, 47);
            this.btnBlogs.TabIndex = 1;
            this.btnBlogs.Text = "Blogs";
            this.btnBlogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlogs.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(141, 123);
            this.pnlLogo.TabIndex = 0;
            // 
            // FrmBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 653);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMyBlogs);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.btnSearchBar);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.comboSort);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblAgriblogTitle);
            this.Controls.Add(this.btnCreate);
            this.Name = "FrmBlog";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblAgriblogTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ComboBox comboSort;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnSearchBar;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Button btnMyBlogs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNav;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnCreateBlog;
        private FontAwesome.Sharp.IconButton btnBlogs;
        private System.Windows.Forms.Panel pnlLogo;
    }
}


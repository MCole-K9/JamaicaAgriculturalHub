namespace JAHub_Winforms
{
    partial class FrmBlogDetails
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbBlogBody = new System.Windows.Forms.RichTextBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnCreateBlog = new FontAwesome.Sharp.IconButton();
            this.btnBlogs = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnRatingDown = new System.Windows.Forms.Button();
            this.btnRatingUp = new System.Windows.Forms.Button();
            this.lblUpOrDownVote = new System.Windows.Forms.Label();
            this.btnEditBlog = new System.Windows.Forms.Button();
            this.btnDeleteBlog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 42);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(15, 82);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(68, 19);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "John Doe";
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishDate.Location = new System.Drawing.Point(16, 101);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(66, 15);
            this.lblPublishDate.TabIndex = 5;
            this.lblPublishDate.Text = "26/2/2022";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblPublishDate);
            this.panel1.Controls.Add(this.lblAuthor);
            this.panel1.Location = new System.Drawing.Point(164, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 130);
            this.panel1.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 54);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Decription here";
            // 
            // rtbBlogBody
            // 
            this.rtbBlogBody.BackColor = System.Drawing.Color.White;
            this.rtbBlogBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbBlogBody.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbBlogBody.DetectUrls = false;
            this.rtbBlogBody.Enabled = false;
            this.rtbBlogBody.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBlogBody.Location = new System.Drawing.Point(164, 202);
            this.rtbBlogBody.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.rtbBlogBody.Name = "rtbBlogBody";
            this.rtbBlogBody.ReadOnly = true;
            this.rtbBlogBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbBlogBody.Size = new System.Drawing.Size(953, 338);
            this.rtbBlogBody.TabIndex = 7;
            this.rtbBlogBody.Text = "Body text";
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
            this.pnlNav.Size = new System.Drawing.Size(141, 604);
            this.pnlNav.TabIndex = 21;
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
            this.iconButton2.Click += new System.EventHandler(this.btnMyBlogs_Click);
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
            this.btnCreateBlog.Click += new System.EventHandler(this.btnCreateBlog_Click);
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
            this.btnBlogs.Click += new System.EventHandler(this.btnBlogs_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(141, 123);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnRatingDown
            // 
            this.btnRatingDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRatingDown.Image = global::JAHub_Winforms.Properties.Resources.outline_thumb_down_alt_black_24dp;
            this.btnRatingDown.Location = new System.Drawing.Point(1079, 550);
            this.btnRatingDown.Name = "btnRatingDown";
            this.btnRatingDown.Size = new System.Drawing.Size(38, 42);
            this.btnRatingDown.TabIndex = 9;
            this.btnRatingDown.UseVisualStyleBackColor = true;
            this.btnRatingDown.Click += new System.EventHandler(this.btnRatingDown_Click);
            // 
            // btnRatingUp
            // 
            this.btnRatingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRatingUp.Image = global::JAHub_Winforms.Properties.Resources.outline_thumb_up_alt_black_24dp;
            this.btnRatingUp.Location = new System.Drawing.Point(1035, 550);
            this.btnRatingUp.Name = "btnRatingUp";
            this.btnRatingUp.Size = new System.Drawing.Size(38, 42);
            this.btnRatingUp.TabIndex = 8;
            this.btnRatingUp.UseVisualStyleBackColor = false;
            this.btnRatingUp.Click += new System.EventHandler(this.btnRatingUp_Click);
            // 
            // lblUpOrDownVote
            // 
            this.lblUpOrDownVote.AutoSize = true;
            this.lblUpOrDownVote.Location = new System.Drawing.Point(917, 565);
            this.lblUpOrDownVote.Name = "lblUpOrDownVote";
            this.lblUpOrDownVote.Size = new System.Drawing.Size(102, 13);
            this.lblUpOrDownVote.TabIndex = 22;
            this.lblUpOrDownVote.Text = "Found This Helpful?";
            // 
            // btnEditBlog
            // 
            this.btnEditBlog.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEditBlog.Location = new System.Drawing.Point(184, 565);
            this.btnEditBlog.Name = "btnEditBlog";
            this.btnEditBlog.Size = new System.Drawing.Size(75, 23);
            this.btnEditBlog.TabIndex = 23;
            this.btnEditBlog.Text = "Edit";
            this.btnEditBlog.UseVisualStyleBackColor = false;
            this.btnEditBlog.Visible = false;
            this.btnEditBlog.Click += new System.EventHandler(this.btnEditBlog_Click);
            // 
            // btnDeleteBlog
            // 
            this.btnDeleteBlog.BackColor = System.Drawing.Color.Red;
            this.btnDeleteBlog.Location = new System.Drawing.Point(266, 564);
            this.btnDeleteBlog.Name = "btnDeleteBlog";
            this.btnDeleteBlog.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBlog.TabIndex = 24;
            this.btnDeleteBlog.Text = "Delete";
            this.btnDeleteBlog.UseVisualStyleBackColor = false;
            this.btnDeleteBlog.Visible = false;
            this.btnDeleteBlog.Click += new System.EventHandler(this.btnDeleteBlog_Click);
            // 
            // FrmBlogDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 604);
            this.Controls.Add(this.btnDeleteBlog);
            this.Controls.Add(this.btnEditBlog);
            this.Controls.Add(this.lblUpOrDownVote);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnRatingDown);
            this.Controls.Add(this.btnRatingUp);
            this.Controls.Add(this.rtbBlogBody);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBlogDetails";
            this.Text = "FrmBlogDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbBlogBody;
        private System.Windows.Forms.Button btnRatingUp;
        private System.Windows.Forms.Button btnRatingDown;
        private System.Windows.Forms.Panel pnlNav;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnCreateBlog;
        private FontAwesome.Sharp.IconButton btnBlogs;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblUpOrDownVote;
        private System.Windows.Forms.Button btnEditBlog;
        private System.Windows.Forms.Button btnDeleteBlog;
    }
}
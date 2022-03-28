namespace JAHub_Winforms.Blog_Controls
{
    partial class ucBlogPost
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
            this.lblBlogTitle = new System.Windows.Forms.Label();
            this.lblBlogAuthor = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.btnViewBlog = new System.Windows.Forms.Button();
            this.lblRatings = new System.Windows.Forms.Label();
            this.lblBlogDescription = new System.Windows.Forms.Label();
            this.pnlBlogContainer = new System.Windows.Forms.Panel();
            this.pnlBlogContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBlogTitle
            // 
            this.lblBlogTitle.AutoSize = true;
            this.lblBlogTitle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblBlogTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlogTitle.Location = new System.Drawing.Point(26, 18);
            this.lblBlogTitle.Name = "lblBlogTitle";
            this.lblBlogTitle.Size = new System.Drawing.Size(50, 26);
            this.lblBlogTitle.TabIndex = 0;
            this.lblBlogTitle.Text = "Title";
            // 
            // lblBlogAuthor
            // 
            this.lblBlogAuthor.AutoSize = true;
            this.lblBlogAuthor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblBlogAuthor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlogAuthor.Location = new System.Drawing.Point(28, 44);
            this.lblBlogAuthor.Name = "lblBlogAuthor";
            this.lblBlogAuthor.Size = new System.Drawing.Size(78, 15);
            this.lblBlogAuthor.TabIndex = 1;
            this.lblBlogAuthor.Text = "Author Name";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblDatePublished.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePublished.Location = new System.Drawing.Point(28, 64);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(67, 13);
            this.lblDatePublished.TabIndex = 2;
            this.lblDatePublished.Text = "MM/DD/YYYY";
            // 
            // btnViewBlog
            // 
            this.btnViewBlog.Location = new System.Drawing.Point(784, 22);
            this.btnViewBlog.Name = "btnViewBlog";
            this.btnViewBlog.Size = new System.Drawing.Size(75, 23);
            this.btnViewBlog.TabIndex = 4;
            this.btnViewBlog.Text = "View";
            this.btnViewBlog.UseVisualStyleBackColor = true;
            this.btnViewBlog.Click += new System.EventHandler(this.btnViewBlog_Click);
            // 
            // lblRatings
            // 
            this.lblRatings.AutoSize = true;
            this.lblRatings.Location = new System.Drawing.Point(727, 97);
            this.lblRatings.Name = "lblRatings";
            this.lblRatings.Size = new System.Drawing.Size(132, 13);
            this.lblRatings.TabIndex = 3;
            this.lblRatings.Text = "People Found This Helpful";
            // 
            // lblBlogDescription
            // 
            this.lblBlogDescription.AutoSize = true;
            this.lblBlogDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlogDescription.Location = new System.Drawing.Point(25, 96);
            this.lblBlogDescription.Name = "lblBlogDescription";
            this.lblBlogDescription.Size = new System.Drawing.Size(161, 14);
            this.lblBlogDescription.TabIndex = 5;
            this.lblBlogDescription.Text = "Short description of the blog";
            // 
            // pnlBlogContainer
            // 
            this.pnlBlogContainer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlBlogContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBlogContainer.Controls.Add(this.lblRatings);
            this.pnlBlogContainer.Controls.Add(this.btnViewBlog);
            this.pnlBlogContainer.Controls.Add(this.lblBlogDescription);
            this.pnlBlogContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlBlogContainer.Name = "pnlBlogContainer";
            this.pnlBlogContainer.Size = new System.Drawing.Size(880, 123);
            this.pnlBlogContainer.TabIndex = 6;
            // 
            // ucBlogPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblBlogAuthor);
            this.Controls.Add(this.lblBlogTitle);
            this.Controls.Add(this.pnlBlogContainer);
            this.Name = "ucBlogPost";
            this.Size = new System.Drawing.Size(880, 130);
            this.pnlBlogContainer.ResumeLayout(false);
            this.pnlBlogContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBlogTitle;
        private System.Windows.Forms.Label lblBlogAuthor;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Button btnViewBlog;
        private System.Windows.Forms.Label lblRatings;
        private System.Windows.Forms.Label lblBlogDescription;
        private System.Windows.Forms.Panel pnlBlogContainer;
    }
}

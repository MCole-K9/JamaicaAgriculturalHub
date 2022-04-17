namespace JAHub_Winforms
{
    partial class FrmGeneralGrantInfo
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnViewGrants = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnDeleteGrant = new FontAwesome.Sharp.IconButton();
            this.btnViewall = new FontAwesome.Sharp.IconButton();
            this.btncreatetesting = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnMyBlogs = new FontAwesome.Sharp.IconButton();
            this.btnCreateBlog = new FontAwesome.Sharp.IconButton();
            this.btnBlogs = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btncreatetesting = new FontAwesome.Sharp.IconButton();
            this.btnViewall = new FontAwesome.Sharp.IconButton();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Navy;
            this.richTextBox1.Location = new System.Drawing.Point(269, 59);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(549, 53);
            this.richTextBox1.TabIndex = 42;
            this.richTextBox1.Text = "Please click \'View more\' on available grants to see further information on grants" +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 61;
            this.label1.Text = "Available Grants";
           
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.AutoSize = true;
            this.pnlContainer.Location = new System.Drawing.Point(272, 140);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.pnlContainer.Size = new System.Drawing.Size(765, 628);
            this.pnlContainer.TabIndex = 62;
            // 
            // btnViewGrants
            // 
            this.btnViewGrants.Location = new System.Drawing.Point(937, 32);
            this.btnViewGrants.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewGrants.Name = "btnViewGrants";
            this.btnViewGrants.Size = new System.Drawing.Size(100, 28);
            this.btnViewGrants.TabIndex = 0;
            this.btnViewGrants.Text = "View";
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlNav.Controls.Add(this.btnViewall);
            this.pnlNav.Controls.Add(this.btncreatetesting);
            this.pnlNav.Controls.Add(this.btnMyBlogs);
            this.pnlNav.Controls.Add(this.btnCreateBlog);
            this.pnlNav.Controls.Add(this.btnBlogs);
            this.pnlNav.Controls.Add(this.pnlLogo);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(188, 822);
            this.pnlNav.TabIndex = 63;
           
            // 
            // btnDeleteGrant
            // 
            this.btnDeleteGrant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteGrant.FlatAppearance.BorderSize = 0;
            this.btnDeleteGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGrant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGrant.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnDeleteGrant.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGrant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteGrant.IconSize = 30;
            this.btnDeleteGrant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGrant.Location = new System.Drawing.Point(0, 441);
            this.btnDeleteGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGrant.Name = "btnDeleteGrant";
            this.btnDeleteGrant.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnDeleteGrant.Size = new System.Drawing.Size(188, 58);
            this.btnDeleteGrant.TabIndex = 7;
            this.btnDeleteGrant.Text = "Delete Grant";
            this.btnDeleteGrant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGrant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteGrant.UseVisualStyleBackColor = false;
            this.btnDeleteGrant.Click += new System.EventHandler(this.btnDeleteGrant_Click);
            // 
            // btnViewall
            // 
            this.btnViewall.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewall.FlatAppearance.BorderSize = 0;
            this.btnViewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewall.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnViewall.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewall.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewall.IconSize = 30;
            this.btnViewall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewall.Location = new System.Drawing.Point(0, 383);
            this.btnViewall.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewall.Name = "btnViewall";
            this.btnViewall.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnViewall.Size = new System.Drawing.Size(188, 58);
            this.btnViewall.TabIndex = 6;
            this.btnViewall.Text = "View All";
            this.btnViewall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewall.UseVisualStyleBackColor = false;
            this.btnViewall.Click += new System.EventHandler(this.btnViewall_Click);
            // 
            // btncreatetesting
            // 
            this.btncreatetesting.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btncreatetesting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncreatetesting.FlatAppearance.BorderSize = 0;
            this.btncreatetesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreatetesting.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncreatetesting.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btncreatetesting.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btncreatetesting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncreatetesting.IconSize = 30;
            this.btncreatetesting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreatetesting.Location = new System.Drawing.Point(0, 325);
            this.btncreatetesting.Margin = new System.Windows.Forms.Padding(4);
            this.btncreatetesting.Name = "btncreatetesting";
            this.btncreatetesting.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btncreatetesting.Size = new System.Drawing.Size(188, 58);
            this.btncreatetesting.TabIndex = 5;
            this.btncreatetesting.Text = "Create Grants";
            this.btncreatetesting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreatetesting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncreatetesting.UseVisualStyleBackColor = false;
            this.btncreatetesting.Click += new System.EventHandler(this.btncreatetesting_Click);
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
            this.btnBlogs.Click += new System.EventHandler(this.btnBlogs_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(188, 151);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // btncreatetesting
            // 
            this.btncreatetesting.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btncreatetesting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncreatetesting.FlatAppearance.BorderSize = 0;
            this.btncreatetesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreatetesting.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncreatetesting.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btncreatetesting.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btncreatetesting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncreatetesting.IconSize = 30;
            this.btncreatetesting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreatetesting.Location = new System.Drawing.Point(0, 325);
            this.btncreatetesting.Margin = new System.Windows.Forms.Padding(4);
            this.btncreatetesting.Name = "btncreatetesting";
            this.btncreatetesting.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btncreatetesting.Size = new System.Drawing.Size(188, 58);
            this.btncreatetesting.TabIndex = 5;
            this.btncreatetesting.Text = "Create Grants";
            this.btncreatetesting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreatetesting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncreatetesting.UseVisualStyleBackColor = false;
            this.btncreatetesting.Click += new System.EventHandler(this.btncreatetesting_Click);
            // 
            // btnViewall
            // 
            this.btnViewall.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewall.FlatAppearance.BorderSize = 0;
            this.btnViewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewall.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnViewall.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewall.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewall.IconSize = 30;
            this.btnViewall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewall.Location = new System.Drawing.Point(0, 383);
            this.btnViewall.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewall.Name = "btnViewall";
            this.btnViewall.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnViewall.Size = new System.Drawing.Size(188, 58);
            this.btnViewall.TabIndex = 6;
            this.btnViewall.Text = "View All";
            this.btnViewall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewall.UseVisualStyleBackColor = false;
            this.btnViewall.Click += new System.EventHandler(this.btnViewall_Click);
            // 
            // FrmGeneralGrantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 822);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnViewGrants);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGeneralGrantInfo";
            this.Text = "FrmGeneralGrantInfo";
            this.Load += new System.EventHandler(this.FrmGeneralGrantInfo_Load);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnViewGrants;
        private System.Windows.Forms.Panel pnlNav;
        private FontAwesome.Sharp.IconButton btnMyBlogs;
        private FontAwesome.Sharp.IconButton btnCreateBlog;
        private FontAwesome.Sharp.IconButton btnBlogs;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnViewall;
        private FontAwesome.Sharp.IconButton btncreatetesting;
    }
}
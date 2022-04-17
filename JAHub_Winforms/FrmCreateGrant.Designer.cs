namespace JAHub_Winforms
{
    partial class FrmCreateGrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateGrant));
            this.btnuploadfile = new System.Windows.Forms.Button();
            this.pbfile = new System.Windows.Forms.PictureBox();
            this.rtbdescription = new System.Windows.Forms.RichTextBox();
            this.lbltitlcreategrant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGrant = new System.Windows.Forms.Button();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.dtpExpirydate = new System.Windows.Forms.DateTimePicker();
            this.rtbrequirement = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcreategranttitle = new System.Windows.Forms.TextBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnDeleteGrant = new FontAwesome.Sharp.IconButton();
            this.btnViewall = new FontAwesome.Sharp.IconButton();
            this.btncreatetesting = new FontAwesome.Sharp.IconButton();
            this.btnMyBlogs = new FontAwesome.Sharp.IconButton();
            this.btnCreateBlog = new FontAwesome.Sharp.IconButton();
            this.btnBlogs = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.txtapplicationnumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbfile)).BeginInit();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
    //        this.SuspendLayout();
            // 
            // btnuploadfile
            // 
            this.btnuploadfile.Location = new System.Drawing.Point(398, 983);
            this.btnuploadfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuploadfile.Name = "btnuploadfile";
            this.btnuploadfile.Size = new System.Drawing.Size(88, 38);
            this.btnuploadfile.TabIndex = 0;
            this.btnuploadfile.Text = "Upload File";
            this.btnuploadfile.UseVisualStyleBackColor = true;
            // 
            // pbfile
            // 
            this.pbfile.Image = ((System.Drawing.Image)(resources.GetObject("pbfile.Image")));
            this.pbfile.Location = new System.Drawing.Point(289, 763);
            this.pbfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbfile.Name = "pbfile";
            this.pbfile.Size = new System.Drawing.Size(315, 194);
            this.pbfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbfile.TabIndex = 10;
            this.pbfile.TabStop = false;
            // 
            // rtbdescription
            // 
            this.rtbdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbdescription.Location = new System.Drawing.Point(288, 148);
            this.rtbdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbdescription.Name = "rtbdescription";
            this.rtbdescription.Size = new System.Drawing.Size(705, 181);
            this.rtbdescription.TabIndex = 9;
            this.rtbdescription.Text = "";
           
            // 
            // lbltitlcreategrant
            // 
            this.lbltitlcreategrant.AutoSize = true;
            this.lbltitlcreategrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlcreategrant.Location = new System.Drawing.Point(544, 37);
            this.lbltitlcreategrant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitlcreategrant.Name = "lbltitlcreategrant";
            this.lbltitlcreategrant.Size = new System.Drawing.Size(0, 29);
            this.lbltitlcreategrant.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Grant Description";
          
            // 
            // btnCreateGrant
            // 
            this.btnCreateGrant.Location = new System.Drawing.Point(761, 983);
            this.btnCreateGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateGrant.Name = "btnCreateGrant";
            this.btnCreateGrant.Size = new System.Drawing.Size(76, 38);
            this.btnCreateGrant.TabIndex = 32;
            this.btnCreateGrant.Text = "Submit";
            this.btnCreateGrant.UseVisualStyleBackColor = true;
            this.btnCreateGrant.Click += new System.EventHandler(this.btnCreateGrant_Click);
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(285, 662);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(181, 27);
            this.lblExpirationDate.TabIndex = 33;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // dtpExpirydate
            // 
            this.dtpExpirydate.Location = new System.Drawing.Point(289, 705);
            this.dtpExpirydate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpirydate.Name = "dtpExpirydate";
            this.dtpExpirydate.Size = new System.Drawing.Size(265, 22);
            this.dtpExpirydate.TabIndex = 34;
            // 
            // rtbrequirement
            // 
            this.rtbrequirement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbrequirement.Location = new System.Drawing.Point(287, 424);
            this.rtbrequirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbrequirement.Name = "rtbrequirement";
            this.rtbrequirement.Size = new System.Drawing.Size(706, 151);
            this.rtbrequirement.TabIndex = 35;
            this.rtbrequirement.Text = "";
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "Requirements";
           
            // 
            // txtcreategranttitle
            // 
            this.txtcreategranttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcreategranttitle.Location = new System.Drawing.Point(289, 37);
            this.txtcreategranttitle.Name = "txtcreategranttitle";
            this.txtcreategranttitle.Size = new System.Drawing.Size(266, 15);
            this.txtcreategranttitle.TabIndex = 37;
            this.txtcreategranttitle.Text = "Enter Title";
          
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlNav.Controls.Add(this.btnDeleteGrant);
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
            this.pnlNav.Size = new System.Drawing.Size(188, 1055);
            this.pnlNav.TabIndex = 64;
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
            // txtapplicationnumber
            // 
            this.txtapplicationnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapplicationnumber.Location = new System.Drawing.Point(1011, 37);
            this.txtapplicationnumber.Name = "txtapplicationnumber";
            this.txtapplicationnumber.Size = new System.Drawing.Size(118, 15);
            this.txtapplicationnumber.TabIndex = 65;
            this.txtapplicationnumber.Text = "Application  #";
           
            // 
            // FrmCreateGrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.txtapplicationnumber);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.txtcreategranttitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbrequirement);
            this.Controls.Add(this.dtpExpirydate);
            this.Controls.Add(this.btnuploadfile);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.btnCreateGrant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitlcreategrant);
            this.Controls.Add(this.pbfile);
            this.Controls.Add(this.rtbdescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateGrant";
            this.Load += new System.EventHandler(this.FrmCreateGrant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfile)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnuploadfile;
        private System.Windows.Forms.PictureBox pbfile;
        private System.Windows.Forms.RichTextBox rtbdescription;
        private System.Windows.Forms.Label lbltitlcreategrant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateGrant;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpExpirydate;
        private System.Windows.Forms.RichTextBox rtbrequirement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcreategranttitle;
        private System.Windows.Forms.Panel pnlNav;
        private FontAwesome.Sharp.IconButton btnDeleteGrant;
        private FontAwesome.Sharp.IconButton btnViewall;
        private FontAwesome.Sharp.IconButton btncreatetesting;
        private FontAwesome.Sharp.IconButton btnMyBlogs;
        private FontAwesome.Sharp.IconButton btnCreateBlog;
        private FontAwesome.Sharp.IconButton btnBlogs;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.TextBox txtapplicationnumber;
    }
}
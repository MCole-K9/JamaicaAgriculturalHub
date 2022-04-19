namespace JAHub_Winforms
{
    partial class FrmEditGrantInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditGrantInfo));
            this.txtapplicationnumber = new System.Windows.Forms.TextBox();
            this.btnDeleteGrant = new FontAwesome.Sharp.IconButton();
            this.btngrantcreate = new FontAwesome.Sharp.IconButton();
            this.btngrantHome = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnUpdateGrant = new FontAwesome.Sharp.IconButton();
            this.btnViewall = new FontAwesome.Sharp.IconButton();
            this.txtcreategranttitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpExpirydate = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.btnCreateGrant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitlcreategrant = new System.Windows.Forms.Label();
            this.rtbrequirement = new System.Windows.Forms.RichTextBox();
            this.btnuploadfile = new System.Windows.Forms.Button();
            this.pbfile = new System.Windows.Forms.PictureBox();
            this.rtbdescription = new System.Windows.Forms.RichTextBox();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtapplicationnumber
            // 
            this.txtapplicationnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapplicationnumber.Location = new System.Drawing.Point(980, -69);
            this.txtapplicationnumber.Name = "txtapplicationnumber";
            this.txtapplicationnumber.Size = new System.Drawing.Size(118, 15);
            this.txtapplicationnumber.TabIndex = 78;
            this.txtapplicationnumber.Text = "Application  #";
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
            this.btnDeleteGrant.Location = new System.Drawing.Point(0, 325);
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
            // btngrantcreate
            // 
            this.btngrantcreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btngrantcreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngrantcreate.FlatAppearance.BorderSize = 0;
            this.btngrantcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrantcreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngrantcreate.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btngrantcreate.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btngrantcreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngrantcreate.IconSize = 30;
            this.btngrantcreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrantcreate.Location = new System.Drawing.Point(0, 209);
            this.btngrantcreate.Margin = new System.Windows.Forms.Padding(4);
            this.btngrantcreate.Name = "btngrantcreate";
            this.btngrantcreate.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btngrantcreate.Size = new System.Drawing.Size(188, 58);
            this.btngrantcreate.TabIndex = 5;
            this.btngrantcreate.Text = "Create Grants";
            this.btngrantcreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrantcreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngrantcreate.UseVisualStyleBackColor = false;
            this.btngrantcreate.Click += new System.EventHandler(this.btngrantcreate_Click);
            // 
            // btngrantHome
            // 
            this.btngrantHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btngrantHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngrantHome.FlatAppearance.BorderSize = 0;
            this.btngrantHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrantHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngrantHome.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btngrantHome.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btngrantHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngrantHome.IconSize = 30;
            this.btngrantHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrantHome.Location = new System.Drawing.Point(0, 151);
            this.btngrantHome.Margin = new System.Windows.Forms.Padding(4);
            this.btngrantHome.Name = "btngrantHome";
            this.btngrantHome.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btngrantHome.Size = new System.Drawing.Size(188, 58);
            this.btngrantHome.TabIndex = 1;
            this.btngrantHome.Text = "Home";
            this.btngrantHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrantHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngrantHome.UseVisualStyleBackColor = false;
            this.btngrantHome.Click += new System.EventHandler(this.btngrantHome_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(188, 151);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JAHub_Winforms.Properties.Resources.farmer_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlNav.Controls.Add(this.btnUpdateGrant);
            this.pnlNav.Controls.Add(this.btnDeleteGrant);
            this.pnlNav.Controls.Add(this.btnViewall);
            this.pnlNav.Controls.Add(this.btngrantcreate);
            this.pnlNav.Controls.Add(this.btngrantHome);
            this.pnlNav.Controls.Add(this.pnlLogo);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(188, 915);
            this.pnlNav.TabIndex = 77;
            // 
            // btnUpdateGrant
            // 
            this.btnUpdateGrant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateGrant.FlatAppearance.BorderSize = 0;
            this.btnUpdateGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGrant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateGrant.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnUpdateGrant.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateGrant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateGrant.IconSize = 30;
            this.btnUpdateGrant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGrant.Location = new System.Drawing.Point(0, 383);
            this.btnUpdateGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateGrant.Name = "btnUpdateGrant";
            this.btnUpdateGrant.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnUpdateGrant.Size = new System.Drawing.Size(188, 58);
            this.btnUpdateGrant.TabIndex = 8;
            this.btnUpdateGrant.Text = "Update Grant";
            this.btnUpdateGrant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGrant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateGrant.UseVisualStyleBackColor = false;
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
            this.btnViewall.Location = new System.Drawing.Point(0, 267);
            this.btnViewall.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewall.Name = "btnViewall";
            this.btnViewall.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnViewall.Size = new System.Drawing.Size(188, 58);
            this.btnViewall.TabIndex = 6;
            this.btnViewall.Text = "View All Grants";
            this.btnViewall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewall.UseVisualStyleBackColor = false;
            this.btnViewall.Click += new System.EventHandler(this.btnViewall_Click);
            // 
            // txtcreategranttitle
            // 
            this.txtcreategranttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcreategranttitle.Location = new System.Drawing.Point(258, -69);
            this.txtcreategranttitle.Name = "txtcreategranttitle";
            this.txtcreategranttitle.Size = new System.Drawing.Size(266, 15);
            this.txtcreategranttitle.TabIndex = 76;
            this.txtcreategranttitle.Text = "Enter Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 75;
            this.label3.Text = "Requirements";
            // 
            // dtpExpirydate
            // 
            this.dtpExpirydate.Location = new System.Drawing.Point(258, 599);
            this.dtpExpirydate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpirydate.Name = "dtpExpirydate";
            this.dtpExpirydate.Size = new System.Drawing.Size(265, 22);
            this.dtpExpirydate.TabIndex = 73;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(254, 556);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(181, 27);
            this.lblExpirationDate.TabIndex = 72;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // btnCreateGrant
            // 
            this.btnCreateGrant.Location = new System.Drawing.Point(730, 877);
            this.btnCreateGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateGrant.Name = "btnCreateGrant";
            this.btnCreateGrant.Size = new System.Drawing.Size(82, 38);
            this.btnCreateGrant.TabIndex = 71;
            this.btnCreateGrant.Text = "Submit";
            this.btnCreateGrant.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 70;
            this.label1.Text = "Grant Description";
            // 
            // lbltitlcreategrant
            // 
            this.lbltitlcreategrant.AutoSize = true;
            this.lbltitlcreategrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlcreategrant.Location = new System.Drawing.Point(513, -69);
            this.lbltitlcreategrant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitlcreategrant.Name = "lbltitlcreategrant";
            this.lbltitlcreategrant.Size = new System.Drawing.Size(0, 29);
            this.lbltitlcreategrant.TabIndex = 69;
            // 
            // rtbrequirement
            // 
            this.rtbrequirement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbrequirement.Location = new System.Drawing.Point(256, 318);
            this.rtbrequirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbrequirement.Name = "rtbrequirement";
            this.rtbrequirement.Size = new System.Drawing.Size(706, 151);
            this.rtbrequirement.TabIndex = 74;
            this.rtbrequirement.Text = "";
            // 
            // btnuploadfile
            // 
            this.btnuploadfile.Location = new System.Drawing.Point(367, 877);
            this.btnuploadfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuploadfile.Name = "btnuploadfile";
            this.btnuploadfile.Size = new System.Drawing.Size(88, 38);
            this.btnuploadfile.TabIndex = 66;
            this.btnuploadfile.Text = "Upload File";
            this.btnuploadfile.UseVisualStyleBackColor = true;
            // 
            // pbfile
            // 
            this.pbfile.Image = ((System.Drawing.Image)(resources.GetObject("pbfile.Image")));
            this.pbfile.Location = new System.Drawing.Point(258, 657);
            this.pbfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbfile.Name = "pbfile";
            this.pbfile.Size = new System.Drawing.Size(315, 194);
            this.pbfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbfile.TabIndex = 68;
            this.pbfile.TabStop = false;
            // 
            // rtbdescription
            // 
            this.rtbdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbdescription.Location = new System.Drawing.Point(257, 42);
            this.rtbdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbdescription.Name = "rtbdescription";
            this.rtbdescription.Size = new System.Drawing.Size(705, 181);
            this.rtbdescription.TabIndex = 67;
            this.rtbdescription.Text = "";
            // 
            // FrmEditGrantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 809);
            this.Controls.Add(this.txtapplicationnumber);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.txtcreategranttitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpExpirydate);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.btnCreateGrant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitlcreategrant);
            this.Controls.Add(this.rtbrequirement);
            this.Controls.Add(this.btnuploadfile);
            this.Controls.Add(this.pbfile);
            this.Controls.Add(this.rtbdescription);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditGrantInfo";
            this.Text = "Update Grant";
            this.Load += new System.EventHandler(this.FrmEditGrantInfo_Load);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtapplicationnumber;
        private FontAwesome.Sharp.IconButton btnDeleteGrant;
        private FontAwesome.Sharp.IconButton btngrantcreate;
        private FontAwesome.Sharp.IconButton btngrantHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.TextBox txtcreategranttitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpExpirydate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Button btnCreateGrant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltitlcreategrant;
        private System.Windows.Forms.RichTextBox rtbrequirement;
        private System.Windows.Forms.Button btnuploadfile;
        private System.Windows.Forms.PictureBox pbfile;
        private System.Windows.Forms.RichTextBox rtbdescription;
        private FontAwesome.Sharp.IconButton btnUpdateGrant;
        private FontAwesome.Sharp.IconButton btnViewall;
    }
}
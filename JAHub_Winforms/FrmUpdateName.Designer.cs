namespace JAHub_Winforms
{
    partial class FrmUpdateName
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblJAHAccontlabel1 = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.lblNamelabel = new System.Windows.Forms.Label();
            this.lblUpdateNameInfolabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.lblLNamelabel = new System.Windows.Forms.Label();
            this.btnLName = new System.Windows.Forms.Button();
            this.lblfamelabel = new System.Windows.Forms.Label();
            this.btnFName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblJAHAccontlabel1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblNamelabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 88);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(658, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 38);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblJAHAccontlabel1
            // 
            this.lblJAHAccontlabel1.AutoSize = true;
            this.lblJAHAccontlabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJAHAccontlabel1.Location = new System.Drawing.Point(6, 8);
            this.lblJAHAccontlabel1.Name = "lblJAHAccontlabel1";
            this.lblJAHAccontlabel1.Size = new System.Drawing.Size(118, 25);
            this.lblJAHAccontlabel1.TabIndex = 3;
            this.lblJAHAccontlabel1.Text = "JAH Account";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 30;
            this.btnBack.Location = new System.Drawing.Point(84, 49);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 30);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblNamelabel
            // 
            this.lblNamelabel.AutoSize = true;
            this.lblNamelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamelabel.Location = new System.Drawing.Point(142, 49);
            this.lblNamelabel.Name = "lblNamelabel";
            this.lblNamelabel.Size = new System.Drawing.Size(62, 25);
            this.lblNamelabel.TabIndex = 0;
            this.lblNamelabel.Text = "Name";
            // 
            // lblUpdateNameInfolabel
            // 
            this.lblUpdateNameInfolabel.AutoSize = true;
            this.lblUpdateNameInfolabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateNameInfolabel.Location = new System.Drawing.Point(91, 95);
            this.lblUpdateNameInfolabel.Name = "lblUpdateNameInfolabel";
            this.lblUpdateNameInfolabel.Size = new System.Drawing.Size(591, 21);
            this.lblUpdateNameInfolabel.TabIndex = 1;
            this.lblUpdateNameInfolabel.Text = "Any changes you make to your name will be reflected throughout your JAH account.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.txtUpdateLastName);
            this.panel2.Controls.Add(this.txtUpdateFirstName);
            this.panel2.Controls.Add(this.lblLNamelabel);
            this.panel2.Controls.Add(this.btnLName);
            this.panel2.Controls.Add(this.lblfamelabel);
            this.panel2.Controls.Add(this.btnFName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(113, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 264);
            this.panel2.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(383, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(296, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateLastName.Location = new System.Drawing.Point(35, 145);
            this.txtUpdateLastName.Multiline = true;
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(285, 33);
            this.txtUpdateLastName.TabIndex = 7;
            this.txtUpdateLastName.Click += new System.EventHandler(this.txtUpdateLastName_Click);
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.BackColor = System.Drawing.Color.White;
            this.txtUpdateFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateFirstName.Location = new System.Drawing.Point(35, 67);
            this.txtUpdateFirstName.Multiline = true;
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(285, 33);
            this.txtUpdateFirstName.TabIndex = 4;
            this.txtUpdateFirstName.Click += new System.EventHandler(this.txtUpdateFirstName_Click);
            // 
            // lblLNamelabel
            // 
            this.lblLNamelabel.AutoSize = true;
            this.lblLNamelabel.Location = new System.Drawing.Point(41, 129);
            this.lblLNamelabel.Name = "lblLNamelabel";
            this.lblLNamelabel.Size = new System.Drawing.Size(58, 13);
            this.lblLNamelabel.TabIndex = 6;
            this.lblLNamelabel.Text = "Last Name";
            // 
            // btnLName
            // 
            this.btnLName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLName.Location = new System.Drawing.Point(33, 135);
            this.btnLName.Name = "btnLName";
            this.btnLName.Size = new System.Drawing.Size(292, 46);
            this.btnLName.TabIndex = 5;
            this.btnLName.UseVisualStyleBackColor = true;
            // 
            // lblfamelabel
            // 
            this.lblfamelabel.AutoSize = true;
            this.lblfamelabel.Location = new System.Drawing.Point(41, 51);
            this.lblfamelabel.Name = "lblfamelabel";
            this.lblfamelabel.Size = new System.Drawing.Size(57, 13);
            this.lblfamelabel.TabIndex = 3;
            this.lblfamelabel.Text = "First Name";
            // 
            // btnFName
            // 
            this.btnFName.BackColor = System.Drawing.Color.Transparent;
            this.btnFName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFName.Location = new System.Drawing.Point(33, 57);
            this.btnFName.Name = "btnFName";
            this.btnFName.Size = new System.Drawing.Size(292, 46);
            this.btnFName.TabIndex = 2;
            this.btnFName.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UPDATE NAME";
            // 
            // FrmUpdateName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblUpdateNameInfolabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdateName";
            this.Text = "FrmUpdateName";
            this.Load += new System.EventHandler(this.FrmUpdateName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNamelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblJAHAccontlabel1;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblUpdateNameInfolabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label lblLNamelabel;
        private System.Windows.Forms.Button btnLName;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label lblfamelabel;
        private System.Windows.Forms.Button btnFName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
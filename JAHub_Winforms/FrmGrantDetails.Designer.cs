namespace JAHub_Winforms
{
    partial class FrmGrantDetails
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
            this.pbscanpicture = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtexpirydate = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lblgrantdescription = new System.Windows.Forms.Label();
            this.lblexpirtydate = new System.Windows.Forms.Label();
            this.rtbgrantdescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbscanpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbscanpicture
            // 
            this.pbscanpicture.Location = new System.Drawing.Point(315, 368);
            this.pbscanpicture.Margin = new System.Windows.Forms.Padding(2);
            this.pbscanpicture.Name = "pbscanpicture";
            this.pbscanpicture.Size = new System.Drawing.Size(333, 203);
            this.pbscanpicture.TabIndex = 34;
            this.pbscanpicture.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 599);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 19);
            this.button2.TabIndex = 33;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 599);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 19);
            this.button1.TabIndex = 32;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtexpirydate
            // 
            this.txtexpirydate.BackColor = System.Drawing.SystemColors.Menu;
            this.txtexpirydate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtexpirydate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexpirydate.Location = new System.Drawing.Point(465, 323);
            this.txtexpirydate.Margin = new System.Windows.Forms.Padding(2);
            this.txtexpirydate.Name = "txtexpirydate";
            this.txtexpirydate.ReadOnly = true;
            this.txtexpirydate.Size = new System.Drawing.Size(218, 23);
            this.txtexpirydate.TabIndex = 31;
            this.txtexpirydate.Text = ".....";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 645);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.SystemColors.Menu;
            this.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(396, 74);
            this.txttitle.Margin = new System.Windows.Forms.Padding(2);
            this.txttitle.Name = "txttitle";
            this.txttitle.ReadOnly = true;
            this.txttitle.Size = new System.Drawing.Size(218, 23);
            this.txttitle.TabIndex = 29;
            this.txttitle.Text = ".....";
            // 
            // lblgrantdescription
            // 
            this.lblgrantdescription.AutoSize = true;
            this.lblgrantdescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrantdescription.Location = new System.Drawing.Point(278, 136);
            this.lblgrantdescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgrantdescription.Name = "lblgrantdescription";
            this.lblgrantdescription.Size = new System.Drawing.Size(125, 17);
            this.lblgrantdescription.TabIndex = 28;
            this.lblgrantdescription.Text = "Grant Description";
            // 
            // lblexpirtydate
            // 
            this.lblexpirtydate.AutoSize = true;
            this.lblexpirtydate.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpirtydate.Location = new System.Drawing.Point(367, 323);
            this.lblexpirtydate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblexpirtydate.Name = "lblexpirtydate";
            this.lblexpirtydate.Size = new System.Drawing.Size(101, 21);
            this.lblexpirtydate.TabIndex = 27;
            this.lblexpirtydate.Text = "Expiry Date:";
            // 
            // rtbgrantdescription
            // 
            this.rtbgrantdescription.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbgrantdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbgrantdescription.Location = new System.Drawing.Point(281, 160);
            this.rtbgrantdescription.Margin = new System.Windows.Forms.Padding(2);
            this.rtbgrantdescription.Multiline = true;
            this.rtbgrantdescription.Name = "rtbgrantdescription";
            this.rtbgrantdescription.ReadOnly = true;
            this.rtbgrantdescription.Size = new System.Drawing.Size(435, 160);
            this.rtbgrantdescription.TabIndex = 26;
            // 
            // FrmGrantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.pbscanpicture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtexpirydate);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.lblgrantdescription);
            this.Controls.Add(this.lblexpirtydate);
            this.Controls.Add(this.rtbgrantdescription);
            this.Name = "FrmGrantDetails";
            this.Text = "FrmGrantDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pbscanpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbscanpicture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtexpirydate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lblgrantdescription;
        private System.Windows.Forms.Label lblexpirtydate;
        private System.Windows.Forms.TextBox rtbgrantdescription;
    }
}
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.rtbRequirement = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtexpirydate = new System.Windows.Forms.TextBox();
            this.lblgrantdescription = new System.Windows.Forms.Label();
            this.lblexpirtydate = new System.Windows.Forms.Label();
            this.rtbgrantdescription = new System.Windows.Forms.TextBox();
            this.lblReqquirement = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbRequirement)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 794);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblReqquirement);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Controls.Add(this.rtbRequirement);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtexpirydate);
            this.panel1.Controls.Add(this.lblgrantdescription);
            this.panel1.Controls.Add(this.lblexpirtydate);
            this.panel1.Controls.Add(this.rtbgrantdescription);
            this.panel1.Location = new System.Drawing.Point(236, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 733);
            this.panel1.TabIndex = 31;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(302, 24);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(44, 16);
            this.lbltitle.TabIndex = 43;
            this.lbltitle.Text = "label1";
            // 
            // rtbRequirement
            // 
            this.rtbRequirement.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbRequirement.Location = new System.Drawing.Point(81, 377);
            this.rtbRequirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbRequirement.Name = "rtbRequirement";
            this.rtbRequirement.Size = new System.Drawing.Size(591, 215);
            this.rtbRequirement.TabIndex = 42;
            this.rtbRequirement.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 664);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 664);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtexpirydate
            // 
            this.txtexpirydate.BackColor = System.Drawing.SystemColors.Menu;
            this.txtexpirydate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtexpirydate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexpirydate.Location = new System.Drawing.Point(200, 610);
            this.txtexpirydate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtexpirydate.Name = "txtexpirydate";
            this.txtexpirydate.ReadOnly = true;
            this.txtexpirydate.Size = new System.Drawing.Size(291, 29);
            this.txtexpirydate.TabIndex = 39;
            this.txtexpirydate.Text = ".....";
            // 
            // lblgrantdescription
            // 
            this.lblgrantdescription.AutoSize = true;
            this.lblgrantdescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrantdescription.Location = new System.Drawing.Point(100, 93);
            this.lblgrantdescription.Name = "lblgrantdescription";
            this.lblgrantdescription.Size = new System.Drawing.Size(149, 19);
            this.lblgrantdescription.TabIndex = 38;
            this.lblgrantdescription.Text = "Grant Description";
            // 
            // lblexpirtydate
            // 
            this.lblexpirtydate.AutoSize = true;
            this.lblexpirtydate.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpirtydate.Location = new System.Drawing.Point(69, 613);
            this.lblexpirtydate.Name = "lblexpirtydate";
            this.lblexpirtydate.Size = new System.Drawing.Size(104, 23);
            this.lblexpirtydate.TabIndex = 37;
            this.lblexpirtydate.Text = "Deadline:";
            // 
            // rtbgrantdescription
            // 
            this.rtbgrantdescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbgrantdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbgrantdescription.Location = new System.Drawing.Point(81, 124);
            this.rtbgrantdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbgrantdescription.Multiline = true;
            this.rtbgrantdescription.Name = "rtbgrantdescription";
            this.rtbgrantdescription.ReadOnly = true;
            this.rtbgrantdescription.Size = new System.Drawing.Size(580, 197);
            this.rtbgrantdescription.TabIndex = 36;
            // 
            // lblReqquirement
            // 
            this.lblReqquirement.AutoSize = true;
            this.lblReqquirement.Location = new System.Drawing.Point(78, 349);
            this.lblReqquirement.Name = "lblReqquirement";
            this.lblReqquirement.Size = new System.Drawing.Size(76, 16);
            this.lblReqquirement.TabIndex = 44;
            this.lblReqquirement.Text = "Requiremts";
            // 
            // FrmGrantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 794);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrantDetails";
            this.Text = "FrmGrantDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbRequirement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox rtbRequirement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtexpirydate;
        private System.Windows.Forms.Label lblgrantdescription;
        private System.Windows.Forms.Label lblexpirtydate;
        private System.Windows.Forms.TextBox rtbgrantdescription;
        private System.Windows.Forms.Label lblReqquirement;
    }
}
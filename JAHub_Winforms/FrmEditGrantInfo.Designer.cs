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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbcwj = new System.Windows.Forms.PictureBox();
            this.rtbcwj = new System.Windows.Forms.RichTextBox();
            this.pansidebarcwj = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnuploadfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbcwj)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Edit Grant Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(865, 699);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add Description for Grant";
            // 
            // pbcwj
            // 
            this.pbcwj.Image = ((System.Drawing.Image)(resources.GetObject("pbcwj.Image")));
            this.pbcwj.Location = new System.Drawing.Point(233, 423);
            this.pbcwj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbcwj.Name = "pbcwj";
            this.pbcwj.Size = new System.Drawing.Size(309, 166);
            this.pbcwj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcwj.TabIndex = 22;
            this.pbcwj.TabStop = false;
            // 
            // rtbcwj
            // 
            this.rtbcwj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbcwj.Location = new System.Drawing.Point(233, 112);
            this.rtbcwj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbcwj.Name = "rtbcwj";
            this.rtbcwj.Size = new System.Drawing.Size(732, 182);
            this.rtbcwj.TabIndex = 21;
            this.rtbcwj.Text = resources.GetString("rtbcwj.Text");
            // 
            // pansidebarcwj
            // 
            this.pansidebarcwj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pansidebarcwj.Dock = System.Windows.Forms.DockStyle.Left;
            this.pansidebarcwj.Location = new System.Drawing.Point(0, 0);
            this.pansidebarcwj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pansidebarcwj.Name = "pansidebarcwj";
            this.pansidebarcwj.Size = new System.Drawing.Size(191, 809);
            this.pansidebarcwj.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Expiration Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(699, 331);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // btnuploadfile
            // 
            this.btnuploadfile.Location = new System.Drawing.Point(281, 693);
            this.btnuploadfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuploadfile.Name = "btnuploadfile";
            this.btnuploadfile.Size = new System.Drawing.Size(104, 39);
            this.btnuploadfile.TabIndex = 0;
            this.btnuploadfile.Text = "Upload File";
            this.btnuploadfile.UseVisualStyleBackColor = true;
            // 
            // FrmEditGrantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 809);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnuploadfile);
            this.Controls.Add(this.pansidebarcwj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbcwj);
            this.Controls.Add(this.rtbcwj);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditGrantInfo";
            this.Text = "FrmUserGeneralInfo";
            this.Load += new System.EventHandler(this.FrmEditGrantInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcwj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbcwj;
        private System.Windows.Forms.RichTextBox rtbcwj;
        private System.Windows.Forms.Panel pansidebarcwj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnuploadfile;
    }
}
﻿namespace JAHub_Winforms
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnremovefile = new System.Windows.Forms.Button();
            this.btndownload = new System.Windows.Forms.Button();
            this.btnuploadfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbcwj = new System.Windows.Forms.PictureBox();
            this.rtbcwj = new System.Windows.Forms.RichTextBox();
            this.pansidebarcwj = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcwj)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Edit Grant Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnremovefile, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btndownload, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnuploadfile, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(460, 344);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 135);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // btnremovefile
            // 
            this.btnremovefile.Location = new System.Drawing.Point(184, 2);
            this.btnremovefile.Margin = new System.Windows.Forms.Padding(2);
            this.btnremovefile.Name = "btnremovefile";
            this.btnremovefile.Size = new System.Drawing.Size(80, 41);
            this.btnremovefile.TabIndex = 2;
            this.btnremovefile.Text = "Remove File";
            this.btnremovefile.UseVisualStyleBackColor = true;
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(93, 2);
            this.btndownload.Margin = new System.Windows.Forms.Padding(2);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(86, 41);
            this.btndownload.TabIndex = 1;
            this.btndownload.Text = "Dowload File";
            this.btndownload.UseVisualStyleBackColor = true;
            // 
            // btnuploadfile
            // 
            this.btnuploadfile.Location = new System.Drawing.Point(2, 2);
            this.btnuploadfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnuploadfile.Name = "btnuploadfile";
            this.btnuploadfile.Size = new System.Drawing.Size(86, 41);
            this.btnuploadfile.TabIndex = 0;
            this.btnuploadfile.Text = "Upload File";
            this.btnuploadfile.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add Description for Grant";
            // 
            // pbcwj
            // 
            this.pbcwj.Image = ((System.Drawing.Image)(resources.GetObject("pbcwj.Image")));
            this.pbcwj.Location = new System.Drawing.Point(175, 344);
            this.pbcwj.Margin = new System.Windows.Forms.Padding(2);
            this.pbcwj.Name = "pbcwj";
            this.pbcwj.Size = new System.Drawing.Size(232, 135);
            this.pbcwj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcwj.TabIndex = 22;
            this.pbcwj.TabStop = false;
            // 
            // rtbcwj
            // 
            this.rtbcwj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbcwj.Location = new System.Drawing.Point(175, 91);
            this.rtbcwj.Margin = new System.Windows.Forms.Padding(2);
            this.rtbcwj.Name = "rtbcwj";
            this.rtbcwj.Size = new System.Drawing.Size(549, 148);
            this.rtbcwj.TabIndex = 21;
            this.rtbcwj.Text = resources.GetString("rtbcwj.Text");
            // 
            // pansidebarcwj
            // 
            this.pansidebarcwj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pansidebarcwj.Dock = System.Windows.Forms.DockStyle.Left;
            this.pansidebarcwj.Location = new System.Drawing.Point(0, 0);
            this.pansidebarcwj.Margin = new System.Windows.Forms.Padding(2);
            this.pansidebarcwj.Name = "pansidebarcwj";
            this.pansidebarcwj.Size = new System.Drawing.Size(143, 657);
            this.pansidebarcwj.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Expiration Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(524, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // FrmEditGrantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pansidebarcwj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbcwj);
            this.Controls.Add(this.rtbcwj);
            this.Name = "FrmEditGrantInfo";
            this.Text = "FrmUserGeneralInfo";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbcwj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnremovefile;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.Button btnuploadfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbcwj;
        private System.Windows.Forms.RichTextBox rtbcwj;
        private System.Windows.Forms.Panel pansidebarcwj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
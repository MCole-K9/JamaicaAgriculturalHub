namespace JAHub_Winforms
{
    partial class FrmUserGrantPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserGrantPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnremovefile = new System.Windows.Forms.Button();
            this.btndownload = new System.Windows.Forms.Button();
            this.btnuploadfile = new System.Windows.Forms.Button();
            this.pbcwj = new System.Windows.Forms.PictureBox();
            this.rtbcwj = new System.Windows.Forms.RichTextBox();
            this.pansidebarcwj = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcwj)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(401, 587);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 100);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnremovefile
            // 
            this.btnremovefile.Location = new System.Drawing.Point(245, 3);
            this.btnremovefile.Name = "btnremovefile";
            this.btnremovefile.Size = new System.Drawing.Size(107, 50);
            this.btnremovefile.TabIndex = 2;
            this.btnremovefile.Text = "Remove File";
            this.btnremovefile.UseVisualStyleBackColor = true;
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(124, 3);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(115, 50);
            this.btndownload.TabIndex = 1;
            this.btndownload.Text = "Dowload File";
            this.btndownload.UseVisualStyleBackColor = true;
            // 
            // btnuploadfile
            // 
            this.btnuploadfile.Location = new System.Drawing.Point(3, 3);
            this.btnuploadfile.Name = "btnuploadfile";
            this.btnuploadfile.Size = new System.Drawing.Size(115, 50);
            this.btnuploadfile.TabIndex = 0;
            this.btnuploadfile.Text = "Upload File";
            this.btnuploadfile.UseVisualStyleBackColor = true;
            // 
            // pbcwj
            // 
            this.pbcwj.Image = ((System.Drawing.Image)(resources.GetObject("pbcwj.Image")));
            this.pbcwj.Location = new System.Drawing.Point(374, 280);
            this.pbcwj.Name = "pbcwj";
            this.pbcwj.Size = new System.Drawing.Size(391, 258);
            this.pbcwj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcwj.TabIndex = 10;
            this.pbcwj.TabStop = false;
            // 
            // rtbcwj
            // 
            this.rtbcwj.Location = new System.Drawing.Point(298, 49);
            this.rtbcwj.Name = "rtbcwj";
            this.rtbcwj.Size = new System.Drawing.Size(705, 181);
            this.rtbcwj.TabIndex = 9;
            this.rtbcwj.Text = resources.GetString("rtbcwj.Text");
            // 
            // pansidebarcwj
            // 
            this.pansidebarcwj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pansidebarcwj.Dock = System.Windows.Forms.DockStyle.Left;
            this.pansidebarcwj.Location = new System.Drawing.Point(0, 0);
            this.pansidebarcwj.Name = "pansidebarcwj";
            this.pansidebarcwj.Size = new System.Drawing.Size(191, 953);
            this.pansidebarcwj.TabIndex = 12;
            // 
            // FrmUserGrantPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 953);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbcwj);
            this.Controls.Add(this.rtbcwj);
            this.Controls.Add(this.pansidebarcwj);
            this.Name = "FrmUserGrantPage";
            this.Text = "FrmUserGrantPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbcwj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnremovefile;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.Button btnuploadfile;
        private System.Windows.Forms.PictureBox pbcwj;
        private System.Windows.Forms.RichTextBox rtbcwj;
        private System.Windows.Forms.Panel pansidebarcwj;
    }
}
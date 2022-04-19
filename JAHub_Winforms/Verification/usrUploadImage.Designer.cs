namespace JAHub_Winforms.Verification
{
    partial class usrUploadImageBlock
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
            this.flpImageBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.picProfileImage = new System.Windows.Forms.PictureBox();
            this.tlpUploadDialog = new System.Windows.Forms.TableLayoutPanel();
            this.lblUploadPrompt = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.flpImageBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).BeginInit();
            this.tlpUploadDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpImageBlock
            // 
            this.flpImageBlock.AutoSize = true;
            this.flpImageBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpImageBlock.Controls.Add(this.picProfileImage);
            this.flpImageBlock.Controls.Add(this.tlpUploadDialog);
            this.flpImageBlock.Location = new System.Drawing.Point(3, 3);
            this.flpImageBlock.Name = "flpImageBlock";
            this.flpImageBlock.Size = new System.Drawing.Size(331, 106);
            this.flpImageBlock.TabIndex = 0;
            // 
            // picProfileImage
            // 
            this.picProfileImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picProfileImage.Location = new System.Drawing.Point(3, 3);
            this.picProfileImage.Name = "picProfileImage";
            this.picProfileImage.Size = new System.Drawing.Size(100, 100);
            this.picProfileImage.TabIndex = 2;
            this.picProfileImage.TabStop = false;
            // 
            // tlpUploadDialog
            // 
            this.tlpUploadDialog.BackColor = System.Drawing.Color.Transparent;
            this.tlpUploadDialog.ColumnCount = 1;
            this.tlpUploadDialog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUploadDialog.Controls.Add(this.lblUploadPrompt, 0, 0);
            this.tlpUploadDialog.Controls.Add(this.btnUploadImage, 0, 1);
            this.tlpUploadDialog.Location = new System.Drawing.Point(109, 3);
            this.tlpUploadDialog.Name = "tlpUploadDialog";
            this.tlpUploadDialog.RowCount = 2;
            this.tlpUploadDialog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUploadDialog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUploadDialog.Size = new System.Drawing.Size(219, 100);
            this.tlpUploadDialog.TabIndex = 1;
            // 
            // lblUploadPrompt
            // 
            this.lblUploadPrompt.AutoSize = true;
            this.lblUploadPrompt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUploadPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadPrompt.Location = new System.Drawing.Point(3, 0);
            this.lblUploadPrompt.Name = "lblUploadPrompt";
            this.lblUploadPrompt.Size = new System.Drawing.Size(199, 50);
            this.lblUploadPrompt.TabIndex = 0;
            this.lblUploadPrompt.Text = "Upload an picture of yourself (Passport Sized)";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(3, 53);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(121, 44);
            this.btnUploadImage.TabIndex = 1;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // usrUploadImageBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpImageBlock);
            this.Name = "usrUploadImageBlock";
            this.Size = new System.Drawing.Size(337, 112);
            this.flpImageBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).EndInit();
            this.tlpUploadDialog.ResumeLayout(false);
            this.tlpUploadDialog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpImageBlock;
        private System.Windows.Forms.TableLayoutPanel tlpUploadDialog;
        private System.Windows.Forms.Label lblUploadPrompt;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox picProfileImage;
    }
}

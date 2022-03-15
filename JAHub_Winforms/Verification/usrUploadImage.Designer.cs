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
            this.flwImageBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.tblUploadDialog = new System.Windows.Forms.TableLayoutPanel();
            this.lblUploadPrompt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picProfileImage = new System.Windows.Forms.PictureBox();
            this.flwImageBlock.SuspendLayout();
            this.tblUploadDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // flwImageBlock
            // 
            this.flwImageBlock.AutoSize = true;
            this.flwImageBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwImageBlock.Controls.Add(this.picProfileImage);
            this.flwImageBlock.Controls.Add(this.tblUploadDialog);
            this.flwImageBlock.Location = new System.Drawing.Point(3, 3);
            this.flwImageBlock.Name = "flwImageBlock";
            this.flwImageBlock.Size = new System.Drawing.Size(312, 106);
            this.flwImageBlock.TabIndex = 0;
            // 
            // tblUploadDialog
            // 
            this.tblUploadDialog.ColumnCount = 1;
            this.tblUploadDialog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUploadDialog.Controls.Add(this.lblUploadPrompt, 0, 0);
            this.tblUploadDialog.Controls.Add(this.button1, 0, 1);
            this.tblUploadDialog.Location = new System.Drawing.Point(109, 3);
            this.tblUploadDialog.Name = "tblUploadDialog";
            this.tblUploadDialog.RowCount = 2;
            this.tblUploadDialog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUploadDialog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUploadDialog.Size = new System.Drawing.Size(200, 100);
            this.tblUploadDialog.TabIndex = 1;
            // 
            // lblUploadPrompt
            // 
            this.lblUploadPrompt.AutoSize = true;
            this.lblUploadPrompt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUploadPrompt.Location = new System.Drawing.Point(3, 0);
            this.lblUploadPrompt.Name = "lblUploadPrompt";
            this.lblUploadPrompt.Size = new System.Drawing.Size(180, 50);
            this.lblUploadPrompt.TabIndex = 0;
            this.lblUploadPrompt.Text = "Upload an picture of yourself (Passport Sized)";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(3, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // usrUploadImageBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flwImageBlock);
            this.Name = "usrUploadImageBlock";
            this.Size = new System.Drawing.Size(318, 112);
            this.flwImageBlock.ResumeLayout(false);
            this.tblUploadDialog.ResumeLayout(false);
            this.tblUploadDialog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwImageBlock;
        private System.Windows.Forms.TableLayoutPanel tblUploadDialog;
        private System.Windows.Forms.Label lblUploadPrompt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picProfileImage;
    }
}

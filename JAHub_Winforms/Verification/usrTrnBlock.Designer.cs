namespace JAHub_Winforms.Verification
{
    partial class usrTrnBlock
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
            this.components = new System.ComponentModel.Container();
            this.tlpTrnBlock = new System.Windows.Forms.TableLayoutPanel();
            this.lblTrn = new System.Windows.Forms.Label();
            this.mskTrn = new System.Windows.Forms.MaskedTextBox();
            this.errTrnBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpTrnBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTrnBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTrnBlock
            // 
            this.tlpTrnBlock.AutoSize = true;
            this.tlpTrnBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTrnBlock.BackColor = System.Drawing.Color.Transparent;
            this.tlpTrnBlock.ColumnCount = 2;
            this.tlpTrnBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpTrnBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpTrnBlock.Controls.Add(this.lblTrn, 0, 0);
            this.tlpTrnBlock.Controls.Add(this.mskTrn, 1, 0);
            this.tlpTrnBlock.Location = new System.Drawing.Point(0, 0);
            this.tlpTrnBlock.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTrnBlock.Name = "tlpTrnBlock";
            this.tlpTrnBlock.RowCount = 1;
            this.tlpTrnBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTrnBlock.Size = new System.Drawing.Size(222, 33);
            this.tlpTrnBlock.TabIndex = 0;
            // 
            // lblTrn
            // 
            this.lblTrn.AutoSize = true;
            this.lblTrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrn.Location = new System.Drawing.Point(3, 0);
            this.lblTrn.Name = "lblTrn";
            this.lblTrn.Size = new System.Drawing.Size(49, 20);
            this.lblTrn.TabIndex = 0;
            this.lblTrn.Text = "TRN*";
            // 
            // mskTrn
            // 
            this.mskTrn.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTrn.Location = new System.Drawing.Point(75, 3);
            this.mskTrn.Mask = "000-000-000";
            this.mskTrn.Name = "mskTrn";
            this.mskTrn.Size = new System.Drawing.Size(115, 27);
            this.mskTrn.TabIndex = 1;
            this.mskTrn.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTrn.Validating += new System.ComponentModel.CancelEventHandler(this.mskTrn_Validating);
            // 
            // errTrnBlock
            // 
            this.errTrnBlock.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errTrnBlock.ContainerControl = this;
            // 
            // usrTrnBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpTrnBlock);
            this.Name = "usrTrnBlock";
            this.Size = new System.Drawing.Size(222, 33);
            this.tlpTrnBlock.ResumeLayout(false);
            this.tlpTrnBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTrnBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTrnBlock;
        private System.Windows.Forms.Label lblTrn;
        private System.Windows.Forms.MaskedTextBox mskTrn;
        private System.Windows.Forms.ErrorProvider errTrnBlock;
    }
}

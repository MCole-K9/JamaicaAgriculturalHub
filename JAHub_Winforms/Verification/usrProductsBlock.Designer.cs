namespace JAHub_Winforms.Verification
{
    partial class usrProductsBlock
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
            this.tlpProductBlock = new System.Windows.Forms.TableLayoutPanel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.errProductsBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpProductBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProductsBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpProductBlock
            // 
            this.tlpProductBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpProductBlock.BackColor = System.Drawing.Color.Transparent;
            this.tlpProductBlock.ColumnCount = 2;
            this.tlpProductBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpProductBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpProductBlock.Controls.Add(this.lblProduct, 0, 0);
            this.tlpProductBlock.Controls.Add(this.txtProduct, 1, 0);
            this.tlpProductBlock.Location = new System.Drawing.Point(0, 0);
            this.tlpProductBlock.Margin = new System.Windows.Forms.Padding(0);
            this.tlpProductBlock.MaximumSize = new System.Drawing.Size(400, 400);
            this.tlpProductBlock.Name = "tlpProductBlock";
            this.tlpProductBlock.RowCount = 1;
            this.tlpProductBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProductBlock.Size = new System.Drawing.Size(400, 33);
            this.tlpProductBlock.TabIndex = 0;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(3, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(144, 33);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(153, 3);
            this.txtProduct.MaxLength = 50;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(211, 27);
            this.txtProduct.TabIndex = 1;
            this.txtProduct.Validating += new System.ComponentModel.CancelEventHandler(this.txtProduct_Validating);
            // 
            // errProductsBlock
            // 
            this.errProductsBlock.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProductsBlock.ContainerControl = this;
            // 
            // usrProductsBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpProductBlock);
            this.Name = "usrProductsBlock";
            this.Size = new System.Drawing.Size(400, 33);
            this.tlpProductBlock.ResumeLayout(false);
            this.tlpProductBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProductsBlock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpProductBlock;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ErrorProvider errProductsBlock;
    }
}

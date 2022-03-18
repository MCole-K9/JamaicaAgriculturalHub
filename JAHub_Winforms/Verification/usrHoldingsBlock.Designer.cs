namespace JAHub_Winforms.Verification
{
    partial class usrHoldingsBlock
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
            this.flwHoldingBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHoldings = new System.Windows.Forms.Label();
            this.btnAddAnotherProduct = new System.Windows.Forms.Button();
            this.btnRemoveLastProduct = new System.Windows.Forms.Button();
            this.usrProductsBlock1 = new JAHub_Winforms.Verification.usrProductsBlock();
            this.usrLandBlock1 = new JAHub_Winforms.Verification.usrLandBlock();
            this.flwProductsBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.flwHoldingBlock.SuspendLayout();
            this.flwProductsBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwHoldingBlock
            // 
            this.flwHoldingBlock.AutoSize = true;
            this.flwHoldingBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwHoldingBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flwHoldingBlock.Controls.Add(this.lblHoldings);
            this.flwHoldingBlock.Controls.Add(this.flwProductsBlock);
            this.flwHoldingBlock.Controls.Add(this.btnAddAnotherProduct);
            this.flwHoldingBlock.Controls.Add(this.btnRemoveLastProduct);
            this.flwHoldingBlock.Controls.Add(this.usrLandBlock1);
            this.flwHoldingBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwHoldingBlock.Location = new System.Drawing.Point(3, 3);
            this.flwHoldingBlock.Name = "flwHoldingBlock";
            this.flwHoldingBlock.Size = new System.Drawing.Size(332, 313);
            this.flwHoldingBlock.TabIndex = 0;
            // 
            // lblHoldings
            // 
            this.lblHoldings.AutoSize = true;
            this.lblHoldings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoldings.Location = new System.Drawing.Point(3, 0);
            this.lblHoldings.Name = "lblHoldings";
            this.lblHoldings.Size = new System.Drawing.Size(88, 25);
            this.lblHoldings.TabIndex = 0;
            this.lblHoldings.Text = "Holdings";
            // 
            // btnAddAnotherProduct
            // 
            this.btnAddAnotherProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherProduct.Location = new System.Drawing.Point(3, 68);
            this.btnAddAnotherProduct.Name = "btnAddAnotherProduct";
            this.btnAddAnotherProduct.Size = new System.Drawing.Size(185, 32);
            this.btnAddAnotherProduct.TabIndex = 2;
            this.btnAddAnotherProduct.Text = "Add Another Product";
            this.btnAddAnotherProduct.UseVisualStyleBackColor = true;
            this.btnAddAnotherProduct.Click += new System.EventHandler(this.btnAddAnotherProduct_Click);
            // 
            // btnRemoveLastProduct
            // 
            this.btnRemoveLastProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLastProduct.Location = new System.Drawing.Point(3, 106);
            this.btnRemoveLastProduct.Name = "btnRemoveLastProduct";
            this.btnRemoveLastProduct.Size = new System.Drawing.Size(185, 32);
            this.btnRemoveLastProduct.TabIndex = 3;
            this.btnRemoveLastProduct.Text = "Remove Last Product";
            this.btnRemoveLastProduct.UseVisualStyleBackColor = true;
            this.btnRemoveLastProduct.Visible = false;
            this.btnRemoveLastProduct.Click += new System.EventHandler(this.btnRemoveLastProduct_Click);
            // 
            // usrProductsBlock1
            // 
            this.usrProductsBlock1.AutoSize = true;
            this.usrProductsBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrProductsBlock1.Location = new System.Drawing.Point(3, 3);
            this.usrProductsBlock1.Name = "usrProductsBlock1";
            this.usrProductsBlock1.Size = new System.Drawing.Size(300, 28);
            this.usrProductsBlock1.TabIndex = 1;
            // 
            // usrLandBlock1
            // 
            this.usrLandBlock1.AutoSize = true;
            this.usrLandBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrLandBlock1.Location = new System.Drawing.Point(3, 144);
            this.usrLandBlock1.Name = "usrLandBlock1";
            this.usrLandBlock1.Size = new System.Drawing.Size(326, 166);
            this.usrLandBlock1.TabIndex = 4;
            this.usrLandBlock1.Load += new System.EventHandler(this.usrLandBlock1_Load);
            // 
            // flwProductsBlock
            // 
            this.flwProductsBlock.AutoSize = true;
            this.flwProductsBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwProductsBlock.Controls.Add(this.usrProductsBlock1);
            this.flwProductsBlock.Location = new System.Drawing.Point(3, 28);
            this.flwProductsBlock.Name = "flwProductsBlock";
            this.flwProductsBlock.Size = new System.Drawing.Size(306, 34);
            this.flwProductsBlock.TabIndex = 5;
            // 
            // usrHoldingsBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flwHoldingBlock);
            this.Name = "usrHoldingsBlock";
            this.Size = new System.Drawing.Size(338, 319);
            this.flwHoldingBlock.ResumeLayout(false);
            this.flwHoldingBlock.PerformLayout();
            this.flwProductsBlock.ResumeLayout(false);
            this.flwProductsBlock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwHoldingBlock;
        private System.Windows.Forms.Label lblHoldings;
        private usrProductsBlock usrProductsBlock1;
        private System.Windows.Forms.Button btnAddAnotherProduct;
        private System.Windows.Forms.Button btnRemoveLastProduct;
        private usrLandBlock usrLandBlock1;
        private System.Windows.Forms.FlowLayoutPanel flwProductsBlock;
    }
}

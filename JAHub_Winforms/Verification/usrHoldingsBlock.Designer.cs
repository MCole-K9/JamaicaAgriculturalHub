using JAHubLib;

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
            this.flwProductsBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.usrProductsBlock1 = new JAHub_Winforms.Verification.usrProductsBlock();
            this.btnAddAnotherProduct = new System.Windows.Forms.Button();
            this.btnRemoveLastProduct = new System.Windows.Forms.Button();
            this.flwLandBlockHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.usrLandBlock1 = new JAHub_Winforms.Verification.usrLandBlock();
            this.btnAddLandEntry = new System.Windows.Forms.Button();
            this.btnRemoveLandEntry = new System.Windows.Forms.Button();
            this.flwHoldingBlock.SuspendLayout();
            this.flwProductsBlock.SuspendLayout();
            this.flwLandBlockHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwHoldingBlock
            // 
            this.flwHoldingBlock.AutoSize = true;
            this.flwHoldingBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwHoldingBlock.BackColor = System.Drawing.Color.Transparent;
            this.flwHoldingBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flwHoldingBlock.Controls.Add(this.lblHoldings);
            this.flwHoldingBlock.Controls.Add(this.flwProductsBlock);
            this.flwHoldingBlock.Controls.Add(this.btnAddAnotherProduct);
            this.flwHoldingBlock.Controls.Add(this.btnRemoveLastProduct);
            this.flwHoldingBlock.Controls.Add(this.flwLandBlockHolder);
            this.flwHoldingBlock.Controls.Add(this.btnAddLandEntry);
            this.flwHoldingBlock.Controls.Add(this.btnRemoveLandEntry);
            this.flwHoldingBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwHoldingBlock.Location = new System.Drawing.Point(3, 3);
            this.flwHoldingBlock.Name = "flwHoldingBlock";
            this.flwHoldingBlock.Size = new System.Drawing.Size(378, 426);
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
            // flwProductsBlock
            // 
            this.flwProductsBlock.AutoSize = true;
            this.flwProductsBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwProductsBlock.Controls.Add(this.usrProductsBlock1);
            this.flwProductsBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwProductsBlock.Location = new System.Drawing.Point(3, 28);
            this.flwProductsBlock.Name = "flwProductsBlock";
            this.flwProductsBlock.Size = new System.Drawing.Size(306, 39);
            this.flwProductsBlock.TabIndex = 5;
            this.flwProductsBlock.WrapContents = false;
            // 
            // usrProductsBlock1
            // 
            this.usrProductsBlock1.AutoSize = true;
            this.usrProductsBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrProductsBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrProductsBlock1.Location = new System.Drawing.Point(3, 3);
            this.usrProductsBlock1.Name = "usrProductsBlock1";
            this.usrProductsBlock1.Size = new System.Drawing.Size(300, 33);
            this.usrProductsBlock1.TabIndex = 1;
            // 
            // btnAddAnotherProduct
            // 
            this.btnAddAnotherProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherProduct.Location = new System.Drawing.Point(3, 73);
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
            this.btnRemoveLastProduct.Location = new System.Drawing.Point(3, 111);
            this.btnRemoveLastProduct.Name = "btnRemoveLastProduct";
            this.btnRemoveLastProduct.Size = new System.Drawing.Size(185, 32);
            this.btnRemoveLastProduct.TabIndex = 3;
            this.btnRemoveLastProduct.Text = "Remove Last Product";
            this.btnRemoveLastProduct.UseVisualStyleBackColor = true;
            this.btnRemoveLastProduct.Visible = false;
            this.btnRemoveLastProduct.Click += new System.EventHandler(this.btnRemoveLastProduct_Click);
            // 
            // flwLandBlockHolder
            // 
            this.flwLandBlockHolder.AutoSize = true;
            this.flwLandBlockHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwLandBlockHolder.Controls.Add(this.usrLandBlock1);
            this.flwLandBlockHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwLandBlockHolder.Location = new System.Drawing.Point(3, 149);
            this.flwLandBlockHolder.Name = "flwLandBlockHolder";
            this.flwLandBlockHolder.Size = new System.Drawing.Size(372, 198);
            this.flwLandBlockHolder.TabIndex = 6;
            // 
            // usrLandBlock1
            // 
            this.usrLandBlock1.AutoSize = true;
            this.usrLandBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrLandBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrLandBlock1.Location = new System.Drawing.Point(3, 3);
            this.usrLandBlock1.Name = "usrLandBlock1";
            this.usrLandBlock1.Size = new System.Drawing.Size(366, 192);
            this.usrLandBlock1.TabIndex = 4;
            // 
            // btnAddLandEntry
            // 
            this.btnAddLandEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLandEntry.Location = new System.Drawing.Point(3, 353);
            this.btnAddLandEntry.Name = "btnAddLandEntry";
            this.btnAddLandEntry.Size = new System.Drawing.Size(206, 32);
            this.btnAddLandEntry.TabIndex = 7;
            this.btnAddLandEntry.Text = "Add Another Land Entry";
            this.btnAddLandEntry.UseVisualStyleBackColor = true;
            this.btnAddLandEntry.Click += new System.EventHandler(this.btnAddLandEntry_Click);
            // 
            // btnRemoveLandEntry
            // 
            this.btnRemoveLandEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLandEntry.Location = new System.Drawing.Point(3, 391);
            this.btnRemoveLandEntry.Name = "btnRemoveLandEntry";
            this.btnRemoveLandEntry.Size = new System.Drawing.Size(206, 32);
            this.btnRemoveLandEntry.TabIndex = 8;
            this.btnRemoveLandEntry.Text = "Remove Last Land Entry";
            this.btnRemoveLandEntry.UseVisualStyleBackColor = true;
            this.btnRemoveLandEntry.Visible = false;
            this.btnRemoveLandEntry.Click += new System.EventHandler(this.btnRemoveLandEntry_Click);
            // 
            // usrHoldingsBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flwHoldingBlock);
            this.Name = "usrHoldingsBlock";
            this.Size = new System.Drawing.Size(384, 432);
            this.flwHoldingBlock.ResumeLayout(false);
            this.flwHoldingBlock.PerformLayout();
            this.flwProductsBlock.ResumeLayout(false);
            this.flwProductsBlock.PerformLayout();
            this.flwLandBlockHolder.ResumeLayout(false);
            this.flwLandBlockHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeFilledComponent(Farmer farmer)
        {
            this.flwHoldingBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHoldings = new System.Windows.Forms.Label();
            this.flwProductsBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddAnotherProduct = new System.Windows.Forms.Button();
            this.btnRemoveLastProduct = new System.Windows.Forms.Button();
            this.flwLandBlockHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddLandEntry = new System.Windows.Forms.Button();
            this.btnRemoveLandEntry = new System.Windows.Forms.Button();
            this.flwHoldingBlock.SuspendLayout();
            this.flwProductsBlock.SuspendLayout();
            this.flwLandBlockHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwHoldingBlock
            // 
            this.flwHoldingBlock.AutoSize = true;
            this.flwHoldingBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwHoldingBlock.BackColor = System.Drawing.Color.Transparent;
            this.flwHoldingBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flwHoldingBlock.Controls.Add(this.lblHoldings);
            this.flwHoldingBlock.Controls.Add(this.flwProductsBlock);
            this.flwHoldingBlock.Controls.Add(this.btnAddAnotherProduct);
            this.flwHoldingBlock.Controls.Add(this.btnRemoveLastProduct);
            this.flwHoldingBlock.Controls.Add(this.flwLandBlockHolder);
            this.flwHoldingBlock.Controls.Add(this.btnAddLandEntry);
            this.flwHoldingBlock.Controls.Add(this.btnRemoveLandEntry);
            this.flwHoldingBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwHoldingBlock.Location = new System.Drawing.Point(3, 3);
            this.flwHoldingBlock.Name = "flwHoldingBlock";
            this.flwHoldingBlock.Size = new System.Drawing.Size(372, 463);
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
            // flwProductsBlock
            // 
            this.flwProductsBlock.AutoSize = true;
            this.flwProductsBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwProductsBlock.Controls.Add(this.usrProductsBlock1);
            this.flwProductsBlock.Location = new System.Drawing.Point(3, 28);
            this.flwProductsBlock.Name = "flwProductsBlock";
            this.flwProductsBlock.Size = new System.Drawing.Size(306, 39);
            this.flwProductsBlock.TabIndex = 5;
            // 
            // btnAddAnotherProduct
            // 
            this.btnAddAnotherProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherProduct.Location = new System.Drawing.Point(3, 73);
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
            this.btnRemoveLastProduct.Location = new System.Drawing.Point(3, 111);
            this.btnRemoveLastProduct.Name = "btnRemoveLastProduct";
            this.btnRemoveLastProduct.Size = new System.Drawing.Size(185, 32);
            this.btnRemoveLastProduct.TabIndex = 3;
            this.btnRemoveLastProduct.Text = "Remove Last Product";
            this.btnRemoveLastProduct.UseVisualStyleBackColor = true;
            this.btnRemoveLastProduct.Visible = false;
            this.btnRemoveLastProduct.Click += new System.EventHandler(this.btnRemoveLastProduct_Click);
            // 
            // flwLandBlockHolder
            // 
            this.flwLandBlockHolder.Controls.Add(this.usrLandBlock1);
            this.flwLandBlockHolder.Location = new System.Drawing.Point(3, 149);
            this.flwLandBlockHolder.Name = "flwLandBlockHolder";
            this.flwLandBlockHolder.Size = new System.Drawing.Size(366, 235);
            this.flwLandBlockHolder.TabIndex = 6;
            // 
            // btnAddLandEntry
            // 
            this.btnAddLandEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLandEntry.Location = new System.Drawing.Point(3, 390);
            this.btnAddLandEntry.Name = "btnAddLandEntry";
            this.btnAddLandEntry.Size = new System.Drawing.Size(206, 32);
            this.btnAddLandEntry.TabIndex = 7;
            this.btnAddLandEntry.Text = "Add Another Land Entry";
            this.btnAddLandEntry.UseVisualStyleBackColor = true;
            this.btnAddLandEntry.Click += new System.EventHandler(this.btnAddLandEntry_Click);
            // 
            // btnRemoveLandEntry
            // 
            this.btnRemoveLandEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLandEntry.Location = new System.Drawing.Point(3, 428);
            this.btnRemoveLandEntry.Name = "btnRemoveLandEntry";
            this.btnRemoveLandEntry.Size = new System.Drawing.Size(206, 32);
            this.btnRemoveLandEntry.TabIndex = 8;
            this.btnRemoveLandEntry.Text = "Remove Last Land Entry";
            this.btnRemoveLandEntry.UseVisualStyleBackColor = true;
            this.btnRemoveLandEntry.Visible = false;
            this.btnRemoveLandEntry.Click += new System.EventHandler(this.btnRemoveLandEntry_Click);
            // 
            // usrHoldingsBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flwHoldingBlock);
            this.Name = "usrHoldingsBlock";
            this.Size = new System.Drawing.Size(378, 469);
            this.flwHoldingBlock.ResumeLayout(false);
            this.flwHoldingBlock.PerformLayout();
            this.flwProductsBlock.ResumeLayout(false);
            this.flwProductsBlock.PerformLayout();
            this.flwLandBlockHolder.ResumeLayout(false);
            this.flwLandBlockHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.FlowLayoutPanel flwHoldingBlock;
        private System.Windows.Forms.Label lblHoldings;
        private usrProductsBlock usrProductsBlock1;
        private System.Windows.Forms.Button btnAddAnotherProduct;
        private System.Windows.Forms.Button btnRemoveLastProduct;
        private usrLandBlock usrLandBlock1;
        private System.Windows.Forms.FlowLayoutPanel flwProductsBlock;
        private System.Windows.Forms.FlowLayoutPanel flwLandBlockHolder;
        private System.Windows.Forms.Button btnAddLandEntry;
        private System.Windows.Forms.Button btnRemoveLandEntry;
    }
}

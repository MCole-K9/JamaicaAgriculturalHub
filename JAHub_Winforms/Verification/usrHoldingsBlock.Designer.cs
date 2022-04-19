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
            this.flpHoldingBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHoldings = new System.Windows.Forms.Label();
            this.flpProductsBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddAnotherProduct = new System.Windows.Forms.Button();
            this.btnRemoveLastProduct = new System.Windows.Forms.Button();
            this.flpLandBlockHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddLandEntry = new System.Windows.Forms.Button();
            this.btnRemoveLandEntry = new System.Windows.Forms.Button();
            this.usrProductsBlock1 = new JAHub_Winforms.Verification.usrProductsBlock();
            this.usrLandBlock1 = new JAHub_Winforms.Verification.usrLandBlock();
            this.flpHoldingBlock.SuspendLayout();
            this.flpProductsBlock.SuspendLayout();
            this.flpLandBlockHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpHoldingBlock
            // 
            this.flpHoldingBlock.AutoSize = true;
            this.flpHoldingBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpHoldingBlock.BackColor = System.Drawing.Color.Transparent;
            this.flpHoldingBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpHoldingBlock.Controls.Add(this.lblHoldings);
            this.flpHoldingBlock.Controls.Add(this.flpProductsBlock);
            this.flpHoldingBlock.Controls.Add(this.btnAddAnotherProduct);
            this.flpHoldingBlock.Controls.Add(this.btnRemoveLastProduct);
            this.flpHoldingBlock.Controls.Add(this.flpLandBlockHolder);
            this.flpHoldingBlock.Controls.Add(this.btnAddLandEntry);
            this.flpHoldingBlock.Controls.Add(this.btnRemoveLandEntry);
            this.flpHoldingBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpHoldingBlock.Location = new System.Drawing.Point(3, 3);
            this.flpHoldingBlock.Name = "flpHoldingBlock";
            this.flpHoldingBlock.Size = new System.Drawing.Size(528, 426);
            this.flpHoldingBlock.TabIndex = 0;
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
            // flpProductsBlock
            // 
            this.flpProductsBlock.AutoSize = true;
            this.flpProductsBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpProductsBlock.Controls.Add(this.usrProductsBlock1);
            this.flpProductsBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProductsBlock.Location = new System.Drawing.Point(3, 28);
            this.flpProductsBlock.Name = "flpProductsBlock";
            this.flpProductsBlock.Size = new System.Drawing.Size(406, 39);
            this.flpProductsBlock.TabIndex = 5;
            this.flpProductsBlock.WrapContents = false;
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
            // flpLandBlockHolder
            // 
            this.flpLandBlockHolder.AutoSize = true;
            this.flpLandBlockHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpLandBlockHolder.Controls.Add(this.usrLandBlock1);
            this.flpLandBlockHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLandBlockHolder.Location = new System.Drawing.Point(3, 149);
            this.flpLandBlockHolder.Name = "flpLandBlockHolder";
            this.flpLandBlockHolder.Size = new System.Drawing.Size(522, 198);
            this.flpLandBlockHolder.TabIndex = 6;
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
            // usrProductsBlock1
            // 
            this.usrProductsBlock1.AutoSize = true;
            this.usrProductsBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrProductsBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrProductsBlock1.Location = new System.Drawing.Point(3, 3);
            this.usrProductsBlock1.Name = "usrProductsBlock1";
            this.usrProductsBlock1.Size = new System.Drawing.Size(400, 33);
            this.usrProductsBlock1.TabIndex = 1;
            // 
            // usrLandBlock1
            // 
            this.usrLandBlock1.AutoSize = true;
            this.usrLandBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrLandBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrLandBlock1.Location = new System.Drawing.Point(3, 3);
            this.usrLandBlock1.Name = "usrLandBlock1";
            this.usrLandBlock1.Size = new System.Drawing.Size(516, 192);
            this.usrLandBlock1.TabIndex = 4;
            // 
            // usrHoldingsBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpHoldingBlock);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Name = "usrHoldingsBlock";
            this.Size = new System.Drawing.Size(534, 432);
            this.flpHoldingBlock.ResumeLayout(false);
            this.flpHoldingBlock.PerformLayout();
            this.flpProductsBlock.ResumeLayout(false);
            this.flpProductsBlock.PerformLayout();
            this.flpLandBlockHolder.ResumeLayout(false);
            this.flpLandBlockHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeFilledComponent(Farmer farmer)
        {
            this.flpHoldingBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHoldings = new System.Windows.Forms.Label();
            this.flpProductsBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddAnotherProduct = new System.Windows.Forms.Button();
            this.btnRemoveLastProduct = new System.Windows.Forms.Button();
            this.flpLandBlockHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddLandEntry = new System.Windows.Forms.Button();
            this.btnRemoveLandEntry = new System.Windows.Forms.Button();
            this.flpHoldingBlock.SuspendLayout();
            this.flpProductsBlock.SuspendLayout();
            this.flpLandBlockHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwHoldingBlock
            // 
            this.flpHoldingBlock.AutoSize = true;
            this.flpHoldingBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpHoldingBlock.BackColor = System.Drawing.Color.Transparent;
            this.flpHoldingBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpHoldingBlock.Controls.Add(this.lblHoldings);
            this.flpHoldingBlock.Controls.Add(this.flpProductsBlock);
            this.flpHoldingBlock.Controls.Add(this.btnAddAnotherProduct);
            this.flpHoldingBlock.Controls.Add(this.btnRemoveLastProduct);
            this.flpHoldingBlock.Controls.Add(this.flpLandBlockHolder);
            this.flpHoldingBlock.Controls.Add(this.btnAddLandEntry);
            this.flpHoldingBlock.Controls.Add(this.btnRemoveLandEntry);
            this.flpHoldingBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpHoldingBlock.Location = new System.Drawing.Point(3, 3);
            this.flpHoldingBlock.Name = "flwHoldingBlock";
            this.flpHoldingBlock.Size = new System.Drawing.Size(516, 463);
            this.flpHoldingBlock.TabIndex = 0;
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
            this.flpProductsBlock.AutoSize = true;
            this.flpProductsBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpProductsBlock.Controls.Add(this.usrProductsBlock1);
            this.flpProductsBlock.Location = new System.Drawing.Point(3, 28);
            this.flpProductsBlock.Name = "flwProductsBlock";
            this.flpProductsBlock.Size = new System.Drawing.Size(306, 39);
            this.flpProductsBlock.TabIndex = 5;
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
            this.flpLandBlockHolder.Controls.Add(this.usrLandBlock1);
            this.flpLandBlockHolder.Location = new System.Drawing.Point(3, 149);
            this.flpLandBlockHolder.Name = "flwLandBlockHolder";
            this.flpLandBlockHolder.Size = new System.Drawing.Size(366, 235);
            this.flpLandBlockHolder.TabIndex = 6;
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
            this.Controls.Add(this.flpHoldingBlock);
            this.Name = "usrHoldingsBlock";
            this.Size = new System.Drawing.Size(378, 469);
            this.flpHoldingBlock.ResumeLayout(false);
            this.flpHoldingBlock.PerformLayout();
            this.flpProductsBlock.ResumeLayout(false);
            this.flpProductsBlock.PerformLayout();
            this.flpLandBlockHolder.ResumeLayout(false);
            this.flpLandBlockHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.FlowLayoutPanel flpHoldingBlock;
        private System.Windows.Forms.Label lblHoldings;
        private usrProductsBlock usrProductsBlock1;
        private System.Windows.Forms.Button btnAddAnotherProduct;
        private System.Windows.Forms.Button btnRemoveLastProduct;
        private usrLandBlock usrLandBlock1;
        private System.Windows.Forms.FlowLayoutPanel flpProductsBlock;
        private System.Windows.Forms.FlowLayoutPanel flpLandBlockHolder;
        private System.Windows.Forms.Button btnAddLandEntry;
        private System.Windows.Forms.Button btnRemoveLandEntry;
    }
}

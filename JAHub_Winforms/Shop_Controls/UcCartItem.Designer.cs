namespace JAHub_Winforms.Shop_Controls
{
    partial class UcCartItem
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
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.gbQty = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnPlus = new FontAwesome.Sharp.IconButton();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.LblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.gbQty.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbImage
            // 
            this.pcbImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbImage.Location = new System.Drawing.Point(0, 0);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(195, 144);
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(206, 10);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 20);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            // 
            // gbQty
            // 
            this.gbQty.Controls.Add(this.txtQty);
            this.gbQty.Controls.Add(this.btnPlus);
            this.gbQty.Controls.Add(this.btnMinus);
            this.gbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQty.Location = new System.Drawing.Point(201, 95);
            this.gbQty.Name = "gbQty";
            this.gbQty.Size = new System.Drawing.Size(166, 46);
            this.gbQty.TabIndex = 3;
            this.gbQty.TabStop = false;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(63, 19);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(40, 23);
            this.txtQty.TabIndex = 2;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnPlus.IconColor = System.Drawing.Color.Black;
            this.btnPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlus.IconSize = 14;
            this.btnPlus.Location = new System.Drawing.Point(120, 19);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(43, 24);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.Color.Black;
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 14;
            this.btnMinus.Location = new System.Drawing.Point(3, 19);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(43, 24);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.Location = new System.Drawing.Point(206, 72);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(33, 20);
            this.LblQty.TabIndex = 1;
            this.LblQty.Text = "Qty";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(491, 10);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(112, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "$0000 Per Lbs";
            // 
            // btnRemove
            // 
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnRemove.IconColor = System.Drawing.Color.Black;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 20;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.Location = new System.Drawing.Point(498, 107);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemove.Size = new System.Drawing.Size(105, 31);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // UcCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.gbQty);
            this.Controls.Add(this.LblQty);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.pcbImage);
            this.Name = "UcCartItem";
            this.Size = new System.Drawing.Size(620, 144);
            this.Load += new System.EventHandler(this.UcCartItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.gbQty.ResumeLayout(false);
            this.gbQty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.GroupBox gbQty;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnPlus;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblPrice;
        private FontAwesome.Sharp.IconButton btnRemove;
    }
}

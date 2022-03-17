namespace JAHub_Winforms
{
    partial class FrmProductDetail
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
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuyNow = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.gbQty = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnPlus = new FontAwesome.Sharp.IconButton();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.LblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbFarmerImage = new System.Windows.Forms.PictureBox();
            this.lblFarmerName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbQty.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFarmerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(12, 26);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(282, 201);
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnBuyNow);
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Controls.Add(this.gbQty);
            this.panel1.Controls.Add(this.LblQty);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Location = new System.Drawing.Point(300, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 201);
            this.panel1.TabIndex = 1;
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.Location = new System.Drawing.Point(137, 168);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(102, 30);
            this.btnBuyNow.TabIndex = 2;
            this.btnBuyNow.Text = "Buy Now";
            this.btnBuyNow.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(17, 168);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(102, 30);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // gbQty
            // 
            this.gbQty.Controls.Add(this.txtQty);
            this.gbQty.Controls.Add(this.btnPlus);
            this.gbQty.Controls.Add(this.btnMinus);
            this.gbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQty.Location = new System.Drawing.Point(17, 104);
            this.gbQty.Name = "gbQty";
            this.gbQty.Size = new System.Drawing.Size(166, 46);
            this.gbQty.TabIndex = 5;
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
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.Location = new System.Drawing.Point(15, 81);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(33, 20);
            this.LblQty.TabIndex = 4;
            this.LblQty.Text = "Qty";
            this.LblQty.Click += new System.EventHandler(this.LblQty_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(13, 47);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(112, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "$0000 Per Lbs";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(15, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pcbFarmerImage);
            this.panel2.Controls.Add(this.lblFarmerName);
            this.panel2.Location = new System.Drawing.Point(552, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 201);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-115, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Contact Farmer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Contact Farmer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pcbFarmerImage
            // 
            this.pcbFarmerImage.Location = new System.Drawing.Point(19, 47);
            this.pcbFarmerImage.Name = "pcbFarmerImage";
            this.pcbFarmerImage.Size = new System.Drawing.Size(188, 115);
            this.pcbFarmerImage.TabIndex = 1;
            this.pcbFarmerImage.TabStop = false;
            this.pcbFarmerImage.Click += new System.EventHandler(this.pcbFarmerImage_Click);
            // 
            // lblFarmerName
            // 
            this.lblFarmerName.AutoSize = true;
            this.lblFarmerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmerName.Location = new System.Drawing.Point(15, 12);
            this.lblFarmerName.Name = "lblFarmerName";
            this.lblFarmerName.Size = new System.Drawing.Size(106, 20);
            this.lblFarmerName.TabIndex = 0;
            this.lblFarmerName.Text = "Farmer Name";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 205);
            this.panel3.TabIndex = 2;
            // 
            // FrmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcbImage);
            this.Name = "FrmProductDetail";
            this.Text = "FrmProductDetail";
            this.Load += new System.EventHandler(this.FrmProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbQty.ResumeLayout(false);
            this.gbQty.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFarmerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox pcbFarmerImage;
        private System.Windows.Forms.Label lblFarmerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.GroupBox gbQty;
        private System.Windows.Forms.TextBox txtQty;
        private FontAwesome.Sharp.IconButton btnPlus;
        private FontAwesome.Sharp.IconButton btnMinus;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBuyNow;
    }
}
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbStar5 = new System.Windows.Forms.PictureBox();
            this.pbStar4 = new System.Windows.Forms.PictureBox();
            this.pbStar3 = new System.Windows.Forms.PictureBox();
            this.pbStar2 = new System.Windows.Forms.PictureBox();
            this.pbStar1 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.btnClearRating = new System.Windows.Forms.Button();
            this.fpnlReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.gbQty.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFarmerImage)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
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
            this.gbQty.Location = new System.Drawing.Point(17, 103);
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
            this.LblQty.Location = new System.Drawing.Point(13, 80);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(33, 20);
            this.LblQty.TabIndex = 4;
            this.LblQty.Text = "Qty";
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
            this.lblProductName.Location = new System.Drawing.Point(13, 12);
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
            this.button1.Location = new System.Drawing.Point(60, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Contact Farmer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pcbFarmerImage
            // 
            this.pcbFarmerImage.Image = global::JAHub_Winforms.Properties.Resources.icons8_customer_96;
            this.pcbFarmerImage.InitialImage = null;
            this.pcbFarmerImage.Location = new System.Drawing.Point(47, 63);
            this.pcbFarmerImage.Name = "pcbFarmerImage";
            this.pcbFarmerImage.Size = new System.Drawing.Size(132, 82);
            this.pcbFarmerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbFarmerImage.TabIndex = 1;
            this.pcbFarmerImage.TabStop = false;
            // 
            // lblFarmerName
            // 
            this.lblFarmerName.AutoSize = true;
            this.lblFarmerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmerName.Location = new System.Drawing.Point(56, 12);
            this.lblFarmerName.Name = "lblFarmerName";
            this.lblFarmerName.Size = new System.Drawing.Size(106, 20);
            this.lblFarmerName.TabIndex = 0;
            this.lblFarmerName.Text = "Farmer Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClearRating);
            this.panel4.Controls.Add(this.pbStar5);
            this.panel4.Controls.Add(this.pbStar4);
            this.panel4.Controls.Add(this.pbStar3);
            this.panel4.Controls.Add(this.pbStar2);
            this.panel4.Controls.Add(this.pbStar1);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Controls.Add(this.txtComment);
            this.panel4.Controls.Add(this.lblRating);
            this.panel4.Controls.Add(this.lblComment);
            this.panel4.Location = new System.Drawing.Point(425, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 233);
            this.panel4.TabIndex = 2;
            // 
            // pbStar5
            // 
            this.pbStar5.Image = global::JAHub_Winforms.Properties.Resources.white_star;
            this.pbStar5.Location = new System.Drawing.Point(203, 31);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(40, 32);
            this.pbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar5.TabIndex = 3;
            this.pbStar5.TabStop = false;
            this.pbStar5.Click += new System.EventHandler(this.pbStar5_Click);
            // 
            // pbStar4
            // 
            this.pbStar4.Image = global::JAHub_Winforms.Properties.Resources.white_star;
            this.pbStar4.Location = new System.Drawing.Point(157, 31);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(40, 32);
            this.pbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar4.TabIndex = 3;
            this.pbStar4.TabStop = false;
            this.pbStar4.Click += new System.EventHandler(this.pbStar4_Click);
            // 
            // pbStar3
            // 
            this.pbStar3.Image = global::JAHub_Winforms.Properties.Resources.white_star;
            this.pbStar3.Location = new System.Drawing.Point(111, 31);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(40, 32);
            this.pbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar3.TabIndex = 3;
            this.pbStar3.TabStop = false;
            this.pbStar3.Click += new System.EventHandler(this.pbStar3_Click);
            // 
            // pbStar2
            // 
            this.pbStar2.Image = global::JAHub_Winforms.Properties.Resources.white_star;
            this.pbStar2.Location = new System.Drawing.Point(65, 31);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(40, 32);
            this.pbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar2.TabIndex = 3;
            this.pbStar2.TabStop = false;
            this.pbStar2.Click += new System.EventHandler(this.pbStar2_Click);
            // 
            // pbStar1
            // 
            this.pbStar1.Image = global::JAHub_Winforms.Properties.Resources.white_star;
            this.pbStar1.Location = new System.Drawing.Point(15, 31);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(40, 32);
            this.pbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar1.TabIndex = 3;
            this.pbStar1.TabStop = false;
            this.pbStar1.Click += new System.EventHandler(this.pbStar1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 192);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit Review";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(15, 102);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(332, 84);
            this.txtComment.TabIndex = 1;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(9, 15);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Rating";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 77);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 0;
            this.lblComment.Text = "Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leave a Review";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reviews";
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(12, 26);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(282, 201);
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // btnClearRating
            // 
            this.btnClearRating.Location = new System.Drawing.Point(272, 31);
            this.btnClearRating.Name = "btnClearRating";
            this.btnClearRating.Size = new System.Drawing.Size(75, 32);
            this.btnClearRating.TabIndex = 4;
            this.btnClearRating.Text = "Clear Rating";
            this.btnClearRating.UseVisualStyleBackColor = true;
            this.btnClearRating.Click += new System.EventHandler(this.btnClearRating_Click);
            // 
            // fpnlReviews
            // 
            this.fpnlReviews.AutoScroll = true;
            this.fpnlReviews.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fpnlReviews.Location = new System.Drawing.Point(110, 259);
            this.fpnlReviews.Name = "fpnlReviews";
            this.fpnlReviews.Size = new System.Drawing.Size(309, 232);
            this.fpnlReviews.TabIndex = 4;
            // 
            // FrmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 503);
            this.Controls.Add(this.fpnlReviews);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcbImage);
            this.Name = "FrmProductDetail";
            this.Text = "FrmProductDetail";
            this.Load += new System.EventHandler(this.FrmProductDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbQty.ResumeLayout(false);
            this.gbQty.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFarmerImage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.PictureBox pbStar5;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar2;
        private System.Windows.Forms.Button btnClearRating;
        private System.Windows.Forms.FlowLayoutPanel fpnlReviews;
    }
}
namespace JAHub_Winforms.Shop_Controls
{
    partial class ucProduct
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(59, 174);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 20);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            this.lblItemName.Click += new System.EventHandler(this.lblItemName_Click);
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Location = new System.Drawing.Point(3, 248);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 35);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToCart.Location = new System.Drawing.Point(106, 248);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(101, 35);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "$0000 Per Lbs";
            this.label1.Click += new System.EventHandler(this.lblItemName_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(210, 293);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label1;
    }
}

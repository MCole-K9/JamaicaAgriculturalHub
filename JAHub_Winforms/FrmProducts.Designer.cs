namespace JAHub_Winforms
{
    partial class FrmProducts
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.fpnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 31);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // fpnlProducts
            // 
            this.fpnlProducts.AutoScroll = true;
            this.fpnlProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnlProducts.Location = new System.Drawing.Point(0, 60);
            this.fpnlProducts.Name = "fpnlProducts";
            this.fpnlProducts.Size = new System.Drawing.Size(717, 390);
            this.fpnlProducts.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(312, 28);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 21);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 18;
            this.btnSearch.Location = new System.Drawing.Point(616, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 22);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fpnlProducts);
            this.Controls.Add(this.lblCategory);
            this.Name = "FrmProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.FlowLayoutPanel fpnlProducts;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
    }
}
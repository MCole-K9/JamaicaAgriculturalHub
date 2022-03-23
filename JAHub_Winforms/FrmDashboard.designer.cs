namespace JAHub_Winforms
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelNumberofOrders = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotalNumberofOrders = new System.Windows.Forms.Label();
            this.lblNumberofOrderslabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalRevnuelabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTotalProfits = new System.Windows.Forms.Label();
            this.lblTotalProfitslabel = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBestSellers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvProductsShort = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNumberofOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBestSellers)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsShort)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNumberofOrders
            // 
            this.panelNumberofOrders.BackColor = System.Drawing.Color.White;
            this.panelNumberofOrders.Controls.Add(this.pictureBox2);
            this.panelNumberofOrders.Controls.Add(this.lblTotalNumberofOrders);
            this.panelNumberofOrders.Controls.Add(this.lblNumberofOrderslabel);
            this.panelNumberofOrders.Location = new System.Drawing.Point(79, 81);
            this.panelNumberofOrders.Name = "panelNumberofOrders";
            this.panelNumberofOrders.Size = new System.Drawing.Size(225, 53);
            this.panelNumberofOrders.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JAHub_Winforms.Properties.Resources.order_delivery;
            this.pictureBox2.Location = new System.Drawing.Point(9, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotalNumberofOrders
            // 
            this.lblTotalNumberofOrders.AutoSize = true;
            this.lblTotalNumberofOrders.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumberofOrders.Location = new System.Drawing.Point(72, 28);
            this.lblTotalNumberofOrders.Name = "lblTotalNumberofOrders";
            this.lblTotalNumberofOrders.Size = new System.Drawing.Size(36, 17);
            this.lblTotalNumberofOrders.TabIndex = 1;
            this.lblTotalNumberofOrders.Text = "1000";
            // 
            // lblNumberofOrderslabel
            // 
            this.lblNumberofOrderslabel.AutoSize = true;
            this.lblNumberofOrderslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofOrderslabel.Location = new System.Drawing.Point(66, 6);
            this.lblNumberofOrderslabel.Name = "lblNumberofOrderslabel";
            this.lblNumberofOrderslabel.Size = new System.Drawing.Size(120, 17);
            this.lblNumberofOrderslabel.TabIndex = 0;
            this.lblNumberofOrderslabel.Text = "Number of Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.lblTotalRevnuelabel);
            this.panel2.Location = new System.Drawing.Point(323, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 53);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JAHub_Winforms.Properties.Resources.revenue;
            this.pictureBox3.Location = new System.Drawing.Point(10, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(82, 31);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(36, 17);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "1000";
            // 
            // lblTotalRevnuelabel
            // 
            this.lblTotalRevnuelabel.AutoSize = true;
            this.lblTotalRevnuelabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevnuelabel.Location = new System.Drawing.Point(72, 9);
            this.lblTotalRevnuelabel.Name = "lblTotalRevnuelabel";
            this.lblTotalRevnuelabel.Size = new System.Drawing.Size(95, 17);
            this.lblTotalRevnuelabel.TabIndex = 0;
            this.lblTotalRevnuelabel.Text = "Total Revenue";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.lblTotalProfits);
            this.panel3.Controls.Add(this.lblTotalProfitslabel);
            this.panel3.Location = new System.Drawing.Point(681, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 53);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::JAHub_Winforms.Properties.Resources.profit;
            this.pictureBox4.Location = new System.Drawing.Point(6, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // lblTotalProfits
            // 
            this.lblTotalProfits.AutoSize = true;
            this.lblTotalProfits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfits.Location = new System.Drawing.Point(88, 31);
            this.lblTotalProfits.Name = "lblTotalProfits";
            this.lblTotalProfits.Size = new System.Drawing.Size(36, 17);
            this.lblTotalProfits.TabIndex = 1;
            this.lblTotalProfits.Text = "1000";
            // 
            // lblTotalProfitslabel
            // 
            this.lblTotalProfitslabel.AutoSize = true;
            this.lblTotalProfitslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfitslabel.Location = new System.Drawing.Point(75, 11);
            this.lblTotalProfitslabel.Name = "lblTotalProfitslabel";
            this.lblTotalProfitslabel.Size = new System.Drawing.Size(84, 17);
            this.lblTotalProfitslabel.TabIndex = 0;
            this.lblTotalProfitslabel.Text = "Total Profits";
            // 
            // chartGrossRevenue
            // 
            chartArea5.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend5);
            this.chartGrossRevenue.Location = new System.Drawing.Point(346, 149);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series5);
            this.chartGrossRevenue.Size = new System.Drawing.Size(664, 227);
            this.chartGrossRevenue.TabIndex = 3;
            this.chartGrossRevenue.Text = "chart1";
            title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Title1";
            title5.Text = "Gross Revenue";
            this.chartGrossRevenue.Titles.Add(title5);
            // 
            // chartBestSellers
            // 
            chartArea6.Name = "ChartArea1";
            this.chartBestSellers.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Name = "Legend1";
            this.chartBestSellers.Legends.Add(legend6);
            this.chartBestSellers.Location = new System.Drawing.Point(-8, 147);
            this.chartBestSellers.Name = "chartBestSellers";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series6.IsValueShownAsLabel = true;
            series6.LabelForeColor = System.Drawing.Color.White;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartBestSellers.Series.Add(series6);
            this.chartBestSellers.Size = new System.Drawing.Size(348, 437);
            this.chartBestSellers.TabIndex = 4;
            this.chartBestSellers.Text = "chart2";
            title6.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Title1";
            title6.Text = "Best Sellers";
            this.chartBestSellers.Titles.Add(title6);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblTotalCustomers);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(834, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 199);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1000";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Location = new System.Drawing.Point(37, 31);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(31, 13);
            this.lblTotalCustomers.TabIndex = 1;
            this.lblTotalCustomers.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Number of Customers";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvProductsShort);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(349, 384);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(479, 199);
            this.panel5.TabIndex = 6;
            // 
            // dgvProductsShort
            // 
            this.dgvProductsShort.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsShort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsShort.Location = new System.Drawing.Point(13, 45);
            this.dgvProductsShort.Name = "dgvProductsShort";
            this.dgvProductsShort.Size = new System.Drawing.Size(435, 143);
            this.dgvProductsShort.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Products in Short Supply";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(13, 11);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 64);
            this.panel6.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "All Local Products in One Place";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jamaica Agricultural Hub";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JAHub_Winforms.Properties.Resources.farmer_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1089, 637);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chartBestSellers);
            this.Controls.Add(this.chartGrossRevenue);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNumberofOrders);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panelNumberofOrders.ResumeLayout(false);
            this.panelNumberofOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBestSellers)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsShort)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNumberofOrders;
        private System.Windows.Forms.Label lblTotalNumberofOrders;
        private System.Windows.Forms.Label lblNumberofOrderslabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalRevnuelabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProfits;
        private System.Windows.Forms.Label lblTotalProfitslabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBestSellers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvProductsShort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
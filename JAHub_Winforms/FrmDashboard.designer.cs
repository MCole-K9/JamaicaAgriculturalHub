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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.panelTotalCounter = new System.Windows.Forms.Panel();
            this.lbllblTotalNumProductslabel = new System.Windows.Forms.Label();
            this.lblTotalNumProducts = new System.Windows.Forms.Label();
            this.lblTotalNumCustomers = new System.Windows.Forms.Label();
            this.lblTotalNumCustomerslabel = new System.Windows.Forms.Label();
            this.panelProductsLowStocks = new System.Windows.Forms.Panel();
            this.dgvProductsShort = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelNumberofOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBestSellers)).BeginInit();
            this.panelTotalCounter.SuspendLayout();
            this.panelProductsLowStocks.SuspendLayout();
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
            chartArea1.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend1);
            this.chartGrossRevenue.Location = new System.Drawing.Point(346, 149);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series1);
            this.chartGrossRevenue.Size = new System.Drawing.Size(664, 227);
            this.chartGrossRevenue.TabIndex = 3;
            this.chartGrossRevenue.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            this.chartGrossRevenue.Titles.Add(title1);
            // 
            // chartBestSellers
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBestSellers.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartBestSellers.Legends.Add(legend2);
            this.chartBestSellers.Location = new System.Drawing.Point(-8, 147);
            this.chartBestSellers.Name = "chartBestSellers";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBestSellers.Series.Add(series2);
            this.chartBestSellers.Size = new System.Drawing.Size(348, 437);
            this.chartBestSellers.TabIndex = 4;
            this.chartBestSellers.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Best Sellers";
            this.chartBestSellers.Titles.Add(title2);
            // 
            // panelTotalCounter
            // 
            this.panelTotalCounter.BackColor = System.Drawing.Color.White;
            this.panelTotalCounter.Controls.Add(this.lbllblTotalNumProductslabel);
            this.panelTotalCounter.Controls.Add(this.lblTotalNumProducts);
            this.panelTotalCounter.Controls.Add(this.lblTotalNumCustomers);
            this.panelTotalCounter.Controls.Add(this.lblTotalNumCustomerslabel);
            this.panelTotalCounter.Location = new System.Drawing.Point(834, 385);
            this.panelTotalCounter.Name = "panelTotalCounter";
            this.panelTotalCounter.Size = new System.Drawing.Size(176, 199);
            this.panelTotalCounter.TabIndex = 5;
            // 
            // lbllblTotalNumProductslabel
            // 
            this.lbllblTotalNumProductslabel.AutoSize = true;
            this.lbllblTotalNumProductslabel.Location = new System.Drawing.Point(14, 77);
            this.lbllblTotalNumProductslabel.Name = "lbllblTotalNumProductslabel";
            this.lbllblTotalNumProductslabel.Size = new System.Drawing.Size(128, 13);
            this.lbllblTotalNumProductslabel.TabIndex = 3;
            this.lbllblTotalNumProductslabel.Text = "Total Number of Products";
            // 
            // lblTotalNumProducts
            // 
            this.lblTotalNumProducts.AutoSize = true;
            this.lblTotalNumProducts.Location = new System.Drawing.Point(37, 99);
            this.lblTotalNumProducts.Name = "lblTotalNumProducts";
            this.lblTotalNumProducts.Size = new System.Drawing.Size(31, 13);
            this.lblTotalNumProducts.TabIndex = 2;
            this.lblTotalNumProducts.Text = "1000";
            // 
            // lblTotalNumCustomers
            // 
            this.lblTotalNumCustomers.AutoSize = true;
            this.lblTotalNumCustomers.Location = new System.Drawing.Point(37, 45);
            this.lblTotalNumCustomers.Name = "lblTotalNumCustomers";
            this.lblTotalNumCustomers.Size = new System.Drawing.Size(31, 13);
            this.lblTotalNumCustomers.TabIndex = 1;
            this.lblTotalNumCustomers.Text = "1000";
            // 
            // lblTotalNumCustomerslabel
            // 
            this.lblTotalNumCustomerslabel.AutoSize = true;
            this.lblTotalNumCustomerslabel.Location = new System.Drawing.Point(12, 23);
            this.lblTotalNumCustomerslabel.Name = "lblTotalNumCustomerslabel";
            this.lblTotalNumCustomerslabel.Size = new System.Drawing.Size(135, 13);
            this.lblTotalNumCustomerslabel.TabIndex = 0;
            this.lblTotalNumCustomerslabel.Text = "Total Number of Customers";
            // 
            // panelProductsLowStocks
            // 
            this.panelProductsLowStocks.BackColor = System.Drawing.Color.White;
            this.panelProductsLowStocks.Controls.Add(this.dgvProductsShort);
            this.panelProductsLowStocks.Controls.Add(this.label6);
            this.panelProductsLowStocks.Location = new System.Drawing.Point(349, 384);
            this.panelProductsLowStocks.Name = "panelProductsLowStocks";
            this.panelProductsLowStocks.Size = new System.Drawing.Size(479, 199);
            this.panelProductsLowStocks.TabIndex = 6;
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
            // btnLast7Days
            // 
            this.btnLast7Days.Location = new System.Drawing.Point(656, 21);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(116, 20);
            this.btnLast7Days.TabIndex = 8;
            this.btnLast7Days.Text = "Last 7 Days";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Location = new System.Drawing.Point(786, 21);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(116, 20);
            this.btnThisMonth.TabIndex = 8;
            this.btnThisMonth.Text = "This Month";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(534, 22);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(116, 20);
            this.btnToday.TabIndex = 8;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd,yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(301, 21);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(82, 20);
            this.dtpStartDate.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd,yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(389, 21);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(82, 20);
            this.dtpEndDate.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "End Date";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1089, 637);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelProductsLowStocks);
            this.Controls.Add(this.panelTotalCounter);
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
            this.panelTotalCounter.ResumeLayout(false);
            this.panelTotalCounter.PerformLayout();
            this.panelProductsLowStocks.ResumeLayout(false);
            this.panelProductsLowStocks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsShort)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panelTotalCounter;
        private System.Windows.Forms.Label lblTotalNumProducts;
        private System.Windows.Forms.Label lblTotalNumCustomers;
        private System.Windows.Forms.Label lblTotalNumCustomerslabel;
        private System.Windows.Forms.Panel panelProductsLowStocks;
        private System.Windows.Forms.DataGridView dgvProductsShort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbllblTotalNumProductslabel;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
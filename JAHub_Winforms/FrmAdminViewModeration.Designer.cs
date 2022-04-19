namespace JAHub_Winforms
{
    partial class FrmAdminViewModeration
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
            this.flpAdminViewModeration = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTitleBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblViewInfractions = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.flpInfractionsHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoInfractions = new System.Windows.Forms.Label();
            this.btnAddInfraction = new System.Windows.Forms.Button();
            this.flpAdminViewModeration.SuspendLayout();
            this.flpTitleBlock.SuspendLayout();
            this.flpInfractionsHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAdminViewModeration
            // 
            this.flpAdminViewModeration.AutoSize = true;
            this.flpAdminViewModeration.BackColor = System.Drawing.Color.White;
            this.flpAdminViewModeration.Controls.Add(this.flpTitleBlock);
            this.flpAdminViewModeration.Controls.Add(this.flpInfractionsHolder);
            this.flpAdminViewModeration.Controls.Add(this.btnAddInfraction);
            this.flpAdminViewModeration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAdminViewModeration.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAdminViewModeration.Location = new System.Drawing.Point(0, 0);
            this.flpAdminViewModeration.Margin = new System.Windows.Forms.Padding(0);
            this.flpAdminViewModeration.Name = "flpAdminViewModeration";
            this.flpAdminViewModeration.Size = new System.Drawing.Size(822, 453);
            this.flpAdminViewModeration.TabIndex = 0;
            // 
            // flpTitleBlock
            // 
            this.flpTitleBlock.AutoSize = true;
            this.flpTitleBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTitleBlock.Controls.Add(this.lblViewInfractions);
            this.flpTitleBlock.Controls.Add(this.lblUserName);
            this.flpTitleBlock.Location = new System.Drawing.Point(4, 4);
            this.flpTitleBlock.Margin = new System.Windows.Forms.Padding(4);
            this.flpTitleBlock.Name = "flpTitleBlock";
            this.flpTitleBlock.Size = new System.Drawing.Size(372, 29);
            this.flpTitleBlock.TabIndex = 0;
            // 
            // lblViewInfractions
            // 
            this.lblViewInfractions.AutoSize = true;
            this.lblViewInfractions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewInfractions.Location = new System.Drawing.Point(4, 0);
            this.lblViewInfractions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewInfractions.Name = "lblViewInfractions";
            this.lblViewInfractions.Size = new System.Drawing.Size(278, 29);
            this.lblViewInfractions.TabIndex = 0;
            this.lblViewInfractions.Text = "View Infractions for User:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(290, 0);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 29);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "[User]";
            // 
            // flpInfractionsHolder
            // 
            this.flpInfractionsHolder.AutoSize = true;
            this.flpInfractionsHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpInfractionsHolder.Controls.Add(this.lblNoInfractions);
            this.flpInfractionsHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpInfractionsHolder.Location = new System.Drawing.Point(4, 41);
            this.flpInfractionsHolder.Margin = new System.Windows.Forms.Padding(4);
            this.flpInfractionsHolder.Name = "flpInfractionsHolder";
            this.flpInfractionsHolder.Size = new System.Drawing.Size(189, 20);
            this.flpInfractionsHolder.TabIndex = 1;
            // 
            // lblNoInfractions
            // 
            this.lblNoInfractions.AutoSize = true;
            this.lblNoInfractions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoInfractions.Location = new System.Drawing.Point(3, 0);
            this.lblNoInfractions.Name = "lblNoInfractions";
            this.lblNoInfractions.Size = new System.Drawing.Size(183, 20);
            this.lblNoInfractions.TabIndex = 0;
            this.lblNoInfractions.Text = "User has no infractions";
            // 
            // btnAddInfraction
            // 
            this.btnAddInfraction.Location = new System.Drawing.Point(4, 69);
            this.btnAddInfraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddInfraction.Name = "btnAddInfraction";
            this.btnAddInfraction.Size = new System.Drawing.Size(170, 29);
            this.btnAddInfraction.TabIndex = 2;
            this.btnAddInfraction.Text = "Add Infraction";
            this.btnAddInfraction.UseVisualStyleBackColor = true;
            this.btnAddInfraction.Click += new System.EventHandler(this.btnAddInfraction_Click);
            // 
            // FrmAdminViewModeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(822, 453);
            this.Controls.Add(this.flpAdminViewModeration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAdminViewModeration";
            this.Text = "FrmAdminViewModeration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminViewModeration_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdminViewModeration_Load);
            this.flpAdminViewModeration.ResumeLayout(false);
            this.flpAdminViewModeration.PerformLayout();
            this.flpTitleBlock.ResumeLayout(false);
            this.flpTitleBlock.PerformLayout();
            this.flpInfractionsHolder.ResumeLayout(false);
            this.flpInfractionsHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAdminViewModeration;
        private System.Windows.Forms.FlowLayoutPanel flpTitleBlock;
        private System.Windows.Forms.Label lblViewInfractions;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.FlowLayoutPanel flpInfractionsHolder;
        private System.Windows.Forms.Button btnAddInfraction;
        private System.Windows.Forms.Label lblNoInfractions;
    }
}
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
            this.flwAdminViewModeration = new System.Windows.Forms.FlowLayoutPanel();
            this.flwTitleBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblViewInfractions = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.flwInfractionsHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoInfractions = new System.Windows.Forms.Label();
            this.btnAddInfraction = new System.Windows.Forms.Button();
            this.flwAdminViewModeration.SuspendLayout();
            this.flwTitleBlock.SuspendLayout();
            this.flwInfractionsHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwAdminViewModeration
            // 
            this.flwAdminViewModeration.AutoSize = true;
            this.flwAdminViewModeration.BackColor = System.Drawing.Color.White;
            this.flwAdminViewModeration.Controls.Add(this.flwTitleBlock);
            this.flwAdminViewModeration.Controls.Add(this.flwInfractionsHolder);
            this.flwAdminViewModeration.Controls.Add(this.btnAddInfraction);
            this.flwAdminViewModeration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwAdminViewModeration.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwAdminViewModeration.Location = new System.Drawing.Point(0, 0);
            this.flwAdminViewModeration.Margin = new System.Windows.Forms.Padding(0);
            this.flwAdminViewModeration.Name = "flwAdminViewModeration";
            this.flwAdminViewModeration.Size = new System.Drawing.Size(822, 453);
            this.flwAdminViewModeration.TabIndex = 0;
            // 
            // flwTitleBlock
            // 
            this.flwTitleBlock.AutoSize = true;
            this.flwTitleBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwTitleBlock.Controls.Add(this.lblViewInfractions);
            this.flwTitleBlock.Controls.Add(this.lblUserName);
            this.flwTitleBlock.Location = new System.Drawing.Point(4, 4);
            this.flwTitleBlock.Margin = new System.Windows.Forms.Padding(4);
            this.flwTitleBlock.Name = "flwTitleBlock";
            this.flwTitleBlock.Size = new System.Drawing.Size(372, 29);
            this.flwTitleBlock.TabIndex = 0;
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
            // flwInfractionsHolder
            // 
            this.flwInfractionsHolder.AutoSize = true;
            this.flwInfractionsHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwInfractionsHolder.Controls.Add(this.lblNoInfractions);
            this.flwInfractionsHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwInfractionsHolder.Location = new System.Drawing.Point(4, 41);
            this.flwInfractionsHolder.Margin = new System.Windows.Forms.Padding(4);
            this.flwInfractionsHolder.Name = "flwInfractionsHolder";
            this.flwInfractionsHolder.Size = new System.Drawing.Size(189, 20);
            this.flwInfractionsHolder.TabIndex = 1;
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
            this.Controls.Add(this.flwAdminViewModeration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminViewModeration";
            this.Text = "FrmAdminViewModeration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminViewModeration_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdminViewModeration_Load);
            this.flwAdminViewModeration.ResumeLayout(false);
            this.flwAdminViewModeration.PerformLayout();
            this.flwTitleBlock.ResumeLayout(false);
            this.flwTitleBlock.PerformLayout();
            this.flwInfractionsHolder.ResumeLayout(false);
            this.flwInfractionsHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwAdminViewModeration;
        private System.Windows.Forms.FlowLayoutPanel flwTitleBlock;
        private System.Windows.Forms.Label lblViewInfractions;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.FlowLayoutPanel flwInfractionsHolder;
        private System.Windows.Forms.Button btnAddInfraction;
        private System.Windows.Forms.Label lblNoInfractions;
    }
}
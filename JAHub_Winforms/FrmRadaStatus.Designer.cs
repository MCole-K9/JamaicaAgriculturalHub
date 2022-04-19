namespace JAHub_Winforms
{
    partial class FrmRadaStatus
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
            this.tblRadaStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblRadaStatus = new System.Windows.Forms.Label();
            this.lblStatusType = new System.Windows.Forms.Label();
            this.flwRadaStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.tblTextHolder = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatusExplanation = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnRegisterWithRada = new System.Windows.Forms.Button();
            this.tblRadaStatus.SuspendLayout();
            this.flwRadaStatus.SuspendLayout();
            this.tblTextHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblRadaStatus
            // 
            this.tblRadaStatus.ColumnCount = 2;
            this.tblRadaStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRadaStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRadaStatus.Controls.Add(this.lblRadaStatus, 0, 0);
            this.tblRadaStatus.Controls.Add(this.lblStatusType, 1, 0);
            this.tblRadaStatus.Location = new System.Drawing.Point(3, 3);
            this.tblRadaStatus.Name = "tblRadaStatus";
            this.tblRadaStatus.RowCount = 1;
            this.tblRadaStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRadaStatus.Size = new System.Drawing.Size(398, 38);
            this.tblRadaStatus.TabIndex = 0;
            // 
            // lblRadaStatus
            // 
            this.lblRadaStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRadaStatus.AutoSize = true;
            this.lblRadaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadaStatus.Location = new System.Drawing.Point(38, 4);
            this.lblRadaStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblRadaStatus.Name = "lblRadaStatus";
            this.lblRadaStatus.Size = new System.Drawing.Size(161, 29);
            this.lblRadaStatus.TabIndex = 0;
            this.lblRadaStatus.Text = "RADA Status: ";
            this.lblRadaStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusType
            // 
            this.lblStatusType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusType.AutoSize = true;
            this.lblStatusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusType.Location = new System.Drawing.Point(199, 4);
            this.lblStatusType.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatusType.Name = "lblStatusType";
            this.lblStatusType.Size = new System.Drawing.Size(176, 29);
            this.lblStatusType.TabIndex = 1;
            this.lblStatusType.Text = "Not Registered";
            this.lblStatusType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flwRadaStatus
            // 
            this.flwRadaStatus.AutoSize = true;
            this.flwRadaStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwRadaStatus.BackColor = System.Drawing.Color.Transparent;
            this.flwRadaStatus.Controls.Add(this.tblRadaStatus);
            this.flwRadaStatus.Controls.Add(this.tblTextHolder);
            this.flwRadaStatus.Controls.Add(this.btnRegisterWithRada);
            this.flwRadaStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwRadaStatus.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwRadaStatus.Location = new System.Drawing.Point(0, 0);
            this.flwRadaStatus.Margin = new System.Windows.Forms.Padding(0);
            this.flwRadaStatus.Name = "flwRadaStatus";
            this.flwRadaStatus.Size = new System.Drawing.Size(409, 285);
            this.flwRadaStatus.TabIndex = 1;
            this.flwRadaStatus.WrapContents = false;
            // 
            // tblTextHolder
            // 
            this.tblTextHolder.AutoSize = true;
            this.tblTextHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblTextHolder.ColumnCount = 2;
            this.tblTextHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTextHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTextHolder.Controls.Add(this.lblStatusExplanation, 0, 0);
            this.tblTextHolder.Controls.Add(this.btnEdit, 1, 1);
            this.tblTextHolder.Controls.Add(this.lblInformation, 0, 1);
            this.tblTextHolder.Location = new System.Drawing.Point(3, 47);
            this.tblTextHolder.Name = "tblTextHolder";
            this.tblTextHolder.RowCount = 2;
            this.tblTextHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTextHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTextHolder.Size = new System.Drawing.Size(381, 58);
            this.tblTextHolder.TabIndex = 3;
            // 
            // lblStatusExplanation
            // 
            this.lblStatusExplanation.AutoSize = true;
            this.tblTextHolder.SetColumnSpan(this.lblStatusExplanation, 2);
            this.lblStatusExplanation.Location = new System.Drawing.Point(3, 0);
            this.lblStatusExplanation.Name = "lblStatusExplanation";
            this.lblStatusExplanation.Size = new System.Drawing.Size(375, 20);
            this.lblStatusExplanation.TabIndex = 1;
            this.lblStatusExplanation.Text = "This text just explains what\'s actually the case rn";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(165, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 32);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "View";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(3, 26);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(156, 25);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "View Information";
            this.lblInformation.Visible = false;
            // 
            // btnRegisterWithRada
            // 
            this.btnRegisterWithRada.Location = new System.Drawing.Point(3, 111);
            this.btnRegisterWithRada.Name = "btnRegisterWithRada";
            this.btnRegisterWithRada.Size = new System.Drawing.Size(378, 50);
            this.btnRegisterWithRada.TabIndex = 4;
            this.btnRegisterWithRada.Text = "Click here to Register with RADA or connect a preexisting record";
            this.btnRegisterWithRada.UseVisualStyleBackColor = true;
            this.btnRegisterWithRada.Visible = false;
            this.btnRegisterWithRada.Click += new System.EventHandler(this.btnRegisterWithRada_Click);
            // 
            // FrmRadaStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 285);
            this.Controls.Add(this.flwRadaStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRadaStatus";
            this.Text = "Rada Status (This should not be visible!)";
            this.Load += new System.EventHandler(this.FrmRadaStatus_Load);
            this.tblRadaStatus.ResumeLayout(false);
            this.tblRadaStatus.PerformLayout();
            this.flwRadaStatus.ResumeLayout(false);
            this.flwRadaStatus.PerformLayout();
            this.tblTextHolder.ResumeLayout(false);
            this.tblTextHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblRadaStatus;
        private System.Windows.Forms.Label lblRadaStatus;
        private System.Windows.Forms.Label lblStatusType;
        private System.Windows.Forms.FlowLayoutPanel flwRadaStatus;
        private System.Windows.Forms.Label lblStatusExplanation;
        private System.Windows.Forms.TableLayoutPanel tblTextHolder;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRegisterWithRada;
        private System.Windows.Forms.Label lblInformation;
    }
}
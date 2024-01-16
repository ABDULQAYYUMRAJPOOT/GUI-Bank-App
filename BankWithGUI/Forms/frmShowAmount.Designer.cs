namespace BankWithGUI.Forms
{
    partial class frmShowAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowAmount));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblShowAmount = new System.Windows.Forms.Label();
            this.btnBackFromShowAmount = new System.Windows.Forms.Button();
            this.lblRupees = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.25F));
            this.tableLayoutPanel1.Controls.Add(this.lblShowAmount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBackFromShowAmount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRupees, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Lime;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblShowAmount
            // 
            this.lblShowAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblShowAmount.AutoSize = true;
            this.lblShowAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblShowAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAmount.ForeColor = System.Drawing.Color.Silver;
            this.lblShowAmount.Location = new System.Drawing.Point(192, 217);
            this.lblShowAmount.Name = "lblShowAmount";
            this.lblShowAmount.Size = new System.Drawing.Size(163, 16);
            this.lblShowAmount.TabIndex = 0;
            this.lblShowAmount.Text = "Amount in your account is: ";
            // 
            // btnBackFromShowAmount
            // 
            this.btnBackFromShowAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromShowAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackFromShowAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackFromShowAmount.Location = new System.Drawing.Point(141, 348);
            this.btnBackFromShowAmount.Name = "btnBackFromShowAmount";
            this.btnBackFromShowAmount.Size = new System.Drawing.Size(75, 23);
            this.btnBackFromShowAmount.TabIndex = 2;
            this.btnBackFromShowAmount.Text = "Back";
            this.btnBackFromShowAmount.UseVisualStyleBackColor = true;
            this.btnBackFromShowAmount.Click += new System.EventHandler(this.btnBackFromShowAmount_Click);
            // 
            // lblRupees
            // 
            this.lblRupees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRupees.AutoSize = true;
            this.lblRupees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRupees.Location = new System.Drawing.Point(361, 217);
            this.lblRupees.Name = "lblRupees";
            this.lblRupees.Size = new System.Drawing.Size(14, 16);
            this.lblRupees.TabIndex = 3;
            this.lblRupees.Text = "0";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Silver;
            this.lblHeader.Location = new System.Drawing.Point(361, 74);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(145, 32);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Balance";
            // 
            // frmShowAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowAmount";
            this.Load += new System.EventHandler(this.frmShowAmount_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblShowAmount;
        private System.Windows.Forms.Button btnBackFromShowAmount;
        private System.Windows.Forms.Label lblRupees;
        private System.Windows.Forms.Label lblHeader;
    }
}
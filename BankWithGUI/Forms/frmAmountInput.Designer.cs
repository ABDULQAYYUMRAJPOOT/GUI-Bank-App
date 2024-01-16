namespace BankWithGUI.Forms
{
    partial class frmAmountInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmountInput));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAmountInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAmountError = new System.Windows.Forms.Label();
            this.lblDepAmount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtAmountInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAmountError, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDepAmount, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAmountInput
            // 
            this.txtAmountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAmountInput.Location = new System.Drawing.Point(403, 202);
            this.txtAmountInput.Name = "txtAmountInput";
            this.txtAmountInput.Size = new System.Drawing.Size(197, 20);
            this.txtAmountInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(562, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAmountError
            // 
            this.lblAmountError.AutoSize = true;
            this.lblAmountError.BackColor = System.Drawing.Color.Transparent;
            this.lblAmountError.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAmountError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountError.ForeColor = System.Drawing.Color.Red;
            this.lblAmountError.Location = new System.Drawing.Point(319, 225);
            this.lblAmountError.Name = "lblAmountError";
            this.lblAmountError.Size = new System.Drawing.Size(78, 225);
            this.lblAmountError.TabIndex = 3;
            this.lblAmountError.Text = "Invalid Input";
            this.lblAmountError.Visible = false;
            // 
            // lblDepAmount
            // 
            this.lblDepAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepAmount.AutoSize = true;
            this.lblDepAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblDepAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepAmount.ForeColor = System.Drawing.Color.Silver;
            this.lblDepAmount.Location = new System.Drawing.Point(308, 209);
            this.lblDepAmount.Name = "lblDepAmount";
            this.lblDepAmount.Size = new System.Drawing.Size(89, 16);
            this.lblDepAmount.TabIndex = 0;
            this.lblDepAmount.Text = "Enter Amount:";
            // 
            // frmAmountInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAmountInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeposite";
            this.Load += new System.EventHandler(this.frmAmountInput_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAmountError;
        private System.Windows.Forms.Label lblDepAmount;
        private System.Windows.Forms.TextBox txtAmountInput;
        private System.Windows.Forms.Button button1;
    }
}
namespace BankWithGUI.Forms
{
    partial class frmSavingInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSavingInput));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSavingInput = new System.Windows.Forms.Label();
            this.btnSavingFinal = new System.Windows.Forms.Button();
            this.txtIDInput = new System.Windows.Forms.TextBox();
            this.lblIdInput = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtInterestRateInput = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSavingInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSavingFinal, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIDInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIdInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInterestRate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtInterestRateInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSavingInput
            // 
            this.lblSavingInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSavingInput.AutoSize = true;
            this.lblSavingInput.BackColor = System.Drawing.Color.Transparent;
            this.lblSavingInput.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingInput.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSavingInput.Location = new System.Drawing.Point(268, 74);
            this.lblSavingInput.Name = "lblSavingInput";
            this.lblSavingInput.Size = new System.Drawing.Size(263, 32);
            this.lblSavingInput.TabIndex = 0;
            this.lblSavingInput.Text = "Saving Account";
            // 
            // btnSavingFinal
            // 
            this.btnSavingFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavingFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingFinal.Location = new System.Drawing.Point(642, 367);
            this.btnSavingFinal.Name = "btnSavingFinal";
            this.btnSavingFinal.Size = new System.Drawing.Size(75, 23);
            this.btnSavingFinal.TabIndex = 1;
            this.btnSavingFinal.Text = "Next";
            this.btnSavingFinal.UseVisualStyleBackColor = true;
            this.btnSavingFinal.Click += new System.EventHandler(this.btnSavingFinal_Click);
            // 
            // txtIDInput
            // 
            this.txtIDInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDInput.Location = new System.Drawing.Point(243, 192);
            this.txtIDInput.Name = "txtIDInput";
            this.txtIDInput.Size = new System.Drawing.Size(238, 20);
            this.txtIDInput.TabIndex = 2;
            // 
            // lblIdInput
            // 
            this.lblIdInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIdInput.AutoSize = true;
            this.lblIdInput.BackColor = System.Drawing.Color.Transparent;
            this.lblIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInput.ForeColor = System.Drawing.Color.Silver;
            this.lblIdInput.Location = new System.Drawing.Point(177, 194);
            this.lblIdInput.Name = "lblIdInput";
            this.lblIdInput.Size = new System.Drawing.Size(60, 16);
            this.lblIdInput.TabIndex = 3;
            this.lblIdInput.Text = "Enter ID: ";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.BackColor = System.Drawing.Color.Transparent;
            this.lblInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.ForeColor = System.Drawing.Color.Silver;
            this.lblInterestRate.Location = new System.Drawing.Point(115, 258);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(122, 16);
            this.lblInterestRate.TabIndex = 4;
            this.lblInterestRate.Text = "Enter Interest Rate: ";
            // 
            // txtInterestRateInput
            // 
            this.txtInterestRateInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInterestRateInput.Location = new System.Drawing.Point(243, 256);
            this.txtInterestRateInput.Name = "txtInterestRateInput";
            this.txtInterestRateInput.Size = new System.Drawing.Size(238, 20);
            this.txtInterestRateInput.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(563, 258);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(80, 16);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Invalid Input!";
            this.lblError.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(82, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSavingInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSavingInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSavingInput";
            this.Load += new System.EventHandler(this.frmSavingInput_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSavingInput;
        private System.Windows.Forms.Button btnSavingFinal;
        private System.Windows.Forms.TextBox txtIDInput;
        private System.Windows.Forms.Label lblIdInput;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtInterestRateInput;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnBack;
    }
}
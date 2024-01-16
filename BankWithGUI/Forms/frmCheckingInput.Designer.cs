namespace BankWithGUI.Forms
{
    partial class frmCheckingInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckingInput));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIDChecking = new System.Windows.Forms.Label();
            this.txtCheckingID = new System.Windows.Forms.TextBox();
            this.btnCheckingFinal = new System.Windows.Forms.Button();
            this.lblCheckingInput = new System.Windows.Forms.Label();
            this.txtInterestChecking = new System.Windows.Forms.TextBox();
            this.lblInterestChecking = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.lblIDChecking, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCheckingID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckingFinal, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCheckingInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInterestChecking, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblInterestChecking, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblIDChecking
            // 
            this.lblIDChecking.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIDChecking.AutoSize = true;
            this.lblIDChecking.BackColor = System.Drawing.Color.Transparent;
            this.lblIDChecking.ForeColor = System.Drawing.Color.Silver;
            this.lblIDChecking.Location = new System.Drawing.Point(185, 196);
            this.lblIDChecking.Name = "lblIDChecking";
            this.lblIDChecking.Size = new System.Drawing.Size(52, 13);
            this.lblIDChecking.TabIndex = 1;
            this.lblIDChecking.Text = "Enter ID: ";
            // 
            // txtCheckingID
            // 
            this.txtCheckingID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCheckingID.Location = new System.Drawing.Point(243, 192);
            this.txtCheckingID.Name = "txtCheckingID";
            this.txtCheckingID.Size = new System.Drawing.Size(250, 20);
            this.txtCheckingID.TabIndex = 2;
            // 
            // btnCheckingFinal
            // 
            this.btnCheckingFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckingFinal.Location = new System.Drawing.Point(642, 348);
            this.btnCheckingFinal.Name = "btnCheckingFinal";
            this.btnCheckingFinal.Size = new System.Drawing.Size(75, 23);
            this.btnCheckingFinal.TabIndex = 3;
            this.btnCheckingFinal.Text = "Next";
            this.btnCheckingFinal.UseVisualStyleBackColor = true;
            this.btnCheckingFinal.Click += new System.EventHandler(this.btnCheckingFinal_Click);
            // 
            // lblCheckingInput
            // 
            this.lblCheckingInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckingInput.AutoSize = true;
            this.lblCheckingInput.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckingInput.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckingInput.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCheckingInput.Location = new System.Drawing.Point(250, 74);
            this.lblCheckingInput.Name = "lblCheckingInput";
            this.lblCheckingInput.Size = new System.Drawing.Size(299, 32);
            this.lblCheckingInput.TabIndex = 0;
            this.lblCheckingInput.Text = "Checking Account";
            // 
            // txtInterestChecking
            // 
            this.txtInterestChecking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInterestChecking.Location = new System.Drawing.Point(243, 237);
            this.txtInterestChecking.Name = "txtInterestChecking";
            this.txtInterestChecking.Size = new System.Drawing.Size(250, 20);
            this.txtInterestChecking.TabIndex = 4;
            // 
            // lblInterestChecking
            // 
            this.lblInterestChecking.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInterestChecking.AutoSize = true;
            this.lblInterestChecking.BackColor = System.Drawing.Color.Transparent;
            this.lblInterestChecking.ForeColor = System.Drawing.Color.Silver;
            this.lblInterestChecking.Location = new System.Drawing.Point(138, 241);
            this.lblInterestChecking.Name = "lblInterestChecking";
            this.lblInterestChecking.Size = new System.Drawing.Size(99, 13);
            this.lblInterestChecking.TabIndex = 5;
            this.lblInterestChecking.Text = "Enter InterestRate: ";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(563, 241);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(82, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Invalid Input!";
            this.lblError.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(82, 348);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCheckingInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckingInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckingInput";
            this.Load += new System.EventHandler(this.frmCheckingInput_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIDChecking;
        private System.Windows.Forms.TextBox txtCheckingID;
        private System.Windows.Forms.Button btnCheckingFinal;
        private System.Windows.Forms.Label lblCheckingInput;
        private System.Windows.Forms.TextBox txtInterestChecking;
        private System.Windows.Forms.Label lblInterestChecking;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnBack;
    }
}
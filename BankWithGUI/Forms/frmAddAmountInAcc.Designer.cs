namespace BankWithGUI.Forms
{
    partial class frmAddAmountInAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAmountInAcc));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddAmountEmp = new System.Windows.Forms.Label();
            this.btnBackFromDepEmp = new System.Windows.Forms.Button();
            this.lblEnterAmountEmp = new System.Windows.Forms.Label();
            this.txtDepAmountEmp = new System.Windows.Forms.TextBox();
            this.btnDepositEmp = new System.Windows.Forms.Button();
            this.lblDepositError = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDepIDEmp = new System.Windows.Forms.Label();
            this.txtDepNameEmp = new System.Windows.Forms.TextBox();
            this.lblDepNameEmp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.lblAddAmountEmp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBackFromDepEmp, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEnterAmountEmp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDepAmountEmp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDepositEmp, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDepositError, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDepIDEmp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDepNameEmp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDepNameEmp, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblAddAmountEmp
            // 
            this.lblAddAmountEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddAmountEmp.AutoSize = true;
            this.lblAddAmountEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblAddAmountEmp.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAmountEmp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAddAmountEmp.Location = new System.Drawing.Point(260, 74);
            this.lblAddAmountEmp.Name = "lblAddAmountEmp";
            this.lblAddAmountEmp.Size = new System.Drawing.Size(280, 32);
            this.lblAddAmountEmp.TabIndex = 0;
            this.lblAddAmountEmp.Text = "Deposite Amount";
            // 
            // btnBackFromDepEmp
            // 
            this.btnBackFromDepEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromDepEmp.Location = new System.Drawing.Point(82, 371);
            this.btnBackFromDepEmp.Name = "btnBackFromDepEmp";
            this.btnBackFromDepEmp.Size = new System.Drawing.Size(75, 23);
            this.btnBackFromDepEmp.TabIndex = 5;
            this.btnBackFromDepEmp.Text = "Back";
            this.btnBackFromDepEmp.UseVisualStyleBackColor = true;
            this.btnBackFromDepEmp.Click += new System.EventHandler(this.btnBackFromDepEmp_Click);
            // 
            // lblEnterAmountEmp
            // 
            this.lblEnterAmountEmp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEnterAmountEmp.AutoSize = true;
            this.lblEnterAmountEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterAmountEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAmountEmp.ForeColor = System.Drawing.Color.Silver;
            this.lblEnterAmountEmp.Location = new System.Drawing.Point(88, 285);
            this.lblEnterAmountEmp.Name = "lblEnterAmountEmp";
            this.lblEnterAmountEmp.Size = new System.Drawing.Size(149, 15);
            this.lblEnterAmountEmp.TabIndex = 3;
            this.lblEnterAmountEmp.Text = "Enter Amount To Deposit: ";
            // 
            // txtDepAmountEmp
            // 
            this.txtDepAmountEmp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDepAmountEmp.Location = new System.Drawing.Point(243, 282);
            this.txtDepAmountEmp.Name = "txtDepAmountEmp";
            this.txtDepAmountEmp.Size = new System.Drawing.Size(228, 20);
            this.txtDepAmountEmp.TabIndex = 1;
            // 
            // btnDepositEmp
            // 
            this.btnDepositEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDepositEmp.Location = new System.Drawing.Point(642, 371);
            this.btnDepositEmp.Name = "btnDepositEmp";
            this.btnDepositEmp.Size = new System.Drawing.Size(75, 23);
            this.btnDepositEmp.TabIndex = 2;
            this.btnDepositEmp.Text = "Deposite";
            this.btnDepositEmp.UseVisualStyleBackColor = true;
            this.btnDepositEmp.Click += new System.EventHandler(this.btnDepositEmp_Click);
            // 
            // lblDepositError
            // 
            this.lblDepositError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepositError.AutoSize = true;
            this.lblDepositError.BackColor = System.Drawing.Color.Transparent;
            this.lblDepositError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositError.ForeColor = System.Drawing.Color.Red;
            this.lblDepositError.Location = new System.Drawing.Point(347, 376);
            this.lblDepositError.Name = "lblDepositError";
            this.lblDepositError.Size = new System.Drawing.Size(106, 13);
            this.lblDepositError.TabIndex = 4;
            this.lblDepositError.Text = "Enter Valid Input!";
            this.lblDepositError.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(243, 237);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(228, 20);
            this.txtID.TabIndex = 8;
            // 
            // lblDepIDEmp
            // 
            this.lblDepIDEmp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepIDEmp.AutoSize = true;
            this.lblDepIDEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblDepIDEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepIDEmp.ForeColor = System.Drawing.Color.Silver;
            this.lblDepIDEmp.Location = new System.Drawing.Point(121, 240);
            this.lblDepIDEmp.Name = "lblDepIDEmp";
            this.lblDepIDEmp.Size = new System.Drawing.Size(116, 15);
            this.lblDepIDEmp.TabIndex = 6;
            this.lblDepIDEmp.Text = "Enter ID of Account: ";
            // 
            // txtDepNameEmp
            // 
            this.txtDepNameEmp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDepNameEmp.Location = new System.Drawing.Point(243, 192);
            this.txtDepNameEmp.Name = "txtDepNameEmp";
            this.txtDepNameEmp.Size = new System.Drawing.Size(228, 20);
            this.txtDepNameEmp.TabIndex = 9;
            // 
            // lblDepNameEmp
            // 
            this.lblDepNameEmp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepNameEmp.AutoSize = true;
            this.lblDepNameEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblDepNameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepNameEmp.ForeColor = System.Drawing.Color.Silver;
            this.lblDepNameEmp.Location = new System.Drawing.Point(158, 195);
            this.lblDepNameEmp.Name = "lblDepNameEmp";
            this.lblDepNameEmp.Size = new System.Drawing.Size(79, 15);
            this.lblDepNameEmp.TabIndex = 7;
            this.lblDepNameEmp.Text = "Enter Name: ";
            // 
            // frmAddAmountInAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAmountInAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAmountInAcc";
            this.Load += new System.EventHandler(this.frmAddAmountInAcc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAddAmountEmp;
        private System.Windows.Forms.TextBox txtDepAmountEmp;
        private System.Windows.Forms.Button btnDepositEmp;
        private System.Windows.Forms.Label lblEnterAmountEmp;
        private System.Windows.Forms.Label lblDepositError;
        private System.Windows.Forms.Button btnBackFromDepEmp;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDepIDEmp;
        private System.Windows.Forms.Label lblDepNameEmp;
        private System.Windows.Forms.TextBox txtDepNameEmp;
    }
}
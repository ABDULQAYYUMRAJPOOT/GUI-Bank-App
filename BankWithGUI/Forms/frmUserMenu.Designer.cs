namespace BankWithGUI.Forms
{
    partial class frmUserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMenu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserMenu = new System.Windows.Forms.Label();
            this.btnBackFromUser = new System.Windows.Forms.Button();
            this.btnDepositUser = new System.Windows.Forms.Button();
            this.btnWithdrawUser = new System.Windows.Forms.Button();
            this.btnTransferUser = new System.Windows.Forms.Button();
            this.btnBalanceUser = new System.Windows.Forms.Button();
            this.btnUpPassUser = new System.Windows.Forms.Button();
            this.btnGetLoanUser = new System.Windows.Forms.Button();
            this.btnPayLoanUser = new System.Windows.Forms.Button();
            this.btnAmountWithLoanUser = new System.Windows.Forms.Button();
            this.btnAmountWithInterestUser = new System.Windows.Forms.Button();
            this.btnGiveFeedUser = new System.Windows.Forms.Button();
            this.btnCheckLoanUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.lblUserMenu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBackFromUser, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnDepositUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnWithdrawUser, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTransferUser, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBalanceUser, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUpPassUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGetLoanUser, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnPayLoanUser, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAmountWithLoanUser, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAmountWithInterestUser, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnGiveFeedUser, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckLoanUser, 2, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.120498F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.840865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.840865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.777778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.840865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.840865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.840865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblUserMenu
            // 
            this.lblUserMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserMenu.AutoSize = true;
            this.lblUserMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblUserMenu.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMenu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblUserMenu.Location = new System.Drawing.Point(313, 11);
            this.lblUserMenu.Name = "lblUserMenu";
            this.lblUserMenu.Size = new System.Drawing.Size(174, 32);
            this.lblUserMenu.TabIndex = 12;
            this.lblUserMenu.Text = "User Menu";
            // 
            // btnBackFromUser
            // 
            this.btnBackFromUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFromUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackFromUser.Location = new System.Drawing.Point(102, 417);
            this.btnBackFromUser.Name = "btnBackFromUser";
            this.btnBackFromUser.Size = new System.Drawing.Size(75, 23);
            this.btnBackFromUser.TabIndex = 13;
            this.btnBackFromUser.Text = "Back";
            this.btnBackFromUser.UseVisualStyleBackColor = true;
            this.btnBackFromUser.Click += new System.EventHandler(this.btnBackFromUser_Click);
            // 
            // btnDepositUser
            // 
            this.btnDepositUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDepositUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDepositUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepositUser.FlatAppearance.BorderSize = 0;
            this.btnDepositUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositUser.Location = new System.Drawing.Point(166, 58);
            this.btnDepositUser.Name = "btnDepositUser";
            this.btnDepositUser.Size = new System.Drawing.Size(111, 29);
            this.btnDepositUser.TabIndex = 0;
            this.btnDepositUser.Text = "Deposit Amount";
            this.btnDepositUser.UseVisualStyleBackColor = false;
            this.btnDepositUser.Click += new System.EventHandler(this.btnDepositUser_Click);
            // 
            // btnWithdrawUser
            // 
            this.btnWithdrawUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnWithdrawUser.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdrawUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdrawUser.FlatAppearance.BorderSize = 0;
            this.btnWithdrawUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawUser.Location = new System.Drawing.Point(523, 58);
            this.btnWithdrawUser.Name = "btnWithdrawUser";
            this.btnWithdrawUser.Size = new System.Drawing.Size(111, 29);
            this.btnWithdrawUser.TabIndex = 7;
            this.btnWithdrawUser.Text = "Withdraw Amount";
            this.btnWithdrawUser.UseVisualStyleBackColor = false;
            this.btnWithdrawUser.Click += new System.EventHandler(this.btnWithdrawUser_Click);
            // 
            // btnTransferUser
            // 
            this.btnTransferUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTransferUser.BackColor = System.Drawing.Color.Transparent;
            this.btnTransferUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferUser.FlatAppearance.BorderSize = 0;
            this.btnTransferUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferUser.Location = new System.Drawing.Point(166, 136);
            this.btnTransferUser.Name = "btnTransferUser";
            this.btnTransferUser.Size = new System.Drawing.Size(111, 29);
            this.btnTransferUser.TabIndex = 10;
            this.btnTransferUser.Text = "Transfer Amount";
            this.btnTransferUser.UseVisualStyleBackColor = false;
            this.btnTransferUser.Click += new System.EventHandler(this.btnTransferUser_Click);
            // 
            // btnBalanceUser
            // 
            this.btnBalanceUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBalanceUser.BackColor = System.Drawing.Color.Transparent;
            this.btnBalanceUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalanceUser.FlatAppearance.BorderSize = 0;
            this.btnBalanceUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceUser.Location = new System.Drawing.Point(523, 136);
            this.btnBalanceUser.Name = "btnBalanceUser";
            this.btnBalanceUser.Size = new System.Drawing.Size(111, 29);
            this.btnBalanceUser.TabIndex = 2;
            this.btnBalanceUser.Text = "Check Balance";
            this.btnBalanceUser.UseVisualStyleBackColor = false;
            this.btnBalanceUser.Click += new System.EventHandler(this.btnBalanceUser_Click);
            // 
            // btnUpPassUser
            // 
            this.btnUpPassUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpPassUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUpPassUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpPassUser.FlatAppearance.BorderSize = 0;
            this.btnUpPassUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpPassUser.Location = new System.Drawing.Point(334, 96);
            this.btnUpPassUser.Name = "btnUpPassUser";
            this.btnUpPassUser.Size = new System.Drawing.Size(131, 29);
            this.btnUpPassUser.TabIndex = 3;
            this.btnUpPassUser.Text = "Update Password";
            this.btnUpPassUser.UseVisualStyleBackColor = false;
            this.btnUpPassUser.Click += new System.EventHandler(this.btnUpPassUser_Click);
            // 
            // btnGetLoanUser
            // 
            this.btnGetLoanUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetLoanUser.BackColor = System.Drawing.Color.Transparent;
            this.btnGetLoanUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetLoanUser.FlatAppearance.BorderSize = 0;
            this.btnGetLoanUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetLoanUser.Location = new System.Drawing.Point(166, 209);
            this.btnGetLoanUser.Name = "btnGetLoanUser";
            this.btnGetLoanUser.Size = new System.Drawing.Size(111, 29);
            this.btnGetLoanUser.TabIndex = 5;
            this.btnGetLoanUser.Text = "Get Loan";
            this.btnGetLoanUser.UseVisualStyleBackColor = false;
            this.btnGetLoanUser.Click += new System.EventHandler(this.btnGetLoanUser_Click);
            // 
            // btnPayLoanUser
            // 
            this.btnPayLoanUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPayLoanUser.BackColor = System.Drawing.Color.Transparent;
            this.btnPayLoanUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayLoanUser.FlatAppearance.BorderSize = 0;
            this.btnPayLoanUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayLoanUser.Location = new System.Drawing.Point(523, 209);
            this.btnPayLoanUser.Name = "btnPayLoanUser";
            this.btnPayLoanUser.Size = new System.Drawing.Size(111, 29);
            this.btnPayLoanUser.TabIndex = 8;
            this.btnPayLoanUser.Text = "Pay Loan";
            this.btnPayLoanUser.UseVisualStyleBackColor = false;
            this.btnPayLoanUser.Click += new System.EventHandler(this.btnPayLoanUser_Click);
            // 
            // btnAmountWithLoanUser
            // 
            this.btnAmountWithLoanUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAmountWithLoanUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAmountWithLoanUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmountWithLoanUser.FlatAppearance.BorderSize = 0;
            this.btnAmountWithLoanUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmountWithLoanUser.Location = new System.Drawing.Point(166, 269);
            this.btnAmountWithLoanUser.Name = "btnAmountWithLoanUser";
            this.btnAmountWithLoanUser.Size = new System.Drawing.Size(111, 47);
            this.btnAmountWithLoanUser.TabIndex = 1;
            this.btnAmountWithLoanUser.Text = "Amount With Loan";
            this.btnAmountWithLoanUser.UseVisualStyleBackColor = false;
            this.btnAmountWithLoanUser.Click += new System.EventHandler(this.btnAmountWithLoanUser_Click);
            // 
            // btnAmountWithInterestUser
            // 
            this.btnAmountWithInterestUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAmountWithInterestUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAmountWithInterestUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmountWithInterestUser.FlatAppearance.BorderSize = 0;
            this.btnAmountWithInterestUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmountWithInterestUser.Location = new System.Drawing.Point(523, 269);
            this.btnAmountWithInterestUser.Name = "btnAmountWithInterestUser";
            this.btnAmountWithInterestUser.Size = new System.Drawing.Size(111, 47);
            this.btnAmountWithInterestUser.TabIndex = 4;
            this.btnAmountWithInterestUser.Text = "Amount With Interest";
            this.btnAmountWithInterestUser.UseVisualStyleBackColor = false;
            this.btnAmountWithInterestUser.Click += new System.EventHandler(this.btnAmountWithInterestUser_Click);
            // 
            // btnGiveFeedUser
            // 
            this.btnGiveFeedUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGiveFeedUser.BackColor = System.Drawing.Color.Transparent;
            this.btnGiveFeedUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiveFeedUser.FlatAppearance.BorderSize = 0;
            this.btnGiveFeedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveFeedUser.Location = new System.Drawing.Point(166, 372);
            this.btnGiveFeedUser.Name = "btnGiveFeedUser";
            this.btnGiveFeedUser.Size = new System.Drawing.Size(111, 29);
            this.btnGiveFeedUser.TabIndex = 6;
            this.btnGiveFeedUser.Text = "Give FeedBack";
            this.btnGiveFeedUser.UseVisualStyleBackColor = false;
            this.btnGiveFeedUser.Click += new System.EventHandler(this.btnGiveFeedUser_Click);
            // 
            // btnCheckLoanUser
            // 
            this.btnCheckLoanUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCheckLoanUser.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckLoanUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckLoanUser.FlatAppearance.BorderSize = 0;
            this.btnCheckLoanUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckLoanUser.Location = new System.Drawing.Point(523, 372);
            this.btnCheckLoanUser.Name = "btnCheckLoanUser";
            this.btnCheckLoanUser.Size = new System.Drawing.Size(111, 29);
            this.btnCheckLoanUser.TabIndex = 11;
            this.btnCheckLoanUser.Text = "Check Loan Amount";
            this.btnCheckLoanUser.UseVisualStyleBackColor = false;
            this.btnCheckLoanUser.Click += new System.EventHandler(this.btnCheckLoanUser_Click);
            // 
            // frmUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserMenu";
            this.Load += new System.EventHandler(this.frmUserMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCheckLoanUser;
        private System.Windows.Forms.Button btnTransferUser;
        private System.Windows.Forms.Button btnWithdrawUser;
        private System.Windows.Forms.Button btnGiveFeedUser;
        private System.Windows.Forms.Button btnAmountWithInterestUser;
        private System.Windows.Forms.Button btnAmountWithLoanUser;
        private System.Windows.Forms.Button btnDepositUser;
        private System.Windows.Forms.Button btnBalanceUser;
        private System.Windows.Forms.Button btnUpPassUser;
        private System.Windows.Forms.Button btnGetLoanUser;
        private System.Windows.Forms.Button btnPayLoanUser;
        private System.Windows.Forms.Label lblUserMenu;
        private System.Windows.Forms.Button btnBackFromUser;
    }
}
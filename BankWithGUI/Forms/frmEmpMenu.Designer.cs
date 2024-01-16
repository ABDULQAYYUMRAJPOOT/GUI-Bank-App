namespace BankWithGUI.Forms
{
    partial class frmEmpMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpMenu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewAccountsEmp = new System.Windows.Forms.Button();
            this.btnAddUserEmp = new System.Windows.Forms.Button();
            this.btnRemoveAccountEmp = new System.Windows.Forms.Button();
            this.btnDepAmountEmp = new System.Windows.Forms.Button();
            this.btnSeeFeedEmp = new System.Windows.Forms.Button();
            this.btnBackFromEmpMenu = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnViewAccountsEmp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddUserEmp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveAccountEmp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDepAmountEmp, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSeeFeedEmp, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnBackFromEmpMenu, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnViewAccountsEmp
            // 
            this.btnViewAccountsEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewAccountsEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAccountsEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAccountsEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAccountsEmp.Location = new System.Drawing.Point(331, 101);
            this.btnViewAccountsEmp.Name = "btnViewAccountsEmp";
            this.btnViewAccountsEmp.Size = new System.Drawing.Size(138, 23);
            this.btnViewAccountsEmp.TabIndex = 0;
            this.btnViewAccountsEmp.Text = "View Total Accounts";
            this.btnViewAccountsEmp.UseVisualStyleBackColor = false;
            this.btnViewAccountsEmp.Click += new System.EventHandler(this.btnViewAccountsEmp_Click);
            // 
            // btnAddUserEmp
            // 
            this.btnAddUserEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUserEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUserEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUserEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserEmp.Location = new System.Drawing.Point(331, 146);
            this.btnAddUserEmp.Name = "btnAddUserEmp";
            this.btnAddUserEmp.Size = new System.Drawing.Size(138, 23);
            this.btnAddUserEmp.TabIndex = 2;
            this.btnAddUserEmp.Text = "Add User";
            this.btnAddUserEmp.UseVisualStyleBackColor = false;
            this.btnAddUserEmp.Click += new System.EventHandler(this.btnAddAccountEmp_Click);
            // 
            // btnRemoveAccountEmp
            // 
            this.btnRemoveAccountEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveAccountEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveAccountEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAccountEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAccountEmp.Location = new System.Drawing.Point(331, 191);
            this.btnRemoveAccountEmp.Name = "btnRemoveAccountEmp";
            this.btnRemoveAccountEmp.Size = new System.Drawing.Size(138, 23);
            this.btnRemoveAccountEmp.TabIndex = 1;
            this.btnRemoveAccountEmp.Text = "Remove Account";
            this.btnRemoveAccountEmp.UseVisualStyleBackColor = false;
            this.btnRemoveAccountEmp.Click += new System.EventHandler(this.btnRemoveAccountEmp_Click);
            // 
            // btnDepAmountEmp
            // 
            this.btnDepAmountEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDepAmountEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnDepAmountEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepAmountEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepAmountEmp.Location = new System.Drawing.Point(331, 236);
            this.btnDepAmountEmp.Name = "btnDepAmountEmp";
            this.btnDepAmountEmp.Size = new System.Drawing.Size(138, 23);
            this.btnDepAmountEmp.TabIndex = 3;
            this.btnDepAmountEmp.Text = "Deposit Amount in Account";
            this.btnDepAmountEmp.UseVisualStyleBackColor = false;
            this.btnDepAmountEmp.Click += new System.EventHandler(this.btnDepAmountEmp_Click);
            // 
            // btnSeeFeedEmp
            // 
            this.btnSeeFeedEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeeFeedEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnSeeFeedEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeFeedEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeFeedEmp.Location = new System.Drawing.Point(331, 281);
            this.btnSeeFeedEmp.Name = "btnSeeFeedEmp";
            this.btnSeeFeedEmp.Size = new System.Drawing.Size(138, 23);
            this.btnSeeFeedEmp.TabIndex = 5;
            this.btnSeeFeedEmp.Text = "See FeedBack ";
            this.btnSeeFeedEmp.UseVisualStyleBackColor = false;
            this.btnSeeFeedEmp.Click += new System.EventHandler(this.btnSeeFeedEmp_Click);
            // 
            // btnBackFromEmpMenu
            // 
            this.btnBackFromEmpMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromEmpMenu.Location = new System.Drawing.Point(62, 393);
            this.btnBackFromEmpMenu.Name = "btnBackFromEmpMenu";
            this.btnBackFromEmpMenu.Size = new System.Drawing.Size(75, 23);
            this.btnBackFromEmpMenu.TabIndex = 6;
            this.btnBackFromEmpMenu.Text = "Back";
            this.btnBackFromEmpMenu.UseVisualStyleBackColor = true;
            this.btnBackFromEmpMenu.Click += new System.EventHandler(this.btnBackFromEmpMenu_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Location = new System.Drawing.Point(261, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(277, 32);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Employee\'s Menu";
            // 
            // frmEmpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnViewAccountsEmp;
        private System.Windows.Forms.Button btnSeeFeedEmp;
        private System.Windows.Forms.Button btnAddUserEmp;
        private System.Windows.Forms.Button btnRemoveAccountEmp;
        private System.Windows.Forms.Button btnDepAmountEmp;
        private System.Windows.Forms.Button btnBackFromEmpMenu;
        private System.Windows.Forms.Label lblHeader;
    }
}
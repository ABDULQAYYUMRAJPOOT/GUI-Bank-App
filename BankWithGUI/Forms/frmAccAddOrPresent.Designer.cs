namespace BankWithGUI.Forms
{
    partial class frmAccAddOrPresent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccAddOrPresent));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAccountPresentOrAdd = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnPresentAccount = new System.Windows.Forms.Button();
            this.btnBackFromAddOrPresent = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.lblAccountPresentOrAdd, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddAccount, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPresentAccount, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBackFromAddOrPresent, 1, 3);
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
            // lblAccountPresentOrAdd
            // 
            this.lblAccountPresentOrAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountPresentOrAdd.AutoSize = true;
            this.lblAccountPresentOrAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountPresentOrAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountPresentOrAdd.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblAccountPresentOrAdd.Location = new System.Drawing.Point(267, 77);
            this.lblAccountPresentOrAdd.Name = "lblAccountPresentOrAdd";
            this.lblAccountPresentOrAdd.Size = new System.Drawing.Size(265, 25);
            this.lblAccountPresentOrAdd.TabIndex = 0;
            this.lblAccountPresentOrAdd.Text = "Add Or Present Account";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddAccount.Location = new System.Drawing.Point(342, 188);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(115, 28);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnPresentAccount
            // 
            this.btnPresentAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPresentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresentAccount.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnPresentAccount.Location = new System.Drawing.Point(324, 231);
            this.btnPresentAccount.Name = "btnPresentAccount";
            this.btnPresentAccount.Size = new System.Drawing.Size(151, 32);
            this.btnPresentAccount.TabIndex = 2;
            this.btnPresentAccount.Text = "Existing Account";
            this.btnPresentAccount.UseVisualStyleBackColor = true;
            this.btnPresentAccount.Click += new System.EventHandler(this.btnPresentAccount_Click);
            // 
            // btnBackFromAddOrPresent
            // 
            this.btnBackFromAddOrPresent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromAddOrPresent.BackColor = System.Drawing.Color.Black;
            this.btnBackFromAddOrPresent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackFromAddOrPresent.Location = new System.Drawing.Point(140, 348);
            this.btnBackFromAddOrPresent.Name = "btnBackFromAddOrPresent";
            this.btnBackFromAddOrPresent.Size = new System.Drawing.Size(80, 23);
            this.btnBackFromAddOrPresent.TabIndex = 3;
            this.btnBackFromAddOrPresent.Text = "Back";
            this.btnBackFromAddOrPresent.UseVisualStyleBackColor = false;
            this.btnBackFromAddOrPresent.Click += new System.EventHandler(this.btnBackFromAddOrPresent_Click);
            // 
            // frmAccAddOrPresent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccAddOrPresent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccAddOrPresent";
            this.Load += new System.EventHandler(this.frmAccAddOrPresent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAccountPresentOrAdd;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnPresentAccount;
        private System.Windows.Forms.Button btnBackFromAddOrPresent;
    }
}
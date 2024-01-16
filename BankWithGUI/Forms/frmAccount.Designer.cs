namespace BankWithGUI.Forms
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.btnChecking = new System.Windows.Forms.Button();
            this.btnSaving = new System.Windows.Forms.Button();
            this.btnBackFromAccountType = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblAccountType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChecking, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSaving, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBackFromAccountType, 0, 3);
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
            // lblAccountType
            // 
            this.lblAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountType.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAccountType.Location = new System.Drawing.Point(285, 74);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(230, 32);
            this.lblAccountType.TabIndex = 0;
            this.lblAccountType.Text = "Account Type";
            // 
            // btnChecking
            // 
            this.btnChecking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChecking.Location = new System.Drawing.Point(362, 191);
            this.btnChecking.Name = "btnChecking";
            this.btnChecking.Size = new System.Drawing.Size(75, 23);
            this.btnChecking.TabIndex = 1;
            this.btnChecking.Text = "Checking";
            this.btnChecking.UseVisualStyleBackColor = true;
            this.btnChecking.Click += new System.EventHandler(this.btnChecking_Click);
            // 
            // btnSaving
            // 
            this.btnSaving.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaving.Location = new System.Drawing.Point(362, 236);
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Size = new System.Drawing.Size(75, 23);
            this.btnSaving.TabIndex = 2;
            this.btnSaving.Text = "Saving";
            this.btnSaving.UseVisualStyleBackColor = true;
            this.btnSaving.Click += new System.EventHandler(this.btnSaving_Click);
            // 
            // btnBackFromAccountType
            // 
            this.btnBackFromAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromAccountType.Location = new System.Drawing.Point(42, 348);
            this.btnBackFromAccountType.Name = "btnBackFromAccountType";
            this.btnBackFromAccountType.Size = new System.Drawing.Size(75, 23);
            this.btnBackFromAccountType.TabIndex = 3;
            this.btnBackFromAccountType.Text = "Back";
            this.btnBackFromAccountType.UseVisualStyleBackColor = true;
            this.btnBackFromAccountType.Click += new System.EventHandler(this.btnBackFromAccountType_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Button btnChecking;
        private System.Windows.Forms.Button btnSaving;
        private System.Windows.Forms.Button btnBackFromAccountType;
    }
}
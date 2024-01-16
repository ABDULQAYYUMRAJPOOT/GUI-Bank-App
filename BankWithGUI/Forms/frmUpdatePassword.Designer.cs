namespace BankWithGUI.Forms
{
    partial class frmUpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePassword));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOldPassUser = new System.Windows.Forms.Label();
            this.lblNewPassUser = new System.Windows.Forms.Label();
            this.txtOldPassUser = new System.Windows.Forms.TextBox();
            this.txtNewPassUser = new System.Windows.Forms.TextBox();
            this.btnUpdateFinalUser = new System.Windows.Forms.Button();
            this.lblUpdateError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.375F));
            this.tableLayoutPanel1.Controls.Add(this.lblOldPassUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNewPassUser, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtOldPassUser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewPassUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateFinalUser, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblUpdateError, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOldPassUser
            // 
            this.lblOldPassUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOldPassUser.AutoSize = true;
            this.lblOldPassUser.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPassUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassUser.ForeColor = System.Drawing.Color.White;
            this.lblOldPassUser.Location = new System.Drawing.Point(115, 194);
            this.lblOldPassUser.Name = "lblOldPassUser";
            this.lblOldPassUser.Size = new System.Drawing.Size(151, 16);
            this.lblOldPassUser.TabIndex = 0;
            this.lblOldPassUser.Text = "Enter Old Password: ";
            // 
            // lblNewPassUser
            // 
            this.lblNewPassUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNewPassUser.AutoSize = true;
            this.lblNewPassUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassUser.ForeColor = System.Drawing.Color.White;
            this.lblNewPassUser.Location = new System.Drawing.Point(109, 239);
            this.lblNewPassUser.Name = "lblNewPassUser";
            this.lblNewPassUser.Size = new System.Drawing.Size(157, 16);
            this.lblNewPassUser.TabIndex = 1;
            this.lblNewPassUser.Text = "Enter New Password: ";
            // 
            // txtOldPassUser
            // 
            this.txtOldPassUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOldPassUser.Location = new System.Drawing.Point(272, 192);
            this.txtOldPassUser.Name = "txtOldPassUser";
            this.txtOldPassUser.Size = new System.Drawing.Size(223, 20);
            this.txtOldPassUser.TabIndex = 2;
            // 
            // txtNewPassUser
            // 
            this.txtNewPassUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNewPassUser.Location = new System.Drawing.Point(272, 237);
            this.txtNewPassUser.Name = "txtNewPassUser";
            this.txtNewPassUser.Size = new System.Drawing.Size(223, 20);
            this.txtNewPassUser.TabIndex = 3;
            // 
            // btnUpdateFinalUser
            // 
            this.btnUpdateFinalUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateFinalUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFinalUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateFinalUser.Location = new System.Drawing.Point(495, 347);
            this.btnUpdateFinalUser.Name = "btnUpdateFinalUser";
            this.btnUpdateFinalUser.Size = new System.Drawing.Size(79, 26);
            this.btnUpdateFinalUser.TabIndex = 4;
            this.btnUpdateFinalUser.Text = "Update";
            this.btnUpdateFinalUser.UseVisualStyleBackColor = true;
            this.btnUpdateFinalUser.Click += new System.EventHandler(this.btnUpdateFinalUser_Click);
            // 
            // lblUpdateError
            // 
            this.lblUpdateError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdateError.AutoSize = true;
            this.lblUpdateError.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateError.ForeColor = System.Drawing.Color.Red;
            this.lblUpdateError.Location = new System.Drawing.Point(9, 270);
            this.lblUpdateError.Name = "lblUpdateError";
            this.lblUpdateError.Size = new System.Drawing.Size(257, 32);
            this.lblUpdateError.TabIndex = 5;
            this.lblUpdateError.Text = "Enter correct old password and new password of length 8 or more!";
            this.lblUpdateError.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(272, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Change Password";
            // 
            // frmUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdatePassword";
            this.Load += new System.EventHandler(this.frmUpdatePassword_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOldPassUser;
        private System.Windows.Forms.Label lblNewPassUser;
        private System.Windows.Forms.TextBox txtOldPassUser;
        private System.Windows.Forms.TextBox txtNewPassUser;
        private System.Windows.Forms.Button btnUpdateFinalUser;
        private System.Windows.Forms.Label lblUpdateError;
        private System.Windows.Forms.Label label1;
    }
}
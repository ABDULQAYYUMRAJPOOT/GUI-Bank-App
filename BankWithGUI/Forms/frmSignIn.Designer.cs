namespace BankWithGUI.Forms
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSignInName = new System.Windows.Forms.Label();
            this.txtSignInName = new System.Windows.Forms.TextBox();
            this.txtSignInPassword = new System.Windows.Forms.TextBox();
            this.lblSignInPassword = new System.Windows.Forms.Label();
            this.btnSignInFinal = new System.Windows.Forms.Button();
            this.lblSignInError = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.625F));
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSignInName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSignInName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSignInPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSignInPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSignInFinal, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSignInError, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 1, 0);
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
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(120, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSignInName
            // 
            this.lblSignInName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSignInName.AutoSize = true;
            this.lblSignInName.BackColor = System.Drawing.Color.Transparent;
            this.lblSignInName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInName.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblSignInName.Location = new System.Drawing.Point(260, 194);
            this.lblSignInName.Name = "lblSignInName";
            this.lblSignInName.Size = new System.Drawing.Size(52, 16);
            this.lblSignInName.TabIndex = 0;
            this.lblSignInName.Text = "Name:";
            // 
            // txtSignInName
            // 
            this.txtSignInName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSignInName.Location = new System.Drawing.Point(318, 192);
            this.txtSignInName.Name = "txtSignInName";
            this.txtSignInName.Size = new System.Drawing.Size(212, 20);
            this.txtSignInName.TabIndex = 3;
            // 
            // txtSignInPassword
            // 
            this.txtSignInPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSignInPassword.Location = new System.Drawing.Point(318, 237);
            this.txtSignInPassword.Name = "txtSignInPassword";
            this.txtSignInPassword.Size = new System.Drawing.Size(212, 20);
            this.txtSignInPassword.TabIndex = 4;
            this.txtSignInPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSignInPassword
            // 
            this.lblSignInPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSignInPassword.AutoSize = true;
            this.lblSignInPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblSignInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInPassword.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblSignInPassword.Location = new System.Drawing.Point(233, 239);
            this.lblSignInPassword.Name = "lblSignInPassword";
            this.lblSignInPassword.Size = new System.Drawing.Size(79, 16);
            this.lblSignInPassword.TabIndex = 1;
            this.lblSignInPassword.Text = "Password:";
            // 
            // btnSignInFinal
            // 
            this.btnSignInFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignInFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignInFinal.Location = new System.Drawing.Point(520, 371);
            this.btnSignInFinal.Name = "btnSignInFinal";
            this.btnSignInFinal.Size = new System.Drawing.Size(75, 23);
            this.btnSignInFinal.TabIndex = 2;
            this.btnSignInFinal.Text = "Next";
            this.btnSignInFinal.UseVisualStyleBackColor = true;
            this.btnSignInFinal.Click += new System.EventHandler(this.btnSignInFinal_Click);
            // 
            // lblSignInError
            // 
            this.lblSignInError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignInError.AutoSize = true;
            this.lblSignInError.BackColor = System.Drawing.Color.Transparent;
            this.lblSignInError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSignInError.Location = new System.Drawing.Point(53, 284);
            this.lblSignInError.Name = "lblSignInError";
            this.lblSignInError.Size = new System.Drawing.Size(208, 16);
            this.lblSignInError.TabIndex = 5;
            this.lblSignInError.Text = "No Name or Password Fount!";
            this.lblSignInError.Visible = false;
            this.lblSignInError.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHeader.Location = new System.Drawing.Point(318, 74);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(140, 32);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "   Sign In";
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignIn";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSignInName;
        private System.Windows.Forms.Label lblSignInPassword;
        private System.Windows.Forms.Button btnSignInFinal;
        private System.Windows.Forms.TextBox txtSignInName;
        private System.Windows.Forms.TextBox txtSignInPassword;
        private System.Windows.Forms.Label lblSignInError;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeader;
    }
}
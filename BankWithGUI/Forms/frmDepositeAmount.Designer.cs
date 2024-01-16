namespace BankWithGUI.Forms
{
    partial class frmDepositeAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositeAmount));
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtDeposite = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeposit
            // 
            this.lblDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.BackColor = System.Drawing.Color.Transparent;
            this.lblDeposit.ForeColor = System.Drawing.Color.Silver;
            this.lblDeposit.Location = new System.Drawing.Point(261, 189);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(77, 13);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Enter Amount: ";
            // 
            // txtDeposite
            // 
            this.txtDeposite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDeposite.Location = new System.Drawing.Point(344, 186);
            this.txtDeposite.Name = "txtDeposite";
            this.txtDeposite.Size = new System.Drawing.Size(218, 20);
            this.txtDeposite.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.Location = new System.Drawing.Point(609, 358);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Next";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(376, 214);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(82, 13);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Invalid Input!";
            this.lblError.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Location = new System.Drawing.Point(193, 62);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(485, 32);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Enter Amount For Proceeding";
            // 
            // frmDepositeAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtDeposite);
            this.Controls.Add(this.lblDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepositeAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepositeAmount";
            this.Load += new System.EventHandler(this.frmDepositeAmount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDeposite;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblHeader;
    }
}
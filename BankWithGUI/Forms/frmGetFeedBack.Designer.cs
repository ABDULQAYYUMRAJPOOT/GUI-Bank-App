namespace BankWithGUI.Forms
{
    partial class frmGetFeedBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetFeedBack));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFeedError = new System.Windows.Forms.Label();
            this.lblFeed = new System.Windows.Forms.Label();
            this.btnFeedNext = new System.Windows.Forms.Button();
            this.btnFeedBack = new System.Windows.Forms.Button();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblFeedError, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFeed, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFeedNext, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFeedBack, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFeed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFeedError
            // 
            this.lblFeedError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFeedError.AutoSize = true;
            this.lblFeedError.BackColor = System.Drawing.Color.Transparent;
            this.lblFeedError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedError.ForeColor = System.Drawing.Color.Red;
            this.lblFeedError.Location = new System.Drawing.Point(380, 374);
            this.lblFeedError.Name = "lblFeedError";
            this.lblFeedError.Size = new System.Drawing.Size(39, 16);
            this.lblFeedError.TabIndex = 6;
            this.lblFeedError.Text = "Error!";
            this.lblFeedError.Visible = false;
            // 
            // lblFeed
            // 
            this.lblFeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFeed.AutoSize = true;
            this.lblFeed.BackColor = System.Drawing.Color.Transparent;
            this.lblFeed.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFeed.Location = new System.Drawing.Point(315, 51);
            this.lblFeed.Name = "lblFeed";
            this.lblFeed.Size = new System.Drawing.Size(170, 32);
            this.lblFeed.TabIndex = 1;
            this.lblFeed.Text = "FeedBack";
            // 
            // btnFeedNext
            // 
            this.btnFeedNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeedNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedNext.Location = new System.Drawing.Point(682, 371);
            this.btnFeedNext.Name = "btnFeedNext";
            this.btnFeedNext.Size = new System.Drawing.Size(75, 23);
            this.btnFeedNext.TabIndex = 2;
            this.btnFeedNext.Text = "Next";
            this.btnFeedNext.UseVisualStyleBackColor = true;
            this.btnFeedNext.Click += new System.EventHandler(this.btnFeedNext_Click);
            // 
            // btnFeedBack
            // 
            this.btnFeedBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedBack.Location = new System.Drawing.Point(42, 371);
            this.btnFeedBack.Name = "btnFeedBack";
            this.btnFeedBack.Size = new System.Drawing.Size(75, 23);
            this.btnFeedBack.TabIndex = 3;
            this.btnFeedBack.Text = "Back";
            this.btnFeedBack.UseVisualStyleBackColor = true;
            // 
            // txtFeed
            // 
            this.txtFeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeed.Location = new System.Drawing.Point(170, 214);
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.Size = new System.Drawing.Size(459, 22);
            this.txtFeed.TabIndex = 4;
            this.txtFeed.TextChanged += new System.EventHandler(this.txtFeed_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(47, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter FeedBack: ";
            // 
            // frmGetFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGetFeedBack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGetFeedBack";
            this.Load += new System.EventHandler(this.frmGetFeedBack_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFeed;
        private System.Windows.Forms.Button btnFeedNext;
        private System.Windows.Forms.Button btnFeedBack;
        private System.Windows.Forms.TextBox txtFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFeedError;
    }
}
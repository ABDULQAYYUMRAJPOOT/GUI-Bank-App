namespace BankWithGUI.Forms
{
    partial class frmIDInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIDInput));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdInpute = new System.Windows.Forms.Label();
            this.txtIDInput = new System.Windows.Forms.TextBox();
            this.lblIDHeader = new System.Windows.Forms.Label();
            this.btnBackFromIDInput = new System.Windows.Forms.Button();
            this.btnIDFinal = new System.Windows.Forms.Button();
            this.lblIdInputError = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.lblIdInpute, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIDInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIDHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBackFromIDInput, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnIDFinal, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIdInputError, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblIdInpute
            // 
            this.lblIdInpute.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIdInpute.AutoSize = true;
            this.lblIdInpute.BackColor = System.Drawing.Color.Transparent;
            this.lblIdInpute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInpute.ForeColor = System.Drawing.Color.Silver;
            this.lblIdInpute.Location = new System.Drawing.Point(177, 217);
            this.lblIdInpute.Name = "lblIdInpute";
            this.lblIdInpute.Size = new System.Drawing.Size(60, 16);
            this.lblIdInpute.TabIndex = 0;
            this.lblIdInpute.Text = "Enter ID: ";
            // 
            // txtIDInput
            // 
            this.txtIDInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDInput.Location = new System.Drawing.Point(243, 215);
            this.txtIDInput.Name = "txtIDInput";
            this.txtIDInput.Size = new System.Drawing.Size(244, 20);
            this.txtIDInput.TabIndex = 1;
            // 
            // lblIDHeader
            // 
            this.lblIDHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDHeader.AutoSize = true;
            this.lblIDHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblIDHeader.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIDHeader.Location = new System.Drawing.Point(333, 74);
            this.lblIDHeader.Name = "lblIDHeader";
            this.lblIDHeader.Size = new System.Drawing.Size(134, 32);
            this.lblIDHeader.TabIndex = 2;
            this.lblIDHeader.Text = "ID Input";
            // 
            // btnBackFromIDInput
            // 
            this.btnBackFromIDInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFromIDInput.Location = new System.Drawing.Point(82, 348);
            this.btnBackFromIDInput.Name = "btnBackFromIDInput";
            this.btnBackFromIDInput.Size = new System.Drawing.Size(75, 23);
            this.btnBackFromIDInput.TabIndex = 3;
            this.btnBackFromIDInput.Text = "Back";
            this.btnBackFromIDInput.UseVisualStyleBackColor = true;
            this.btnBackFromIDInput.Click += new System.EventHandler(this.btnBackFromIDInput_Click);
            // 
            // btnIDFinal
            // 
            this.btnIDFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIDFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIDFinal.Location = new System.Drawing.Point(642, 348);
            this.btnIDFinal.Name = "btnIDFinal";
            this.btnIDFinal.Size = new System.Drawing.Size(75, 23);
            this.btnIDFinal.TabIndex = 4;
            this.btnIDFinal.Text = "Next";
            this.btnIDFinal.UseVisualStyleBackColor = true;
            this.btnIDFinal.Click += new System.EventHandler(this.btnIDFinal_Click);
            // 
            // lblIdInputError
            // 
            this.lblIdInputError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIdInputError.AutoSize = true;
            this.lblIdInputError.BackColor = System.Drawing.Color.Transparent;
            this.lblIdInputError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInputError.ForeColor = System.Drawing.Color.Red;
            this.lblIdInputError.Location = new System.Drawing.Point(563, 217);
            this.lblIdInputError.Name = "lblIdInputError";
            this.lblIdInputError.Size = new System.Drawing.Size(85, 16);
            this.lblIdInputError.TabIndex = 5;
            this.lblIdInputError.Text = "No ID Found!";
            this.lblIdInputError.Visible = false;
            // 
            // frmIDInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIDInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChecking";
            this.Load += new System.EventHandler(this.frmIDInput_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIdInpute;
        private System.Windows.Forms.TextBox txtIDInput;
        private System.Windows.Forms.Label lblIDHeader;
        private System.Windows.Forms.Button btnBackFromIDInput;
        private System.Windows.Forms.Button btnIDFinal;
        private System.Windows.Forms.Label lblIdInputError;
    }
}
﻿namespace EasyfisInnosoftPOSIntegrator
{
    partial class DiscountDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountDetailForm));
            this.pnlHeaderTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseLogin = new System.Windows.Forms.Button();
            this.btnSaveDiscount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.cboMapDiscount = new System.Windows.Forms.ComboBox();
            this.pnlHeaderTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderTitle
            // 
            this.pnlHeaderTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeaderTitle.Controls.Add(this.pictureBox1);
            this.pnlHeaderTitle.Controls.Add(this.label1);
            this.pnlHeaderTitle.Location = new System.Drawing.Point(3, 0);
            this.pnlHeaderTitle.Name = "pnlHeaderTitle";
            this.pnlHeaderTitle.Size = new System.Drawing.Size(585, 57);
            this.pnlHeaderTitle.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discount";
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCloseLogin.FlatAppearance.BorderSize = 0;
            this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLogin.ForeColor = System.Drawing.Color.White;
            this.btnCloseLogin.Location = new System.Drawing.Point(402, 189);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(168, 51);
            this.btnCloseLogin.TabIndex = 49;
            this.btnCloseLogin.Text = "Close";
            this.btnCloseLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseLogin.UseVisualStyleBackColor = false;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // btnSaveDiscount
            // 
            this.btnSaveDiscount.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveDiscount.FlatAppearance.BorderSize = 0;
            this.btnSaveDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDiscount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDiscount.ForeColor = System.Drawing.Color.White;
            this.btnSaveDiscount.Location = new System.Drawing.Point(228, 189);
            this.btnSaveDiscount.Name = "btnSaveDiscount";
            this.btnSaveDiscount.Size = new System.Drawing.Size(168, 51);
            this.btnSaveDiscount.TabIndex = 48;
            this.btnSaveDiscount.Text = "Save";
            this.btnSaveDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveDiscount.UseVisualStyleBackColor = false;
            this.btnSaveDiscount.Click += new System.EventHandler(this.btnSaveDiscount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Map Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(12, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "Discount";
            // 
            // cboDiscount
            // 
            this.cboDiscount.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Location = new System.Drawing.Point(167, 90);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(403, 29);
            this.cboDiscount.TabIndex = 50;
            // 
            // cboMapDiscount
            // 
            this.cboMapDiscount.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cboMapDiscount.FormattingEnabled = true;
            this.cboMapDiscount.Location = new System.Drawing.Point(167, 124);
            this.cboMapDiscount.Name = "cboMapDiscount";
            this.cboMapDiscount.Size = new System.Drawing.Size(403, 29);
            this.cboMapDiscount.TabIndex = 51;
            // 
            // DiscountDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.cboMapDiscount);
            this.Controls.Add(this.cboDiscount);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.btnSaveDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlHeaderTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "DiscountDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount Detail";
            this.pnlHeaderTitle.ResumeLayout(false);
            this.pnlHeaderTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseLogin;
        private System.Windows.Forms.Button btnSaveDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDiscount;
        private System.Windows.Forms.ComboBox cboMapDiscount;
    }
}
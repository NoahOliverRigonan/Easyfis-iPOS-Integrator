namespace EasyfisInnosoftPOSIntegrator
{
    partial class UnitDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitDetailForm));
            this.pnlHeaderTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMapUnit = new System.Windows.Forms.ComboBox();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.btnCloseLogin = new System.Windows.Forms.Button();
            this.btnSaveDiscount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.pnlHeaderTitle.TabIndex = 52;
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
            this.label1.Size = new System.Drawing.Size(70, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unit";
            // 
            // cboMapUnit
            // 
            this.cboMapUnit.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cboMapUnit.FormattingEnabled = true;
            this.cboMapUnit.Location = new System.Drawing.Point(167, 124);
            this.cboMapUnit.Name = "cboMapUnit";
            this.cboMapUnit.Size = new System.Drawing.Size(403, 29);
            this.cboMapUnit.TabIndex = 58;
            // 
            // cboUnit
            // 
            this.cboUnit.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(167, 90);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(403, 29);
            this.cboUnit.TabIndex = 57;
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
            this.btnCloseLogin.TabIndex = 56;
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
            this.btnSaveDiscount.TabIndex = 55;
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
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Map Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(12, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 53;
            this.label8.Text = "Unit";
            // 
            // UnitDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.pnlHeaderTitle);
            this.Controls.Add(this.cboMapUnit);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.btnSaveDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "UnitDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Detail";
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
        private System.Windows.Forms.ComboBox cboMapUnit;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Button btnCloseLogin;
        private System.Windows.Forms.Button btnSaveDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}
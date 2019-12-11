namespace DoAnUngDung
{
    partial class frmThemPhanKhoi
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
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoPK = new System.Windows.Forms.TextBox();
            this.lblSoPK = new System.Windows.Forms.Label();
            this.lblThemPK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(68, 169);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(64, 32);
            this.btnTroVe.TabIndex = 2;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(364, 169);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(182, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoPK
            // 
            this.txtSoPK.Location = new System.Drawing.Point(182, 102);
            this.txtSoPK.Name = "txtSoPK";
            this.txtSoPK.Size = new System.Drawing.Size(252, 22);
            this.txtSoPK.TabIndex = 1;
            // 
            // lblSoPK
            // 
            this.lblSoPK.AutoSize = true;
            this.lblSoPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPK.Location = new System.Drawing.Point(65, 107);
            this.lblSoPK.Name = "lblSoPK";
            this.lblSoPK.Size = new System.Drawing.Size(66, 20);
            this.lblSoPK.TabIndex = 29;
            this.lblSoPK.Text = "Số PK :";
            // 
            // lblThemPK
            // 
            this.lblThemPK.AutoSize = true;
            this.lblThemPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemPK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblThemPK.Location = new System.Drawing.Point(143, 26);
            this.lblThemPK.Name = "lblThemPK";
            this.lblThemPK.Size = new System.Drawing.Size(228, 31);
            this.lblThemPK.TabIndex = 27;
            this.lblThemPK.Text = "Thêm Phân Khối";
            // 
            // frmThemPhanKhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 274);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoPK);
            this.Controls.Add(this.lblSoPK);
            this.Controls.Add(this.lblThemPK);
            this.Name = "frmThemPhanKhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phân Khối";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoPK;
        private System.Windows.Forms.Label lblSoPK;
        private System.Windows.Forms.Label lblThemPK;
    }
}
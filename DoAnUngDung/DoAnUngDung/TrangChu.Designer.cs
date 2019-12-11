namespace DoAnUngDung
{
    partial class frmTrangChu
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
            this.btnQLXM = new System.Windows.Forms.Button();
            this.btnQLMX = new System.Windows.Forms.Button();
            this.btnQLHX = new System.Windows.Forms.Button();
            this.btnQLPK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQLXM
            // 
            this.btnQLXM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLXM.Location = new System.Drawing.Point(93, 79);
            this.btnQLXM.Name = "btnQLXM";
            this.btnQLXM.Size = new System.Drawing.Size(200, 42);
            this.btnQLXM.TabIndex = 1;
            this.btnQLXM.Text = "Quản Lý Xe Máy";
            this.btnQLXM.UseVisualStyleBackColor = true;
            this.btnQLXM.Click += new System.EventHandler(this.btnQLXM_Click);
            // 
            // btnQLMX
            // 
            this.btnQLMX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMX.Location = new System.Drawing.Point(333, 79);
            this.btnQLMX.Name = "btnQLMX";
            this.btnQLMX.Size = new System.Drawing.Size(200, 42);
            this.btnQLMX.TabIndex = 2;
            this.btnQLMX.Text = "Quản Lý Màu Xe";
            this.btnQLMX.UseVisualStyleBackColor = true;
            this.btnQLMX.Click += new System.EventHandler(this.btnQLMX_Click);
            // 
            // btnQLHX
            // 
            this.btnQLHX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHX.Location = new System.Drawing.Point(93, 160);
            this.btnQLHX.Name = "btnQLHX";
            this.btnQLHX.Size = new System.Drawing.Size(200, 42);
            this.btnQLHX.TabIndex = 3;
            this.btnQLHX.Text = "Quản Lý Hãng Xe";
            this.btnQLHX.UseVisualStyleBackColor = true;
            this.btnQLHX.Click += new System.EventHandler(this.btnQLHX_Click);
            // 
            // btnQLPK
            // 
            this.btnQLPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPK.Location = new System.Drawing.Point(333, 160);
            this.btnQLPK.Name = "btnQLPK";
            this.btnQLPK.Size = new System.Drawing.Size(200, 42);
            this.btnQLPK.TabIndex = 4;
            this.btnQLPK.Text = "Quản Lý Phân Khối";
            this.btnQLPK.UseVisualStyleBackColor = true;
            this.btnQLPK.Click += new System.EventHandler(this.btnQLPK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(445, 247);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 32);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(241, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trang Chủ";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQLPK);
            this.Controls.Add(this.btnQLMX);
            this.Controls.Add(this.btnQLHX);
            this.Controls.Add(this.btnQLXM);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLXM;
        private System.Windows.Forms.Button btnQLMX;
        private System.Windows.Forms.Button btnQLHX;
        private System.Windows.Forms.Button btnQLPK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}
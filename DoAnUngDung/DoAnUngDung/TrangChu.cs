using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnUngDung
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        
        private void btnQLXM_Click(object sender, EventArgs e)
        {
            
            frmQuanLyXeMay f = new frmQuanLyXeMay();
            this.Hide();
            f.Show();
        }

        private void btnQLMX_Click(object sender, EventArgs e)
        {
            frmQuanLyMauXe f = new frmQuanLyMauXe();
            this.Hide();
            f.Show();
        }

        private void btnQLHX_Click(object sender, EventArgs e)
        {
            frmQuanLyHangXe f = new frmQuanLyHangXe();
            this.Hide();
            f.Show();
        }

        private void btnQLPK_Click(object sender, EventArgs e)
        {
            frmQuanLyPhanKhoi f = new frmQuanLyPhanKhoi();
            this.Hide();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo : ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}

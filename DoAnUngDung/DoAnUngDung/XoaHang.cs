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
    public partial class frmXoaHang : Form
    {
        public frmXoaHang()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sTenHang = txtTenHang.Text;
            if (sTenHang != string.Empty)
            {
                if (xlCSDL.deleteHangXe(sTenHang) > 0)
                {
                    MessageBox.Show("Xóa hãng: " + sTenHang + " thành công !");
                    this.Hide();
                    frmQuanLyHangXe fTrangChu = new frmQuanLyHangXe();
                    fTrangChu.Show();
                }
                else
                {
                    MessageBox.Show("Không tồn tại hãng: " + sTenHang);
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmQuanLyHangXe f = new frmQuanLyHangXe();
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

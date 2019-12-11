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
    public partial class frmXoaMau : Form
    {
        public frmXoaMau()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmQuanLyMauXe f = new frmQuanLyMauXe();
            this.Hide();
            f.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sTenMau = txtTenMau.Text;
            if (sTenMau != string.Empty)
            {
                if (xlCSDL.deleteMauXe(sTenMau) > 0)
                {
                    MessageBox.Show("Xóa màu: " + sTenMau + " thành công !");
                    this.Hide();
                    frmQuanLyMauXe fTrangChu = new frmQuanLyMauXe();
                    fTrangChu.Show();
                }
                else
                {
                    MessageBox.Show("Không tồn tại màu: " + sTenMau);
                }
            }
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

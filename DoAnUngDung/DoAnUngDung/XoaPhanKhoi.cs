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
    public partial class frmXoaPhanKhoi : Form
    {
        public frmXoaPhanKhoi()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmQuanLyPhanKhoi f = new frmQuanLyPhanKhoi();
            this.Hide();
            f.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sSoPK = txtSoPK.Text;
            if (sSoPK != string.Empty)
            {
                if (xlCSDL.deletePhanKhoi(sSoPK) > 0)
                {
                    MessageBox.Show("Xóa phân khối: " + sSoPK + " thành công !");
                    this.Hide();
                    frmQuanLyPhanKhoi fTrangChu = new frmQuanLyPhanKhoi();
                    fTrangChu.Show();
                }
                else
                {
                    MessageBox.Show("Không tồn tại phân khối: " + sSoPK);
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

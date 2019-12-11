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
    public partial class frmXoaXe : Form
    {
        public frmXoaXe()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmQuanLyXeMay fQuaLy = new frmQuanLyXeMay();
            this.Hide();
            fQuaLy.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo : ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sTenXe = txtTenXe.Text;
            if(sTenXe!=string.Empty)
            {
                if(xlCSDL.deleteXeMay(sTenXe)>0)
                {
                    MessageBox.Show("Xóa xe: " + sTenXe + " thành công !");
                    this.Hide();
                    frmQuanLyXeMay fTrangChu = new frmQuanLyXeMay();
                    fTrangChu.Show();
                }
                else
                {
                    MessageBox.Show("Không tồn tại xe: " + sTenXe);
                }
            }
        }
    }
}

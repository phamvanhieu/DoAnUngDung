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
    public partial class frmThemHang : Form
    {
        public frmThemHang()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sTenHang = txtTenHang.Text;
            try
            {

                if (sTenHang != string.Empty)
                {

                    if (xlCSDL.insertHangXe(sTenHang) > 0)
                    {
                        MessageBox.Show("Thêm hãng: " + sTenHang + " thành công !");
                        this.Hide();
                        frmQuanLyHangXe fTrangChu = new frmQuanLyHangXe();
                        fTrangChu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Thêm hãng không thành công !");
                    }

                }
                else
                {
                    MessageBox.Show("Không được để các trường trống !");
                }


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi: " + ex);
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

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
    public partial class frmThemMau : Form
    {
        public frmThemMau()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sTenMau = txtTenMau.Text;
            try
            {

                if (sTenMau != string.Empty)
                {
                   
                    if (xlCSDL.insertMauXe(sTenMau) > 0)
                    {
                        MessageBox.Show("Thêm màu: " + sTenMau + " thành công !");
                        this.Hide();
                        frmQuanLyMauXe fTrangChu = new frmQuanLyMauXe();
                        fTrangChu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Thêm màu không thành công !");
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
            frmQuanLyMauXe f = new frmQuanLyMauXe();
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

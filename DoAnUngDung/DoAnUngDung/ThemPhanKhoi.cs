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
    public partial class frmThemPhanKhoi : Form
    {
        public frmThemPhanKhoi()
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
        //Kiem tra co phai la so:
        public bool kiemTraSo(string sChuoi)
        {
            if (sChuoi.Length > 0)
            {
                foreach (char c in sChuoi)
                {
                    if (!Char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo : ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sPhanKhoi = txtSoPK.Text;
            try
            {

                if (sPhanKhoi != string.Empty)
                {
                    if (kiemTraSo(sPhanKhoi) == true)
                    {

                        sPhanKhoi = int.Parse(txtSoPK.Text).ToString();
                        if (xlCSDL.insertPhanKhoi(sPhanKhoi) > 0)
                        {
                            MessageBox.Show("Thêm phân khối: " + sPhanKhoi + " thành công !");
                            this.Hide();
                            frmQuanLyPhanKhoi fTrangChu = new frmQuanLyPhanKhoi();
                            fTrangChu.Show();

                        }
                        else
                        {
                            MessageBox.Show("Thêm phân khối không thành công !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được nhập phân khối là chữ ! ");
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
    }
}

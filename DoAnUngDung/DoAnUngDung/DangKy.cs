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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string sUser = txtTenDangNhap.Text;
                string sPass = txtMatKhau.Text;
                string sRepass = txtNhapLaiMatKhau.Text;

                if (sUser != string.Empty && sPass != string.Empty && sRepass != string.Empty)
                {
                    if (sPass == sRepass)
                    {
                        if (xlCSDL.chekcUserByName(sUser) >0)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại !");
                        }
                        else
                        {
                            if (xlCSDL.insertUser(sUser, sPass) > 0)
                            {
                                this.Hide();
                                MessageBox.Show("Đăng Kí Tài Khoản "+sUser+" Thành Công Mời Bạn Đăng Nhập!");
                                frmDangNhap fDangNhap = new frmDangNhap();
                                fDangNhap.Show();
                            }
                            else
                            {
                                MessageBox.Show("Đăng Kí không thành công !");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng nhau !");
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống các trường ! ");
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi: " + ex);
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap fDangNhap = new frmDangNhap();
            fDangNhap.Show();
        }
    }
}

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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        //public static string ID = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sName = txtTenDangNhap.Text;
            string sPass = txtMatKhau.Text;
            string sId = "";
            if (rdbAdmin.Checked == true)
            {
                sId = xlCSDL.getAllId(txtTenDangNhap.Text, txtMatKhau.Text);
                if (sName != string.Empty && sPass != string.Empty)
                {
                    if (sId != String.Empty)
                    {
                        frmTrangChu fIn = new frmTrangChu();
                        fIn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài Khoản không tồn tại ! ");
                    }

                }
                else
                {
                    MessageBox.Show("Không được để trống các trường ! ");
                }
            }
            if(rdbUser.Checked==true)
            {
                sId = xlCSDL.getAllIdUser(txtTenDangNhap.Text, txtMatKhau.Text);
                if (sName != string.Empty && sPass != string.Empty)
                {
                    if (sId != String.Empty)
                    {
                        frmQuanLyXeMayUser fIn = new frmQuanLyXeMayUser();
                        fIn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài Khoản không tồn tại ! ");
                    }

                }
                else
                {
                    MessageBox.Show("Không được để trống các trường ! ");
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo : ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy fDangKy = new frmDangKy();
            this.Hide();
            fDangKy.Show();
        }
    }
}

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
    public partial class frmQuanLyHangXe : Form
    {
        public frmQuanLyHangXe()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemHang f = new frmThemHang();
            this.Hide();
            f.Show();
        }

        private void dgvHangXe_Click(object sender, EventArgs e)
        {
            int row = dgvHangXe.CurrentCell.RowIndex;
            txtMaHang.Text = dgvHangXe[0, row].Value.ToString();
            txtTenHang.Text = dgvHangXe[1, row].Value.ToString();
        }

        private void frmQuanLyHangXe_Load(object sender, EventArgs e)
        {
            dgvHangXe.DataSource = xlCSDL.getBangDanhSach("HANGXE");
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmTrangChu f = new frmTrangChu();
            this.Hide();
            f.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sMaHang = txtMaHang.Text;
            string sTenHang = txtTenHang.Text;
            try
            {

                if (sMaHang != string.Empty && sTenHang != string.Empty)
                {
                    if (xlCSDL.updateHangXe(sMaHang,sTenHang)>0)
                    {
                        MessageBox.Show("Sửa hãng: " + sTenHang + " thành công !");
                        this.Hide();
                        frmQuanLyHangXe fTrangChu = new frmQuanLyHangXe();
                        fTrangChu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công !");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmXoaHang f = new frmXoaHang();
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

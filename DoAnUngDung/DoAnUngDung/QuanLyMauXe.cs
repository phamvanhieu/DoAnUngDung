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
    public partial class frmQuanLyMauXe : Form
    {
        public frmQuanLyMauXe()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmTrangChu f = new frmTrangChu();
            this.Hide();
            f.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmXoaMau f = new frmXoaMau();
            this.Hide();
            f.Show();
        }

        private void dgvMauXe_Click(object sender, EventArgs e)
        {
            int row = dgvMauXe.CurrentCell.RowIndex;
            txtMaMau.Text = dgvMauXe[0, row].Value.ToString();
            txtTenMau.Text = dgvMauXe[1, row].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemMau f = new frmThemMau();
            this.Hide();
            f.Show();
        }

        private void frmQuanLyMauXe_Load(object sender, EventArgs e)
        {
            dgvMauXe.DataSource = xlCSDL.getBangDanhSach("MAUXE");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sMaMau = txtMaMau.Text;
            string sTenMau = txtTenMau.Text;
            try
            {

                if (sMaMau != string.Empty && sTenMau != string.Empty)
                {
                    if (xlCSDL.updateMauXe(sMaMau, sTenMau) > 0)
                    {
                        MessageBox.Show("Sửa màu : " + sTenMau + " thành công !");
                        this.Hide();
                        frmQuanLyMauXe fTrangChu = new frmQuanLyMauXe();
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

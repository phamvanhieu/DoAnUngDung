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
    public partial class frmQuanLyPhanKhoi : Form
    {
        public frmQuanLyPhanKhoi()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmTrangChu fTr = new frmTrangChu();
            this.Hide();
            fTr.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemPhanKhoi f = new frmThemPhanKhoi();
            this.Hide();
            f.Show();
        }

        private void dgvPhanKhoi_Click(object sender, EventArgs e)
        {
            int row = dgvPhanKhoi.CurrentCell.RowIndex;
            txtMaPK.Text = dgvPhanKhoi[0, row].Value.ToString();
            txtSoPK.Text = dgvPhanKhoi[1, row].Value.ToString();
        }

        private void frmQuanLyPhanKhoi_Load(object sender, EventArgs e)
        {
            dgvPhanKhoi.DataSource = xlCSDL.getBangDanhSach("PHANKHOI");
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sMaPK = txtMaPK.Text;
            string sSoPK = txtSoPK.Text;
            try
            {

                if (sMaPK != string.Empty && sSoPK != string.Empty)
                {
                    if (kiemTraSo(sSoPK) == true)
                    {

                        sSoPK = int.Parse(txtSoPK.Text).ToString();
                        if (xlCSDL.updatePhanKhoi(sMaPK, sSoPK) > 0)
                        {
                            MessageBox.Show("Sửa phân khối: " + sSoPK + " thành công !");
                            this.Hide();
                            frmQuanLyPhanKhoi fTrangChu = new frmQuanLyPhanKhoi();
                            fTrangChu.Show();

                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được nhập phân khối xe là chữ ! ");
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
            frmXoaPhanKhoi f = new frmXoaPhanKhoi();
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

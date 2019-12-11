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
    public partial class frmQuanLyXeMayUser : Form
    {
        public frmQuanLyXeMayUser()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo : ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void frmQuanLyXeMayUser_Load(object sender, EventArgs e)
        {
            dgvXeMay.DataSource = xlCSDL.getBangDanhSach("XEMAY");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sTimKiem = txtTimKiem.Text;
            try
            {
                if (sTimKiem != string.Empty)
                {

                    dgvXeMay.DataSource = xlCSDL.searchTenXe(sTimKiem);
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

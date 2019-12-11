using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnUngDung
{
    public partial class frmQuanLyXeMay : Form
    {
        public frmQuanLyXeMay()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        loadComBoBox conn = new loadComBoBox();
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter data;
        //Load du lieu vao cbb Phan Khoi:
        public void loadComboBoxPK()
        {
            con = conn.conDB();
            con.Open();
            cmd = new SqlCommand("select MAPK,SOPK from PHANKHOI;", con);
            data = new SqlDataAdapter(cmd);
            ds = new DataSet();
            data.Fill(ds, "PHANKHOI");
            cbbPhanKhoi.DataSource = ds.Tables[0];
            cbbPhanKhoi.DisplayMember = "SOPK";
            cbbPhanKhoi.ValueMember = "MAPK";
        }
        //Load du lieu vao cbb mauxe:
        public void loadComboBoxMX()
        {
            con = conn.conDB();
            con.Open();
            cmd = new SqlCommand("select MAMAU,TENMAU from MAUXE;", con);
            data = new SqlDataAdapter(cmd);
            ds = new DataSet();
            data.Fill(ds, "MAUXE");
            cbbMauXe.DataSource = ds.Tables[0];
            cbbMauXe.DisplayMember = "TENMAU";
            cbbMauXe.ValueMember = "MAMAU";
        }
        //Load du lieu vao cbb HangXe:
        public void loadComboBoxHX()
        {
            con = conn.conDB();
            con.Open();
            cmd = new SqlCommand("select MAHANG,TENHANG from HANGXE;", con);
            data = new SqlDataAdapter(cmd);
            ds = new DataSet();
            data.Fill(ds, "HANGXE");
            cbbHangXe.DataSource = ds.Tables[0];
            cbbHangXe.DisplayMember = "TENHANG";
            cbbHangXe.ValueMember = "MAHANG";
        }
        private void frmQuanLyXeMay_Load(object sender, EventArgs e)
        {
            
            dgvXeMay.DataSource = xlCSDL.getBangDanhSach("XEMAY");
            this.loadComboBoxPK();
            this.loadComboBoxMX();
            this.loadComboBoxHX();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemXe fThemXe = new frmThemXe();
            this.Hide();
            fThemXe.Show();
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
            string sMaXe = txtMaXe.Text;
            string sTenXe = txtTenXe.Text;
            string sPhanKhoi = cbbPhanKhoi.Text;
            string sMauXe = cbbMauXe.Text;
            string sHangXe = cbbHangXe.Text;
            string sNgaySX = mskNgaySX.Text;
            string sGiaXe = txtGia.Text;
            try
            {

                if (sMaXe!=string.Empty && sTenXe != string.Empty && sPhanKhoi != string.Empty && sMauXe != string.Empty && sHangXe != string.Empty && sNgaySX != string.Empty && txtGia.Text != string.Empty)
                {
                    if (kiemTraSo(sGiaXe) == true&& kiemTraSo(sPhanKhoi) == true)
                    {

                        sGiaXe = int.Parse(txtGia.Text).ToString();
                        sPhanKhoi= int.Parse(cbbPhanKhoi.Text).ToString();
                        if (xlCSDL.updateXeMay(sMaXe,sTenXe, sHangXe, sPhanKhoi, sMauXe, sGiaXe, sNgaySX) > 0)
                        {
                            MessageBox.Show("Sửa xe: " + sTenXe + " thành công !");
                            this.Hide();
                            frmQuanLyXeMay fTrangChu = new frmQuanLyXeMay();
                            fTrangChu.Show();

                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được nhập giá xe và phân khối xe là chữ ! ");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo : ", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        // Lay du lieu cua dong vua click chuot vao phan sua:
        private void dgvXeMay_Click(object sender, EventArgs e)
        {
            int row = dgvXeMay.CurrentCell.RowIndex;
            txtMaXe.Text = dgvXeMay[0, row].Value.ToString();
            txtTenXe.Text = dgvXeMay[1, row].Value.ToString();
            cbbHangXe.Text = dgvXeMay[2, row].Value.ToString();
            cbbPhanKhoi.Text = dgvXeMay[3, row].Value.ToString();
            cbbMauXe.Text = dgvXeMay[4, row].Value.ToString();
            txtGia.Text = dgvXeMay[5, row].Value.ToString();
            mskNgaySX.Text = dgvXeMay[6, row].Value.ToString();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmXoaXe fXoa = new frmXoaXe();
            this.Hide();
            fXoa.Show();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmTrangChu fIn = new frmTrangChu();
            this.Hide();
            fIn.Show();
        }

   
    }
}

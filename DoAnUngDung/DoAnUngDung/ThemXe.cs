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
    public partial class frmThemXe : Form
    {
        public frmThemXe()
        {
            InitializeComponent();
        }
        QLCSDL xlCSDL = new QLCSDL();
        loadComBoBox conn =new loadComBoBox();
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
            data.Fill(ds,"PHANKHOI");
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
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyXeMay fTrangChu = new frmQuanLyXeMay();
            fTrangChu.Show();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string sTenXe = txtTenXe.Text;
            string sPhanKhoi = cbbPhanKhoi.Text;
            string sMauXe = cbbMauXe.Text;
            string sHangXe = cbbHangXe.Text;
            string sNgaySX = mskNgaySX.Text;
            string sGiaXe = txtGia.Text;
            try
            {
                
                if (sTenXe != string.Empty && sPhanKhoi != string.Empty && sMauXe != string.Empty && sHangXe != string.Empty && sNgaySX != string.Empty && txtGia.Text != string.Empty)
                {
                    if (kiemTraSo(sGiaXe)==true && kiemTraSo(sPhanKhoi) == true)
                    {
                       
                        sGiaXe = int.Parse(txtGia.Text).ToString();
                        sPhanKhoi = int.Parse(cbbPhanKhoi.Text).ToString();
                        if (xlCSDL.insertXeMay(sTenXe, sHangXe, sPhanKhoi, sMauXe, sGiaXe, sNgaySX) > 0)
                        {
                            MessageBox.Show("Thêm xe: " + sTenXe + " thành công !");
                            this.Hide();
                            frmQuanLyXeMay fTrangChu = new frmQuanLyXeMay();
                            fTrangChu.Show();

                        }
                        else
                        {
                            MessageBox.Show("Thêm xe không thành công !");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo : ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void frmThemXe_Load(object sender, EventArgs e)
        {
            this.loadComboBoxPK();
            this.loadComboBoxMX();
            this.loadComboBoxHX();
        }
    }
}

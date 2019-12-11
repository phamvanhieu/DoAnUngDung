using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DoAnUngDung
{
    class QLCSDL
    {
        //Kết nối CSDL:
        SqlConnection connectionDB = new SqlConnection();
        public QLCSDL()
        {
            //Tạo connection:

            string sConnec = @"Data Source=DESKTOP-2HB2A7C\SQLEXPRESS;Initial Catalog=QLXeMay;Integrated Security=True";
            connectionDB.ConnectionString = sConnec;
            //Kết nối đến CSDL:
            try
            {
                connectionDB.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi" + ex.Message);
                connectionDB.Close();
            }
        }
        //Dang ki tai khoang cho bang admin:
        public int insertUser(string sUser,string sPass)
        {
            int nResult;
            string spName = "spInsertUser";
            SqlCommand cmdAdmin = new SqlCommand(spName, connectionDB);
            cmdAdmin.CommandType = CommandType.StoredProcedure;
            cmdAdmin.Parameters.AddWithValue("@USERNAME", sUser);
            cmdAdmin.Parameters.AddWithValue("@PASSWORDS", sPass);
            if(cmdAdmin.ExecuteNonQuery()>0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Them vao bang xe may:
        public int insertXeMay(string sTenXe, string sHangXe, string sPhanKhoi, string sMauXe, string sGiaXe, string sNgaySX)
        {
            int nResult;
            string spName = "spInsertXeMay";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENXE", sTenXe);
            cmd.Parameters.AddWithValue("@HANGXE", sHangXe);
            cmd.Parameters.AddWithValue("@PHANKHOI", sPhanKhoi);
            cmd.Parameters.AddWithValue("@MAUXE", sMauXe);
            cmd.Parameters.AddWithValue("@GIAXE", sGiaXe);
            cmd.Parameters.AddWithValue("@NGAYSX", sNgaySX);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Them vao bang mau xe:
        public int insertMauXe(string sTenMau)
        {
            int nResult;
            string spName = "spInsertMauXessss";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENMAU", sTenMau);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Them vao bang phankhoi:
        public int insertPhanKhoi(string sPhanKhoi)
        {
            int nResult;
            string spName = "spInsertPhanKhoiss";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOPK", sPhanKhoi);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Them vao bang hangxe:
        public int insertHangXe(string sTenHang)
        {
            int nResult;
            string spName = "spInsertHangXess";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENHANG", sTenHang);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Sua du lieu bang xe may:

        public int updateXeMay(string sMaXe, string sTenXe, string sHangXe, string sPhanKhoi, string sMauXe, string sGiaXe, string sNgaySX)
        {
            int nResult;
            string spName = "spUptateXeMaysss";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAXE", sMaXe);
            cmd.Parameters.AddWithValue("@TENXE", sTenXe);
            cmd.Parameters.AddWithValue("@HANGXE", sHangXe);
            cmd.Parameters.AddWithValue("@PHANKHOI", sPhanKhoi);
            cmd.Parameters.AddWithValue("@MAUXE", sMauXe);
            cmd.Parameters.AddWithValue("@GIAXE", sGiaXe);
            cmd.Parameters.AddWithValue("@NGAYSX", sNgaySX);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Sua du lieu bang HANGXE:

        public int updateHangXe(string sMaHang, string sTenHang)
        {
            int nResult;
            string spName = "spUptateHangXe";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHANG", sMaHang);
            cmd.Parameters.AddWithValue("@TENHANG", sTenHang);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Sua du lieu bang MAUXE:

        public int updateMauXe(string sMaMau, string sTenMau)
        {
            int nResult;
            string spName = "spUptateMauXe";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAMAU", sMaMau);
            cmd.Parameters.AddWithValue("@TENMAU", sTenMau);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Sua du lieu bang PHANKHOI:

        public int updatePhanKhoi(string sMaPK, string sSoPK)
        {
            int nResult;
            string spName = "spUptatePhanKhoi";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPK", sMaPK);
            cmd.Parameters.AddWithValue("@SOPK", sSoPK);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Xoa du lieu bang xe may:
        public int deleteXeMay(string sTenXe)
        {
            int nResult;
            string spName = "spDeleteXeMay";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENXE", sTenXe);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Xoa du lieu bang PHANKHOI:
        public int deletePhanKhoi(string sSoPK)
        {
            int nResult;
            string spName = "spDeletePhanKhoi";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOPK", sSoPK);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Xoa du lieu bang HANGXE:
        public int deleteHangXe(string sTenHang)
        {
            int nResult;
            string spName = "spDeleteHangXe";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENHANG", sTenHang);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }
        //Xoa du lieu bang MAUXE:
        public int deleteMauXe(string sTenMau)
        {
            int nResult;
            string spName = "spDeleteMauXe";
            SqlCommand cmd = new SqlCommand(spName, connectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENMAU", sTenMau);
            if (cmd.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;
        }

        //Tim kiem theo tenxe bang XeMay:
        public DataTable searchTenXe(string sTenXe)
        {
            DataTable dt = null;
            try
            {
                SqlCommand cmd = new SqlCommand("spSearchTenXesss", connectionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TENXE", sTenXe);
                dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(dt);
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi" + ex.Message);
            }
            return dt;
        }
        //Kiem tra tai khoan trong bang user:
        public int chekcUserByName(string sUser)
        {
            int nResult; 
            string spName = "spCheckAdminByNames";
            SqlCommand cmdAdmin = new SqlCommand(spName, connectionDB);
            cmdAdmin.CommandType = CommandType.StoredProcedure;
            cmdAdmin.Parameters.AddWithValue("@USERNAME", sUser);
            if (cmdAdmin.ExecuteNonQuery() > 0)
            {
                nResult = 1;
            }
            else
            {
                nResult = 0;
            }
            return nResult;

        }
        //Kiem tra tai khoan mat khau de dang nhap admin:
        public string getAllId(string sUser,string sPass)
        {
            string id = "";
            try
            {
                SqlCommand cmdAdmin = new SqlCommand("SELECT * FROM ADMINS WHERE USERNAME='"+sUser+"' AND PASSWORDS='"+sPass+"'", connectionDB);
                SqlDataAdapter data = new SqlDataAdapter(cmdAdmin);
                DataTable dt = new DataTable();
                data.Fill(dt);
                if(dt!=null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        id = dr["ID"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi" + ex.Message);
            }
           
            return id;
        }
        //Kiem tra tai khoan mat khau de dang nhap user:
        public string getAllIdUser(string sUser, string sPass)
        {
            string id = "";
            try
            {
                SqlCommand cmdAdmin = new SqlCommand("SELECT * FROM USERS WHERE USERNAME='" + sUser + "' AND PASSWORDS='" + sPass + "'", connectionDB);
                SqlDataAdapter data = new SqlDataAdapter(cmdAdmin);
                DataTable dt = new DataTable();
                data.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["ID"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi" + ex.Message);
            }

            return id;
        }

        public DataTable getBangDanhSach(string sNameTable)
        {
            DataTable dt = null;
            try
            {
                SqlCommand cmd = new SqlCommand("spGetDaTaTable", connectionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameTable", sNameTable);
                dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(dt);
            }
            catch(SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi" + ex.Message);
            }
            return dt;
        }
        
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace DoAnUngDung
{
    class loadComBoBox
    {
        public SqlConnection conDB()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2HB2A7C\SQLEXPRESS;Initial Catalog=QLXeMay;Integrated Security=True");
            return con;
        }
    }
}

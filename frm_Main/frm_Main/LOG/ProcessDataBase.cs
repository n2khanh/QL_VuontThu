using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Main
{
    public class ProcessDataBase
    {
        //static string strConnect = "Data Source=DESKTOP-P86AVM7\\SQLEXPRESS;Initial Catalog=QLVuonThu;Integrated Security=True";
        static string strConnect = @"Data Source=LAPTOP-MS5K6CGT;Initial Catalog=QLVuonThu;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlConnect = null;
        //Hàm mở kết nối CSDL
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnect);
        }

        public void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }//Hàm đóng kết nối CSDL
        public void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }
        //Hàm thực thi câu lệnh dạng Select trả về một DataTable
        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqldataAdapte = new SqlDataAdapter(sql,
            sqlConnect);
            sqldataAdapte.Fill(dtBang);
            DongKetNoiCSDL();
            return dtBang;
        }
        //Hàm thực lệnh insert hoặc update hoặc delete
        public void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnect;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
    }
}

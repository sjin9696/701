using System;
using System.Data;
using System.Data.SqlClient;

namespace Storagy
{
    public class mssqlDataManager
    {
        public DataSet ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();

            // DB 접속정보 & 적용
            conn.ConnectionString = "Server=192.168.0.12; database=wjh; uid=sa; pwd=1234; ";
            conn.Open();
            sqlcmd.Connection = conn;  //쿼리 날릴곳은 conn, 즉 아까 연결한 DB
            sqlcmd.CommandText = "select * from dbo.storage_db";

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            sqlcmd.Connection.Close();
            conn.Close();

            return ds;
        }
    }
}

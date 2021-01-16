using System;
using System.Data.SqlClient;

namespace Storagy
{

    public class mssqlDataManager
    {
        public void ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();

            // DB 접속정보 & 적용
            conn.ConnectionString = "Server=192.168.0.12; database=wjh; uid=sa; pwd=1234; ";
            conn.Open();
            sqlcmd.CommandText = "select * from dbo.a";
            sqlcmd.Connection = conn;  //쿼리 날릴곳은 conn, 즉 아까 연결한 DB
         
            SqlDataReader sd = sqlcmd.ExecuteReader();
            //쿼리 맵핑
            while (sd.Read())
            {
                Console.WriteLine(sd[0].ToString());
                Console.WriteLine(sd["aa"].ToString());
                Console.WriteLine(sd.Read());
            }
            sqlcmd.Connection.Close();
            conn.Close();
        }
    }
}

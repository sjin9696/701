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
        public DataSet SelectDB(string query)
        {
            SqlConnection conn = new SqlConnection();

            // DB 접속정보 & 적용
            conn.ConnectionString = "Server=192.168.0.12; database=wjh; uid=sa; pwd=1234; ";
            conn.Open();

            SqlCommand sqlcmd = new SqlCommand(query,conn);

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            sqlcmd.Connection.Close();
            conn.Close();

            return ds;
        }
        public void InsertDB(string query)
        {
            //MS-SQL 연결시 필수 클래스
            SqlConnection conn = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();

            string connStr = "Server=192.168.0.12;" + //; (세미콜론)필수!
                             "database = wjh;" + //데이터베이스 이름
                             "uid = sa;" + //접속 ID
                             "pwd = 1234;"; //접속 패스워드
            conn.ConnectionString = connStr;
            conn.Open(); //DB 접속

            string cmdText = string.Format(query);

            sqlcmd.Connection = conn;
            sqlcmd.CommandText = cmdText; // 쿼리문 날리기

            sqlcmd.ExecuteNonQuery(); //쿼리문 실행

            sqlcmd.Connection.Close();
            conn.Close();
        }
    }
}

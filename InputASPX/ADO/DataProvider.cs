using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InputASPX.ADO
{

    public class DataProvider
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Test;Integrated Security=True");
        public const string status = " WHERE status =0";
        public void Connect()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
        }

        public void DisConnect()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        //exc query
        public String SelectUseExeReader()
        {
            Connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbUser"+ status, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dtb = new DataTable();
            //đổ tất cả
            dtb.Load(reader);
            string dsUser = string.Empty;
            //Lập qua từng object lấy ra row
            foreach(DataRow row in dtb.Rows)
            {
                dsUser += row["username"].ToString() + "<br/>";
            }
            DisConnect();
            return dsUser;
        }

        public String SelectUseExeAdapter()
        {
            Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbUser"+ status, conn);
            DataTable dtb = new DataTable();
            //đổ tất cả
            adapter.Fill(dtb);
            string dsUser = string.Empty;
            //Lập qua từng row
            foreach (DataRow row in dtb.Rows)
            {
                dsUser += row["username"].ToString() + "<br/>";
            }
            DisConnect();
            return dsUser;
        }

        public int SelectUseExeScalar()
        {
            Connect();
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM tbUser"+status,conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            DisConnect();
            return result;
        }

        //no-excquery

        public int InsertUseExeNonquery(string username, string password)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbUser(username,password) VALUES('"+ username + "','"+ password + "')", conn);
            int result = cmd.ExecuteNonQuery();
            DisConnect();
            return result;
        }
        public int UpdateUseExeNonquery(int id,string username, string password)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("UPDATE tbUser SET username ='" + username + "',password ='" + password + "' WHERE id="+id, conn);
            //trả về số dòng tác động =0 không có dòng nào , 
            int result = cmd.ExecuteNonQuery();
            DisConnect();
            return result;
        }

        public int DeleteUseExeNonquery(int id)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("UPDATE tbUser SET status =1  WHERE id=" + id, conn);
            //trả về số dòng tác động =0 không có dòng nào , 
            int result = cmd.ExecuteNonQuery();
            DisConnect();
            return result;
        }

       


        //kèm tham số.
        public int DeleteUseExeNonqueryParam(int id)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE tbUser SET status =1  WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            //trả về số dòng tác động =0 không có dòng nào , 
            int result = cmd.ExecuteNonQuery();
            DisConnect();
            return result;
        }
    }
}
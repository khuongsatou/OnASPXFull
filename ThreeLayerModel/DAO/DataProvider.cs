using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        
        public static SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=WebBanHang;Integrated Security=True");
        public static SqlDataAdapter adapter = new SqlDataAdapter();

        public DataProvider() { }


        private static SqlConnection OpenConnection()
        {
            if(conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        private static void Disconnection()
        {
            if (conn.State != ConnectionState.Closed || conn.State != ConnectionState.Broken)
            {
                conn.Close();
            }
          
        }

        public static DataTable ExecuteSelectQuery(string query,SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dtbKetQua = new DataTable();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(param);
                adapter.SelectCommand = cmd;
                adapter.Fill(dtbKetQua);
                Disconnection();
            }
            catch (Exception)
            {

                return null;
            }
            return dtbKetQua;
        }

        public static int ExecuteInsertQuery(string query, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            int rowsAffected;
            DataTable dtbKetQua = new DataTable();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(param);
                adapter.InsertCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                Disconnection();
            }
            catch (Exception)
            {

                return 0;
            }
            return rowsAffected;
        }

        public static int ExecuteUpdateQuery(string query, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            int rowsAffected;
            DataTable dtbKetQua = new DataTable();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(param);
                adapter.InsertCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                Disconnection();
            }
            catch (Exception)
            {

                return 0;
            }
            return rowsAffected;
        }

        public static int ExecuteDeleteQuery(string query, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            int rowsAffected;
            DataTable dtbKetQua = new DataTable();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(param);
                adapter.DeleteCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                Disconnection();
            }
            catch (Exception)
            {

                return 0;
            }
            return rowsAffected;
        }
    }
}

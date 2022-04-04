using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Collections;
namespace DAL
{
    class SQLConnect 
    {
        public static SqlConnection connect()
        {
            string strCon = @"Server=.;Database=QLBH;Integrated Security=true";
            return new SqlConnection(strCon);
        }
    }
    public class DataAccess
    {
        public SqlConnection conn = SQLConnect.connect();
        public Hashtable HashAccounts()
        {
            Hashtable ha = new Hashtable();
            DataTable dt = selectData("TAI_KHOAN");
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                ha.Add(dt.Rows[i]["Username"], dt.Rows[i]["Password"]);
            }
            return ha;
        }
        public string CheckLogin(LoginProps props)
        {
            string user = null;
            SqlCommand cmd = new SqlCommand("PROC_LOGIN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERN", props.username);
            cmd.Parameters.AddWithValue("@PASS", props.password);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                cmd.Connection.Close();
            }
            else user = "US-O-PA-WRO";
            cmd.Connection.Close();
            return user;
        }
        public DataTable selectData(string tableName)
        {
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM " + tableName, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
    }
}

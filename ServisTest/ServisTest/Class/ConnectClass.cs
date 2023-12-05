using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace ServisTest.Class
{
    class ConnectClass
    {
        string vStrConnection = "Server=localhost; port=5432; user id=postgres; password=Kira3004! ; database=ServTest2 ;";
        public NpgsqlConnection vCon;
        NpgsqlCommand vCmd;
        public void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;
            
            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }

        }

        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            connection();
            vCmd = new NpgsqlCommand();
            vCmd.Connection = vCon;
            vCmd.CommandText = sql;

            using (NpgsqlDataReader dr = vCmd.ExecuteReader())
            {
                dt.Load(dr);
            }
            return dt;
        }

        public DataTable getmultidata(NpgsqlCommand cmd)
        {
            DataTable dt = new DataTable();
            connection();
            cmd.Connection = vCon;

            using (NpgsqlDataReader dr = cmd.ExecuteReader())
            {
                dt.Load(dr);
            }

            return dt;
        }
        public String getpassword(NpgsqlCommand sql)
        {
            DataTable dt = new DataTable();
            connection();
            vCmd = sql;
            vCmd.Connection = vCon;

            NpgsqlDataReader dr = vCmd.ExecuteReader();
            if (dr.HasRows) 
            {
                while (dr.Read())
                {
                    var a = dr.GetValue(0).ToString();
                   
                    return a;
                }
            }
            return "";
            
        }
        public String getfio(NpgsqlCommand sql)
        {
            DataTable dt = new DataTable();
            connection();
            vCmd = sql;
            vCmd.Connection = vCon;

            NpgsqlDataReader dr = vCmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var a = dr.GetValue(0).ToString();
                    var b = dr.GetValue(1).ToString();
                    var c = dr.GetValue(2).ToString();
                    var fio = a +' ' +  b +' '+ c;
                    return fio;
                }
            }
            return "";

        }

        
    }
}

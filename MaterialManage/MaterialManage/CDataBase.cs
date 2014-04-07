using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MaterialManage
{
    class CDataBase
    {
        private SqlDataAdapter da;
        private SqlConnection conn;
        private SqlCommand cmd;
        static private string StrConn = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public string GetConnStr()
        {
            return StrConn;
        }

        /// <summary>
        /// 返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet Search(string sql)
        {
            conn = new SqlConnection(StrConn);
            conn.Open();
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        /// <summary>
        /// 执行Sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool Cmd(string sql)
        {
            conn = new SqlConnection(StrConn);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public string CountM(string sql)
        {
            string count;
            conn = new SqlConnection(StrConn);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
                count = sdr[0].ToString();
            else
                count = "0";
            return count;
        }

        /// <summary>
        /// 返回需要的列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public List<string> SearchL(string sql, string str)
        {
            List<string> L = new List<string>();
            conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                L.Add(sdr[str].ToString());
            }
            conn.Close();
            return L;
        }

        /// <summary>
        /// 返回第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<string> SearchL(string sql)
        {
            List<string> L = new List<string>();
            conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                L.Add(sdr[0].ToString());
            }
            conn.Close();
            return L;
        }

        /// <summary>
        /// 返回某一行的前N列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public List<string> SearchCL(string sql, int N)
        {
            List<string> L = new List<string>();
            conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < N; i++)
                {
                    L.Add(sdr[i].ToString());
                }
            }
            conn.Close();
            return L;
        }

        /// <summary>
        /// 返回特定的列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        public void SearchDetail(string sql, ref string str1, ref string str2)
        {
            conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                str1 = sdr[str1].ToString();
                str2 = sdr[str2].ToString();
            }
            conn.Close();
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MaterialManage
{
     public class DBHelper
    {
       static private SqlDataAdapter da;
       static private SqlConnection conn;
       static private SqlCommand cmd;
       static private string StrConn = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
         
       public static string GetConnStr()
        {
            return StrConn;
        }

        /// <summary>
        /// 返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet Search(string sql)
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
        public static bool ExecuteNonQuery(string sql)
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
        /// <summary>
        /// 查看数据是否存在
        /// </summary>
        /// <param name="sql">select语句</param>
        /// <returns></returns>
        public static bool IsExist(string sql)
        {
            conn = new SqlConnection(StrConn);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteScalar()!=null)
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
        /// <summary>
        /// 此函数用于返回一个sqlDataReader
        /// </summary>
        /// <param name="sql">执行的sql语句</param>
        /// <returns>返回sqlDataReader对象</returns>
        public static SqlDataReader GetReader(string sql)
        {
            conn = new SqlConnection(StrConn);
            cmd = new SqlCommand(sql, conn);
            
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch
            {
                throw new ApplicationException("在与数据库连接或执行命令时出现了异常");
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 返回需要的列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static List<string> SearchL(string sql, string str)
        {
             List<string> L1 = new List<string>();
            conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                L1.Add(sdr[str].ToString());
            }
            conn.Close();
            return L1;
        }

        /// <summary>
        /// 返回第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static List<string> SearchL(string sql)
        {
            List<string> L1 = new List<string>();
            conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                L1.Add(sdr[0].ToString());
            }
            conn.Close();
            return L1;
        }

        /// <summary>
        /// 返回某一行的前N列 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public static List<string> SearchCL(string sql, int N)
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
        public static void SearchDetail(string sql, ref string str1, ref string str2)
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

        public static DataSet_Manage FillDsManage(string sql1, string TName1, string sql2, string TName2)
        {
            DataSet_Manage DS_Rpt = new DataSet_Manage();
            DS_Rpt.Tables[TName1].Clear();
            DS_Rpt.Tables[TName2].Clear();

            conn = new SqlConnection(StrConn);
            conn.Open();

            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DS_Rpt.EnforceConstraints = false;
            sda1.Fill(DS_Rpt, TName1);

            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            sda2.Fill(DS_Rpt, TName2);

            conn.Close();
            return DS_Rpt;
        }
    }
}

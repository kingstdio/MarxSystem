using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Marx
{
    class SQLHELPER
    {
        public static string connstr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public SQLHELPER()
        {
            connstr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        }

        #region 数据库连接测试
        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <returns>成功：true；失败：false</returns>
        public static bool dbTest()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                Debug.WriteLine("数据库连接成功");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("数据库连接失败，请检查网络连接状况" + ex.Message, "系统提示");
                return false;
            }
        }
        #endregion

        #region 执行非查询方法
        /// <summary>
        /// 执行非查询方法
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>执行结果</returns>
        public static int ExecuteNoneQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }


        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    return cmd.ExecuteReader();

                }
            }
        }







        #region 判断一个表是否存在
        /// <summary>
        /// 判断一个表是否存在
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>存在：true；不存在：false</returns>
        public static bool isTableExists(String tableName)
        {
            String sql = @"SELECT count(id) FROM sysobjects WHERE name = '" + tableName + "'";
            if (SQLHELPER.GetSingleResultInt(sql) < 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion

        #region 得到一个datatable
        /// <summary>
        /// 得到一个datatable
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>datatable</returns>
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }
        #endregion

        #region 获得一行数据
        /// <summary>
        /// 获得一行数据
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>DataRow</returns>
        public static DataRow ExecuteDataRow(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    if (dataset.Tables[0].Rows.Count > 0)
                    {
                        return dataset.Tables[0].Rows[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        #endregion

        #region 获得唯一结果
        /// <summary>
        /// 获得唯一结果String
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>结果（String类型）</returns>
        public static string GetSingleResultString(string sql, params SqlParameter[] parameters)
        {
            string result = null;
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = reader[0].ToString();
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 获得唯一结果Int
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>结果（Int类型）</returns>
        public static int GetSingleResultInt(string sql, params SqlParameter[] parameters)
        {
            int result = int.MinValue;
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = Convert.ToInt32(reader[0].ToString());
                        }
                    }
                }
            }
            return result;
        }
        #endregion
    }
}

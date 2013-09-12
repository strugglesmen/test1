using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HuiTu.Superman.DAL
{
    public class DbContext : IDbContext
    {
        /// <summary>
        /// 读取数据的连接字符串名
        /// </summary>
        private string ReadConnectionName { get; set; }
        /// <summary>
        /// 写入数据的连接字符串名
        /// </summary>
        private string WriteConnectionName { get; set; }
        /// <summary>
        /// 构建函数
        /// </summary>
        /// <param name="readConnectionName">读取数据的连接字符串名</param>
        /// <param name="writeConnectionName">写入数据的连接字符串名</param>
        public DbContext(string readConnectionName, string writeConnectionName)
        {
            ReadConnectionName = readConnectionName;
            WriteConnectionName = writeConnectionName;
        }
        /// <summary> 
        /// 读取配置文件数据库连接字符串
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public string GetConnectionString(string connectionName)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public void Write(Action<SqlConnection> action)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString(WriteConnectionName)))
            {
                conn.Open();
                action(conn);
                conn.Close();
            }
        }

        public T Write<T>(Func<SqlConnection, T> func)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString(WriteConnectionName)))
            {
                conn.Open();
                T value = func(conn);
                conn.Close();
                return value;
            }
        }

        public void Read(Action<SqlConnection> action, bool readNewest = false)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString(readNewest ? WriteConnectionName : ReadConnectionName)))
            {
                conn.Open();
                action(conn);
                conn.Close();
            }
        }

        public T Read<T>(Func<SqlConnection, T> func, bool readNewest = false)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString(readNewest ? WriteConnectionName : ReadConnectionName)))
            {
                conn.Open();
                T value = func(conn);
                conn.Close();
                return value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HuiTu.Superman.DAL
{
    public interface IDbContext
    {
        string GetConnectionString(string name);
        void Write(Action<SqlConnection> action);
        T Write<T>(Func<SqlConnection, T> func);
        void Read(Action<SqlConnection> action, bool readNewest = false);
        T Read<T>(Func<SqlConnection, T> func, bool readNewest = false);
    }
}

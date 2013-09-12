using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNet.Utilities;
using HuiTu.Superman.Model;
using HuiTu.Utilities;

namespace HuiTu.DataAccess.SqlServer
{
    public partial class DataProvider:IDataProvider
    {
        public User GetUserById(int userid)
        {
            string sqlQuery = @"select * from Ah_User where UserId = "+userid;
            var user = new User();
            using (var dr = DbHelper.ExecuteReader(ConnsConfigs.UserConn, sqlQuery))
            {
                while (dr.Read())
                {
                    user.Id = (int) dr["id"];
                }
            }
            return user;
        }
    }
     
}

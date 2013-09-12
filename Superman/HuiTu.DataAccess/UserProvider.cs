using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HuiTu.Superman.Model;

namespace HuiTu.DataAccess
{
    public interface IDataProvider
    {
        User GetUserById(int userId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HuiTu.Superman.DAL;

namespace HuiTu.Superman.Host.Web
{
    public class InjectionDal
    {
        public static void RegisterAll(Funq.Container container)
        {
            container.Register<IDbContext>(new DbContext("Read", "Write"));
        }
    }
}
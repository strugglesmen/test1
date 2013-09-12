using HuiTu.DataAccess.SqlServer;
using ServiceStack.WebHost.Endpoints;

namespace HuiTu.Superman.Host.Web
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("huitu service", typeof(object).Assembly)
        {

        }
        public override void Configure(Funq.Container container)
        {
            InjectionDal.RegisterAll(container);
        }
    }
}

using HuiTu.Superman.Model;
using ServiceStack.ServiceInterface;


namespace HuiTu.Superman.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : RestServiceBase<User>
    {
        public override object OnGet(User request)
        {
            return base.OnGet(request);
        }
    }
}

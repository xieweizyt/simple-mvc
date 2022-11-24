using Autofac.Extras.DynamicProxy;
using WebApplication1.Extend.AOP;

namespace WebApplication1.Service
{
    [Intercept(typeof(AOPByAutofac))]
    public class UserService : IUserService
    {
        public void GetUser()
        {
            
        }
    }
}

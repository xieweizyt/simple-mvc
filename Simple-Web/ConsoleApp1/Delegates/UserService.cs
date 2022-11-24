using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public class UserService : IUserService
    {
        public void Get()
        {
            // LogHelper.WriteLog("sssss");
            LogHelper.WriteLog("ssss", s =>
            {
                new LogService().Log(s);
            });
        }
    }
}

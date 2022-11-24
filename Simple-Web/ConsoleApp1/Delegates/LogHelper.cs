using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public class LogHelper
    {
        public static void WriteLog(string msg)
        {
            // 写入日志
        }

        public static void WriteLog(string msg, Action<string> action)
        {
            action(msg);
        }
    }
}

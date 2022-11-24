using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public class DelegateHostBuilder
    {
        public static DelegateHost BuildDelegateHost(Action<DelegateHostOption> action)
        {
            DelegateHost delegateHost = new DelegateHost();
            action.Invoke(delegateHost.Option);
            return delegateHost;
        }
    }
}

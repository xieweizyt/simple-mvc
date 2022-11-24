using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WebApplication1.Extend.HostingStartupExtend.CustomerHostingStartup))]
namespace WebApplication1.Extend.HostingStartupExtend
{
    /// <summary>
    /// 必须实现IHostingStartup接口
    /// 必须标记HostingStartup特性
    /// </summary>
   
    public class CustomerHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            Console.WriteLine("CustomerHostingStartup");
        }
    }
}

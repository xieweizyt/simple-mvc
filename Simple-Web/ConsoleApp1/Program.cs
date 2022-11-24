


using Castle.DynamicProxy;
using ConsoleApp1.Builders;
using ConsoleApp1.Delegates;
using ConsoleApp1.Interceptors;
using ConsoleApp1.Services;

#region 建造模式代码
{
    Computer computer1 = new Computer("I5", "16GB");
    Computer computer2 = new Computer("I5", "16GB", 2);
    Computer computer3 = new Computer("I5", "16GB", 2, "雷蛇");
}
{
    Computer computer1 = new Computer("I5", "16GB");
    computer1.SetUSBCount(2);
    computer1.SetKeyBoard("雷蛇");
}
{
    ComputerBuilder computerBuilder = new ComputerBuilder("I5", "16GB")
        .SetUSBCount(2)
        .SetKeyBoard("雷蛇");
    Computer computer = computerBuilder.Build();
}
#endregion


#region 委托初始化

{
    // 传统
    DelegateHost delegateHost = new DelegateHost();
    delegateHost.IsStop = true;
    delegateHost.Init1();
    delegateHost.Init2();
}
{
    DelegateHostBuilder.BuildDelegateHost(op =>
    {
        op.IsStop = true;
        op.Init1();
        op.Init2();
    });
}

#endregion


#region 委托分派

/// 存在对象LogHelper 专门用于记录日志
/// 存在对象Service 用于与数据库交互
/// 两者不在同一个类库，遇到读取数据库数据需要记录日志，然后日志需要写入数据库就会造成循环引用
/// 

new UserService().Get();

#endregion

{
    ProxyGenerator generator = new ProxyGenerator();
    CustomInterceptor interceptor = new CustomInterceptor();//自定义拦截器
    TestService testClass = generator.CreateClassProxy<TestService>(interceptor);
    testClass.Get();
}
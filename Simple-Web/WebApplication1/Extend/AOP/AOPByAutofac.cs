using Castle.DynamicProxy;

namespace WebApplication1.Extend.AOP
{
    public class AOPByAutofac : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed(); //继续执行
        }
    }
}

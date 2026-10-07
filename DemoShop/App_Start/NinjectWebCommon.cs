using System;
using System.Web;
using DemoShop.Infrastructure;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using Ninject.Web.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(DemoShop.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(DemoShop.App_Start.NinjectWebCommon), "Stop")]

namespace DemoShop.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);

            System.Web.Mvc.DependencyResolver.SetResolver(new Ninject.Web.Mvc.NinjectDependencyResolver(kernel));

            return kernel;
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IMailService>().To<HangFirePostalIMailService>().InRequestScope();
            kernel.Bind<InterfaceSessionManager>().To<SessionManager>().InRequestScope();
            kernel.Bind<InterfaceCacheProvider>().To<DefaultCacheProvider>().InRequestScope();

            kernel.Bind(typeof(System.Web.Mvc.IController)).ToSelf();
        }
    }
}

using System;
using System.Web;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using Northwind.Mvc;
using WebActivatorEx;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), nameof(NinjectWebCommon.Start))]
[assembly: ApplicationShutdownMethod(typeof(NinjectWebCommon), nameof(NinjectWebCommon.Stop))]

namespace Northwind.Mvc
{
   public static class NinjectWebCommon
   {
      private static readonly Bootstrapper _Bootstrapper = new Bootstrapper();

      /// <summary>
      ///    Starts the application
      /// </summary>
      public static void Start()
      {
         DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
         DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
         _Bootstrapper.Initialize(CreateKernel);
      }

      /// <summary>
      ///    Stops the application.
      /// </summary>
      public static void Stop()
      {
         _Bootstrapper.ShutDown();
      }

      /// <summary>
      ///    Creates the kernel that will manage your application.
      /// </summary>
      /// <returns>The created kernel.</returns>
      private static IKernel CreateKernel()
      {
         var kernel = new StandardKernel();
         try
         {
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            RegisterServices(kernel);
            return kernel;
         }
         catch
         {
            kernel.Dispose();
            throw;
         }
      }

      /// <summary>
      ///    Load your modules or register your services here!
      /// </summary>
      /// <param name="kernel">The kernel.</param>
      // ReSharper disable UnusedParameter.Local
      private static void RegisterServices(IKernel kernel)
         // ReSharper restore UnusedParameter.Local
      {
      }
   }
}
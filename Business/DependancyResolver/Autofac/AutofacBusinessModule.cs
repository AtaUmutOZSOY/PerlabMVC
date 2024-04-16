
using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System.Reflection;
using Module = Autofac.Module;

namespace Business.DependancyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           
            //builder.RegisterType<ExternalEmployeeManager>().As<IExternalEmployeeService>();
            //builder.RegisterType<EfExternalEmployeeDal>().As<IExternalEmployeeDal>();



            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}

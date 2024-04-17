
using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utitlities;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System.Reflection;
using Module = Autofac.Module;

namespace Business.DependancyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<NewsFeedManager>().As<INewsFeedService>();
            builder.RegisterType<EfNewsFeedDal>().As<INewsFeedDal>();



            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}

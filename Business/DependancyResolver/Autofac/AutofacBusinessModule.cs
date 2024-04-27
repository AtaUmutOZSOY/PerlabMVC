
using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System.Reflection;
using Module = Autofac.Module;

namespace Business.DependancyResolver.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<EfPersonDal>().As<IPersonDal>();
            builder.RegisterType<PersonManager>().As<IPersonService>();

            builder.RegisterType<NewsFeedManager>().As<INewsFeedService>();
            builder.RegisterType<EfNewsFeedDal>().As<INewsFeedDal>();
            builder.RegisterType<EfAnnouncementDal>().As<IAnnouncementDal>();
            builder.RegisterType<EfEventDal>().As<IEventDal>();
            builder.RegisterType<CollaborationManager>().As<ICollaborationService>();
            builder.RegisterType<EfCollaborationDal>().As<ICollaborationDal>();

            builder.RegisterType<ResearchManager>().As<IResearchService>();
            builder.RegisterType<EfResearchDal>().As<IResearchDal>();
            builder.RegisterType<ProjectManager>().As<IProjectService>();
            builder.RegisterType<EfProjectDal>().As<IProjectDal>();

            builder.RegisterType<PublicationManager>().As<IPublicationService>();
            builder.RegisterType<EfPublicationDal>().As<IPublicationDal>();
            builder.RegisterType<AuthorManager>().As<IAuthorService>();
            builder.RegisterType<EfAuthorDal>().As<IAuthorDal>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}

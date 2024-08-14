using Autofac;
using Moviely.BackEnd.Core.Repositories;
using Moviely.BackEnd.Core.Services;
using Moviely.BackEnd.Core.UnitOfWorks;
using Moviely.BackEnd.Repository.Repositories;
using Moviely.BackEnd.Repository.UnitOfWork;
using Moviely.BackEnd.Service.Services;

namespace Moviely.BackEnd.API.Module
{
    public class RepoServiceModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<CommentRepository>().As<ICommentRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<CommentService>().As<ICommentService>().AsImplementedInterfaces().InstancePerLifetimeScope();   




            base.Load(builder);
        }


    }
}

using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using AppAlmacenecesRepository.Model;
using AppAlmacenecesRepository.ViewModel;
using BaseRepository.Repository;
using Unity.WebApi;

namespace AppAlmacenes
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<DbContext, TiendaEntities>();

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IRepository<Almacen, AlmacenViewModel>,
                RepositoryEntity<Almacen, AlmacenViewModel>>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
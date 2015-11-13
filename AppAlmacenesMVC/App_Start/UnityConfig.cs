using System.Data.Entity;
using Microsoft.Practices.Unity;
using AppAlmacenecesRepository.Model;
using AppAlmacenecesRepository.ViewModel;
using BaseRepository.Repository;
using System.Web.Http;
using Unity.WebApi;

namespace AppAlmacenesMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<DbContext, TiendaEntities>();

            container.RegisterType<IRepository<Almacen, AlmacenViewModel>,
                RepositoryEntity<Almacen, AlmacenViewModel>>();
            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
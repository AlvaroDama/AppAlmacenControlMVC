using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAlmacenecesRepository.Model;
using AppAlmacenecesRepository.ViewModel;
using BaseRepository.Repository;

namespace AppAlmacenesMVC.Controllers
{
    public class AlmacenController : Controller
    {
        public RepositoryEntity<Almacen, AlmacenViewModel> repo;

        public AlmacenController()
        {
            var ctx = new TiendaEntities();
            repo = new RepositoryEntity<Almacen, AlmacenViewModel>(ctx);
            
        }

        // GET: Almacen
        public ActionResult Index()
        {
            return View(repo.Get());
        }
    }
}
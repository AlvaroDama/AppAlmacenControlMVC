using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using AppAlmacenecesRepository.Model;
using AppAlmacenecesRepository.ViewModel;
using BaseRepository.Repository;

namespace AppAlmacenes.Controllers
{
    public class AlmacenController : Controller
    {

        public IRepository<Almacen, AlmacenViewModel> repo { get; set; }
        public TiendaEntities ctx;

        public AlmacenController()
        {
            ctx = new TiendaEntities();
            repo = new RepositoryEntity<Almacen, AlmacenViewModel>(ctx);
        }

        // GET: Almacen
        public ActionResult Index()
        {
            return View(repo.Get());
        }

        public ActionResult Edit(int id)
        {
            return View(repo.Get(id));
        }

        public ActionResult Delete(int id)
        {
            var almProd = new RepositoryEntity<ProductoAlmacen, ProductoAlmacenViewModel>(ctx);

            almProd.Borrar(o => o.idAlmacen.Equals(id));

            repo.Borrar(new AlmacenViewModel() {ID = id});

            return RedirectToAction("Index");
        }

        public ActionResult Modifica(AlmacenViewModel al)
        {
            return RedirectToAction("Index");
        }
    }
}
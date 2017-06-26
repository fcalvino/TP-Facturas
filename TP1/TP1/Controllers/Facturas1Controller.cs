using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TP1.Models;

namespace TP1.Controllers
{
    public class Facturas1Controller : Controller
    {
        private Contexto db = new Contexto();
        public FactArt fd = new FactArt();

        // GET: Facturas1
        public ActionResult Index()
        {
            return View(db.Facturas.ToList());
        }


        // GET: Facturas1/Create
        public ActionResult Create()
        {
            FactArt fd = new FactArt();
            return View(fd);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fecha,Total,NombreCliente")] Factura factura, List<FacturaDetalles> detalle)
        {
            if (ModelState.IsValid)
            {
                db.Facturas.Add(factura);
                db.SaveChanges();

                if (detalle != null)
                {
                    foreach (FacturaDetalles linea in detalle)
                    {
                        factura.Detalle.Add(linea);
                    }
                    db.SaveChanges();
                    }
                    return Content("OK");
                }
            else
            {
                return Json(ModelState.Values.SelectMany(v => v.Errors));
            }
        }
 
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}

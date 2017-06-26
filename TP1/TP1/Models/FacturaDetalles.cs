using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP1.Models
{
    public class FacturaDetalles
    {
        public int Id { get; set; }
        public int Facturaid { get; set; }
        public int Articuloid { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        Contexto db = new Contexto();

        public IEnumerable<SelectListItem> ArtItems
        {
            get
            {
                var allArticulos = db.Articulos.ToList().Select(f => new SelectListItem
                {
                    Value = f.Id.ToString(),
                    Text = f.Descripcion
                });
                return allArticulos;

            }
        }

        public virtual Factura Factura { get; set; }
        public virtual Articulos Articulos { get; set; }
    }

    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP1.Models
{
    public class Articulos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        private readonly List<Articulos> articulos;
        public IEnumerable<SelectListItem> ArtItems
        {
            get { return new SelectList(articulos, "Id", "Codigo"); }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class FactArt
    {
        public Factura factura { get; set; }
        public Articulos articulos { get; set; }
        public FacturaDetalles facturadetalle { get; set; }


        public FactArt()
        {
            facturadetalle = new FacturaDetalles();
            factura = new Factura();
            articulos = new Articulos();
        }
    }

}
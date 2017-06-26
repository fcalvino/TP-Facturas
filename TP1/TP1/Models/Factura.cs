using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP1.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; }
        public virtual List<FacturaDetalles> Detalle { get; set; }
        public double Total {get; set;}

        public Factura()
        {
            this.Detalle = new List<FacturaDetalles>();
        }
    }
}
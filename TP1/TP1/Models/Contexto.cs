using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Factura> Facturas { get; set; }

        public DbSet<FacturaDetalles> FacturaDetalles { get; set; }

        public DbSet<Articulos> Articulos { get; set; }


        static Contexto()
        {
            Database.SetInitializer<Contexto>(new CreateDatabaseIfNotExists<Contexto>());
            Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }


    }
}
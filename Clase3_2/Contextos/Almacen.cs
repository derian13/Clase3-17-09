using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase3_2.Modelos;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Clase3_2.Contextos
{
    public class Almacen:DbContext
    {
        public Almacen() : base("AlmacenDB") { }
        public DbSet<Materiales> Material { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

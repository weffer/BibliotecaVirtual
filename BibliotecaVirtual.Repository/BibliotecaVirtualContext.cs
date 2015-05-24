using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaVirtual.Dominio;

namespace BibliotecaVirtual.Repository
{
    public class BibliotecaVirtualContext : DbContext
    {
        public BibliotecaVirtualContext(): base("name=BibliotecaVirtual"){}

        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Libro>();
            modelBuilder.Entity<Categoria>();
        }
    }
}

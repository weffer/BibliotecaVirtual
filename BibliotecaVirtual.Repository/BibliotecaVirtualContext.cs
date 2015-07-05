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

        //public virtual DbSet<Autor> Autor { get; set; }
        //public virtual DbSet<LibAut> LibAut { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Autor>()
            //    .Property(e => e.Nombre)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Autor>()
            //    .Property(e => e.Nacionalidad)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Autor>()
            //    .HasMany(e => e.LibAut)
            //    .WithRequired(e => e.Autor)
            //    .HasForeignKey(e => e.IdAutor)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Libro>()
            //    //.HasMany(e => e.LibAut)
            //    .WithOptional(e => e.Libro)
            //    .HasForeignKey(e => e.IdLibro);

            modelBuilder.Entity<Libro>()
                .HasMany(e => e.Prestamo)
                .WithRequired(e => e.Libro)
                .HasForeignKey(e => e.IdLibro)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Prestamo>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Prestamo>()
                .Property(e => e.Devuelto)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}

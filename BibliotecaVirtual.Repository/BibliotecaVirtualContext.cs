using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Repository
{
    public class BibliotecaVirtualContext : DbContext
    {
        public BibliotecaVirtualContext()
            : base("name=BibliotecaVirtual")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

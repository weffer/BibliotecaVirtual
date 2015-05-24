using BibliotecaVirtual.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Repository
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : EntityBase
    {
        IQueryable<TEntity> Get();
        void Create(TEntity entity);
        void Update(TEntity entity);
    }
}

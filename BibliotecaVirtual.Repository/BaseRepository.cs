using BibliotecaVirtual.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Repository
{
    public class BaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : EntityBase
        where TContext : DbContext
    {

        protected TContext Context;

        public BaseRepository(TContext Context)
        {
            this.Context = Context;
        }

        public IQueryable<TEntity> Get()
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public int Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            return Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList<TEntity>().AsEnumerable();
        }

        public int Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            return Context.SaveChanges();      
        }

        public void Dispose()
        {
            Context = null;
        }


        public TEntity GetById(int Id)
        {
            return Context.Set<TEntity>().Find(Id);
        }
    }
}

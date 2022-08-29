using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DirectoryApp.Entity;

namespace DirectoryApp.DAL.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {

        private readonly ModelContext _context;
        public BaseRepository(ModelContext dbContext)
        {
            this._context = dbContext;
        }

        public void Add(TEntity entity)
        {

            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();


        }

        public void Delete(TEntity entity)
        {

            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();

        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression = null)
        {

            return _context.Set<TEntity>().Where(expression).FirstOrDefault();


        }

        public TEntity GetById(int id)
        {

            return _context.Set<TEntity>().Find(id);

        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {

            if (expression == null)
            {
                return _context.Set<TEntity>().ToList();
            }
            return _context.Set<TEntity>().Where(expression).ToList();

        }



        public void Update(TEntity entity)
        {

            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DirectoryApp.Entity;

namespace DirectoryApp.DAL.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetList(Expression<Func<T, bool>> expression = null);
        T Get(Expression<Func<T, bool>> expression = null);
    }
}

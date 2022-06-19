using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetListAll();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);

        List<T> GetListAll(Expression<Func<T, bool>> filter);
    }
}

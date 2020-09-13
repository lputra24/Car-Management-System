using CarManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarManagementSystem.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        protected RepositoryContext Context;

        public RepositoryBase(RepositoryContext RepositoryContext) {
           Context = RepositoryContext;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return Context.Set<T>().Where(expression);
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }
    }
}

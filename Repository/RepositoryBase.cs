using Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly RepositoryContext RepositoryContext;

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
             !trackChanges ?
             RepositoryContext.Set<T>()
             .AsNoTracking() :
             RepositoryContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, 
            bool trackChanges) =>
            !trackChanges ?
            RepositoryContext.Set<T>()
            .AsNoTracking() : 
            RepositoryContext.Set<T>();        

        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);

        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);

        public void Update(T entity) => RepositoryContext?.Update(entity);
    }
}

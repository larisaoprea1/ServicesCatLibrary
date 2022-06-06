using library1.Models;
using library1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace library1.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected libraryContext LibraryContext { get; set; }

        public RepositoryBase(libraryContext LibraryContext)
        {
            this.LibraryContext = LibraryContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.LibraryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, Expression<Func<T, object>> criteria,  Expression<Func<T, object>> criteria1,  Expression<Func<T, object>> criteria2,  Expression<Func<T, object>> criteria3)
        {
            return this.LibraryContext.Set<T>().Include(criteria).Include(criteria1).Include(criteria2).Include(criteria3).Where(expression).AsNoTracking();
        }
        public IQueryable<T> FindByCondition2(Expression<Func<T, object>> criteria,  Expression<Func<T, object>> criteria1,  Expression<Func<T, object>> criteria2,  Expression<Func<T, object>> criteria3)
        {
            return this.LibraryContext.Set<T>().Include(criteria).Include(criteria1).Include(criteria2).Include(criteria3).AsNoTracking();
        }
        public T FindObject(Expression<Func<T, bool>> expression, Expression<Func<T, object>> criteria,  Expression<Func<T, object>> criteria1,  Expression<Func<T, object>> criteria2,  Expression<Func<T, object>> criteria3)
        {
            return this.LibraryContext.Set<T>().Include(criteria).Include(criteria1).Include(criteria2).Include(criteria3).Where(expression).FirstOrDefault();
        }
        
        public void Create(T entity)
        {
            this.LibraryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.LibraryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.LibraryContext.Set<T>().Remove(entity);
        }
    }
}
using System.Linq.Expressions;

namespace library1.Repositories.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, Expression<Func<T, object>> criteria,  Expression<Func<T, object>> criteria1,  Expression<Func<T, object>> criteria2,  Expression<Func<T, object>> criteria3);
        IQueryable<T> FindByCondition2(Expression<Func<T, object>> criteria,  Expression<Func<T, object>> criteria1,  Expression<Func<T, object>> criteria2,  Expression<Func<T, object>> criteria3);
        T FindObject(Expression<Func<T, bool>> expression, Expression<Func<T, object>> criteria,  Expression<Func<T, object>> criteria1,  Expression<Func<T, object>> criteria2,  Expression<Func<T, object>> criteria3);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
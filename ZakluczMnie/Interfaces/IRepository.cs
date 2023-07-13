using System.Linq.Expressions;

namespace ZakluczMnie.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetMany(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includeExpressions);
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeExpressions);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void SaveChanges();
    }
}

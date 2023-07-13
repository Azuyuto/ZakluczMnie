using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ZakluczMnie.Data;
using ZakluczMnie.Interfaces;

namespace ZakluczMnie.Repositories
{
    public class Repository<T> : IRepository<T> where T: class
    {
        protected readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeExpressions)
        {
            IQueryable<T> set = _context.Set<T>();

            foreach (var includeExpression in includeExpressions)
            {
                set = set.Include(includeExpression);
            }
            return set.ToList();
        }
        public IEnumerable<T> GetMany(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includeExpressions)
        {
            IQueryable<T> set = _context.Set<T>().Where(expression);

            foreach (var includeExpression in includeExpressions)
            {
                set = set.Include(includeExpression);
            }
            return set;
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

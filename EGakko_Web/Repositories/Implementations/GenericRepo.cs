
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;
using EGakko_DAL.Data;

namespace EGakko_Web.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> _dbSet;
        public GenericRepo(ApplicationDbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }

        public async Task Add(T obj)
        {
            await _dbSet.AddAsync(obj);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable <T> Q = _dbSet;
            return Q;
        }

        public T GetByFilter(Expression<Func<T, bool>> Filters)
        { 
            IQueryable<T> Q = _dbSet;
            return Q.Where(Filters).FirstOrDefault();
        }

        public void Remove(T obj)
        {
            _dbSet.Remove(obj);
        }

        public void RemoveRange(IEnumerable<T> items)
        {
            _dbSet.RemoveRange(items);
        }
    }
}

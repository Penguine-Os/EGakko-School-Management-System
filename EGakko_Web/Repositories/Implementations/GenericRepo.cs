
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
        private readonly ApplicationDbContext _context;

        public GenericRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
           await _context.Set<T>().AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> items)
        {
            await _context.Set<T>().AddRangeAsync(items);
        }

        public void Delete(T entity)
        {
             _context.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return  await _context.Set<T>().ToListAsync();
        }

        public  void RemoveRange(IEnumerable<T> items)
        {
             _context.Set<T>().RemoveRange(items);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public async Task<T> GetById<Id>(Id id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

       public async Task<IEnumerable<T>> GetListByFilter(Expression<Func<T, bool>> Filters)
        {
           return await _context.Set<T>().Where(Filters).ToListAsync();
        }

        public async Task<T>  GetSingleByFilter(Expression<Func<T, bool>> Filters)
        {
            return await _context.Set<T>().Where(Filters).FirstAsync();

        }
    }
}

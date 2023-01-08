
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
        internal DbSet<T> DbSet;
        public GenericRepo(ApplicationDbContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public async Task Add(T entity)
        {
           await DbSet.AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> items)
        {
            await DbSet.AddRangeAsync(items);
        }

        public void Delete(T entity)
        {
             _context.Remove(entity);
        }

        public  IEnumerable<T> GetAll()
        {
            return   DbSet.ToList();
        }

        public  void RemoveRange(IEnumerable<T> items)
        {
             DbSet.RemoveRange(items);
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
        }

        public async Task<T> GetById<Id>(Id id)
        {
            return await DbSet.FindAsync(id);
        }

       public async Task<IEnumerable<T>> GetListByFilter(Expression<Func<T, bool>> Filters)
        {
           return await DbSet.Where(Filters).ToListAsync();
        }

        public async Task<T>  GetSingleByFilter(Expression<Func<T, bool>> Filters)
        {
            return await DbSet.Where(Filters).FirstAsync();

        }
    }
}

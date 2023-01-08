using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EGakko_Web.Repositories
{
    public interface IGenericRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetById<Id>(Id id);
        Task<T> GetSingleByFilter(Expression<Func<T, bool>> Filters);
        Task<IEnumerable<T>> GetListByFilter(Expression<Func<T, bool>> Filters);
     
        void RemoveRange(IEnumerable<T> items);
        Task AddRange(IEnumerable<T> items); 

    }

}

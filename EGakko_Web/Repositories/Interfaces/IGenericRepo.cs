
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
        Task Add(T obj);
        T GetByFilter(Expression<Func<T, bool>> Filters);
        void Remove (T obj);
        void RemoveRange(IEnumerable<T> items);
    }

}

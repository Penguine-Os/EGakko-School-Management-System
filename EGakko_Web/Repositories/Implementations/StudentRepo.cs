using EGakko_DAL.Data;
using EGakko_Models;
using EGakko_Web.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EGakko_Web.Repositories.Implementations
{
    public class StudentRepo : GenericRepo<Student>, IStudentRepo
    {
        private readonly ApplicationDbContext _context;

        public StudentRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<IEnumerable<Student>> GetAllJoined(params Expression<Func<Student, object>>[] includes)
        {

            return GetAllJoined(null, includes);
        }

        public async Task<IEnumerable<Student>> GetAllJoined(Expression<Func<Student, bool>> voorwaarden, params Expression<Func<Student, object>>[] includes)
        {
            IQueryable<Student> query = _context.Set<Student>();
            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }
            if (voorwaarden != null)
            {
                query = query.Where(voorwaarden);
            }
            return await query.ToListAsync();
        }
    }
}

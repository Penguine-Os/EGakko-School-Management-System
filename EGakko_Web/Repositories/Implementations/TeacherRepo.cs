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
    public class TeacherRepo : GenericRepo<Teacher>, ITeacherRepo
    {
        private readonly ApplicationDbContext _context;

        public TeacherRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetAllJoined(Expression<Func<Teacher, bool>> voorwaarden, params Expression<Func<Teacher, object>>[] includes)
        {
            IQueryable<Teacher> query = _context.Set<Teacher>();
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
            return  query.ToList();
        }

        public IEnumerable<Teacher> GetAllJoined(params Expression<Func<Teacher, object>>[] includes)
        {
            return GetAllJoined(null, includes);
        }
        public IEnumerable<TeacherSubject> GetTeacherSubjects(int teacherId)
        {
            return  _context.Set<TeacherSubject>()
                                    .Include(t => t.Teacher)
                                    .Include(t => t.Subject)
                                    .Where(ts => ts.TeacherId == teacherId).ToList();
        }
    }
}

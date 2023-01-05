using EGakko_DAL.Data;
using EGakko_Models;
using EGakko_Web.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGakko_Web.Repositories.Implementations
{
    public class SubjectRepo : GenericRepo<Subject>, ISubjectRepo
    {
        private readonly ApplicationDbContext _context;

        public SubjectRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TeacherSubject>> GetTeacherSubjects(int teacherId)
        {
            return  await _context.Set<TeacherSubject>()
                                    .Include(t => t.Teacher)
                                    .Include(t => t.Subject)
                                    .Where(ts => ts.TeacherId == teacherId).ToListAsync();
        }
    }
}

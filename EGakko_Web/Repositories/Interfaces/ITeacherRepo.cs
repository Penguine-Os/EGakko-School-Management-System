using EGakko_Models;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EGakko_Web.Repositories.Interfaces
{
    public interface ITeacherRepo : IGenericRepo<Teacher>
    {
        IEnumerable<Teacher> GetAllJoined(params Expression<Func<Teacher, object>>[] includes);

        IEnumerable<Teacher> GetAllJoined(Expression<Func<Teacher, bool>> voorwaarden,
            params Expression<Func<Teacher, object>>[] includes);
        IEnumerable<TeacherSubject> GetTeacherSubjects(int teacherId);
    }
}

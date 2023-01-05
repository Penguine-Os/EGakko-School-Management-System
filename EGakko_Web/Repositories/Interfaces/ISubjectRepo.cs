using EGakko_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EGakko_Web.Repositories.Interfaces
{
    public interface ISubjectRepo : IGenericRepo<Subject>
    {
        Task<IEnumerable<TeacherSubject>> GetTeacherSubjects(int teacherId);
    }
}

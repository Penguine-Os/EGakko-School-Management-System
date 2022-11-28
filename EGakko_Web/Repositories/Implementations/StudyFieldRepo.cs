using EGakko_DAL.Data;
using EGakko_Models;

namespace EGakko_Web.Repositories.Implementations
{
    public class StudyFieldRepo : GenericRepo<StudyField>, IStudyFieldRepo
    {
        public StudyFieldRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}

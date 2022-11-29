using EGakko_DAL.Data;
using EGakko_Models;
using EGakko_Web.Repositories.Interfaces;

namespace EGakko_Web.Repositories
{
    public class FieldRepo : GenericRepo<Field>, IFieldRepo
    {
        public FieldRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
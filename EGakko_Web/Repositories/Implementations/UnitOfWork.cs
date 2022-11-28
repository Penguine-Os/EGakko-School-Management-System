using EGakko_DAL.Data;
using EGakko_Web.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGakko_Web.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
       
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            StudyFieldRepo = new StudyFieldRepo(db);
        }

        public IStudyFieldRepo StudyFieldRepo { get; private set; }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}

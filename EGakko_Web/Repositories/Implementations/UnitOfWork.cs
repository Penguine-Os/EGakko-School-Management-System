using EGakko_DAL.Data;
using EGakko_Models;
using EGakko_Web.Repositories.Implementations;
using EGakko_Web.Repositories.Interfaces;
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
            FieldRepo = new FieldRepo(db);
            TeacherRepo = new TeacherRepo(db);
            StudentRepo = new StudentRepo(db);
            ClassRepo = new GenericRepo<EGakko_Models.Class>(db);
        }


        public IStudyFieldRepo StudyFieldRepo { get; private set; }
        public IFieldRepo FieldRepo { get; private set; }
        public ITeacherRepo TeacherRepo { get; set; }
        public IStudentRepo StudentRepo { get; set; }
        public IGenericRepo<EGakko_Models.Class> ClassRepo { get; set; }
        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}

using EGakko_Web.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGakko_Web.Repositories
{
    public interface IUnitOfWork
    {
        public IStudyFieldRepo StudyFieldRepo { get; }
        public IFieldRepo FieldRepo { get; }
        Task Save();
    }
}

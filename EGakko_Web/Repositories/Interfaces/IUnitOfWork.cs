﻿using EGakko_Models;
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
        ITeacherRepo TeacherRepo { get; set; }
        IStudentRepo StudentRepo { get; set; }
        IGenericRepo<EGakko_Models.Class> ClassRepo { get; set; }

        Task Save();
    }
}

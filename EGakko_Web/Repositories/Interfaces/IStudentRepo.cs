﻿using EGakko_Models;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;

namespace EGakko_Web.Repositories.Interfaces
{
    public interface IStudentRepo : IGenericRepo<Student>
    {

        IEnumerable<Student> GetAllJoined(params Expression<Func<Student, object>>[] includes);

        IEnumerable<Student> GetAllJoined(Expression<Func<Student, bool>> voorwaarden,
            params Expression<Func<Student, object>>[] includes);

    }
}

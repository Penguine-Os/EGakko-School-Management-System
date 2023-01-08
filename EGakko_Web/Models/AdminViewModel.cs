using EGakko_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EGakko_Web.Models
{
    public class AdminViewModel
    {
        public List<CustomUser> StudentsAndTeacher { get; set; } = new List<CustomUser>();
        public List<CustomUser> UsersWithoutRoles { get; set; } = new List<CustomUser>();


     
    }
}

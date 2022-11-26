﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace EGakko_Models
{
    public class StudyField
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GradeLevel { get; set; }
      


        // Navigational Properties

        public virtual List<Student> Students { get; set; }
        public virtual List<FieldSubject> FieldSubjects { get; set; }

    }
}

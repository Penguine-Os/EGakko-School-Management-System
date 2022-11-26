using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        // Navigational Properties
        public virtual List<FieldSubject> FieldSubjects { get; set; }
        public virtual List<TeacherSubject> TeacherSubjects { get; set; }

        public Subject()
        {

        }
        public Subject( int subId, string subName)
        {
            Id = subId;
            Name = subName;
        }
    }
}

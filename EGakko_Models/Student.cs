using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool FeesArePayed { get; set; }
      

        // Navigational Properties
        public string CustomUserIdStudent { get; set; }
        [ForeignKey("CustomUserIdStudent")]
        public virtual CustomUser CustomUserStudent { get; set; }

        public int FieldId { get; set; }
        [ForeignKey("FieldId")]
        public virtual StudyField Field { get; set; }

        
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }


        public virtual List<Result> Results { get; set; }

        public virtual List<Attendance> ListOfAttendance { get; set; }
        public Student()
        {

        }
        public Student(string id, int fieldId, int classId)
        {
            CustomUserIdStudent = id;
            FieldId = fieldId;
            ClassId = classId;
        }

    }
}

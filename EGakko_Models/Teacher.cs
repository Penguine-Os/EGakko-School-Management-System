using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
namespace EGakko_Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public string DiplomaTitle { get; set; }


        // Navigational Properties
        public string CustomUserIdTeacher { get; set; }
        [ForeignKey("CustomUserIdTeacher")]
        public virtual CustomUser CustomUserTeacher { get; set; }
        public virtual List<ActivityEvaluation> ActivityEvaluations{ get; set; }

        public virtual List<TeacherSubject> Subjects { get; set; }
        public virtual List<ClassSchedule> ClassSchedules { get; set; }

    }
}

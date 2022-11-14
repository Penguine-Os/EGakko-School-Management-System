using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public CustomUser CustomUserTeacher { get; set; }

        public List<Attendance> ListOfAttendance { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<ClassSchedule> ClassSchedules { get; set; }

    }
}

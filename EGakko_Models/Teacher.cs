using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public string DiplomaTitle { get; set; }


        // Navigational Properties
        public string CustomUserId { get; set; }
        public CustomUser CustomUserTeacher { get; set; }

        public List<Attendance> ListOfAttendance { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<ClassSchedule> ClassSchedules { get; set; }

    }
}

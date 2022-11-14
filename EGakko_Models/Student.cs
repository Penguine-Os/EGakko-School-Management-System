using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool FeesArePayed { get; set; }
        public string GradeLevel{ get; set; }

        // Navigational Properties
        public string CustomUserId { get; set; }
        public CustomUser CustomUserStudent { get; set; }

        public int FieldId { get; set; }
        public StudyField Field { get; set; }

        public List<Score> Results { get; set; }

        public List<Attendance> ListOfAttendance { get; set; }

    }
}

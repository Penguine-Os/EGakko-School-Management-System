using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class StudentAttendance
    {
        [Key]
        public int Id { get; set; }
        
        //Navigational properties
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Attendance AttendanceId { get; set; }
        public Teacher Teacher { get; set; }
    }
}

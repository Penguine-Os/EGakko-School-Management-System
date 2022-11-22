using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class StudentAttendance
    {
        [Key]
        public int Id { get; set; }
        
        //Navigational properties
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        public int AttendanceId { get; set; }
        [ForeignKey("AttendanceId")]
        public Attendance Attendance { get; set; }

     
    }
}

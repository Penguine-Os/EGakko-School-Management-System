using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }
        public DateTime Registry { get; set; }
        public StatusType Status { get; set; }

        // Navigational Properties

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        //public List<Student> Students { get; set; }

    }
}

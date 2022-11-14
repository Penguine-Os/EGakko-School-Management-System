using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        //public List<Student> Students { get; set; }

    }
}

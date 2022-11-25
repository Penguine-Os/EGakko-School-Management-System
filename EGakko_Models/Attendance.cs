using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = "Absent";

        // Navigational Properties

        public int StudentId { get; set; }
       [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
     

    }
}

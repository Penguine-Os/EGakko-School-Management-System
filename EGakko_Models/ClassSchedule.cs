using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class ClassSchedule
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        // Navigational Properties

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int FieldSubjectID { get; set; }
        public FieldSubject FieldSubject { get; set; }


    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public virtual ClassRoomLocation Location { get; set; }

        public int FieldSubjectId { get; set; }
        [ForeignKey("FieldSubjectId")]
        public virtual FieldSubject FieldSubject { get; set; }


    }
}

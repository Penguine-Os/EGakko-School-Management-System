using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class FieldSubject
    {
        [Key]
        public int Id { get; set; }

        public bool IsCoreSubject { get; set; }

        public int HoursPerWeek { get; set; }
        // Navigational Properties
        public int FieldId { get; set; }
        [ForeignKey("FieldId")]
        public virtual StudyField Field { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
        public virtual List<ClassSchedule> ClassSchedules { get; set; }
    }
}

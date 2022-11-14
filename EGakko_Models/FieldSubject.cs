using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class FieldSubject
    {
        [Key]
        public int Id { get; set; }

        // Navigational Properties
        public int FieldId { get; set; }
        [ForeignKey("FieldId")]
        public StudyField Field { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
    }
}

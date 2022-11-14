using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class FieldSubject
    {
        [Key]
        public int Id { get; set; }

        // Navigational Properties
        public int FieldId { get; set; }
        public StudyField Field { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}

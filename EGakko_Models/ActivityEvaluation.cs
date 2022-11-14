using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class ActivityEvaluation
    {
        [Key]
        public int Id { get; set; }
        public int MaxScore { get; set; }
        public string Summery { get; set; }
        public ActivityType Activity { get; set; }

        // Navigational Properties
        public int FieldSubjectId { get; set; }
        public FieldSubject FieldSubject { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class ActivityEvaluation
    {
        [Key]
        public int Id { get; set; }
        public int MaxScore { get; set; }
        public string Summery { get; set; }
        public virtual ActivityType Activity { get; set; }

        // Navigational Properties
        public int FieldSubjectId { get; set; }
        [ForeignKey("FieldSubjectId")]
        public FieldSubject FieldSubject { get; set; }
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
        public virtual List<Result> Results{ get; set; }
    }
}

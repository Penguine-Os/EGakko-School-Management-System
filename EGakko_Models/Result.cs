using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalScore { get; set; }

        // Navigational Properties
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        public int EvaluationId { get; set; }
        [ForeignKey("EvaluationId")]
        public ActivityEvaluation ActivityEvaluation { get; set; }

    }
}

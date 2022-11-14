using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalScore { get; set; }

        // Navigational Properties
        public int EvaluationId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public ActivityEvaluation ActivityEvaluation { get; set; }

    }
}

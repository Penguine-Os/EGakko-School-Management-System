using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace TestTest.Models
{
    public class Class1
    {
    }
    public class ActivityEvaluation
    {
        [Key]
        public int Id { get; set; }
        public int MaxScore { get; set; }
        public string Summery { get; set; }
        public ActivityType Activity { get; set; }

        // Navigational Properties
        public int FieldSubjectId { get; set; }
        [ForeignKey("FieldSubjectId")]
        public FieldSubject FieldSubject { get; set; }
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }
    }
    public enum ActivityType
    {
        HomeWork,
        Test,
        Examination
    }
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
        public Student Student { get; set; }


    }

}

using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCoreSubject { get; set; }

        // Navigational Properties
        List<StudyField> Fields { get; set; }
    }
}

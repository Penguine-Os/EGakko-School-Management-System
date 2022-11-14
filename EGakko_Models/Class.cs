using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string ClassName { get; set; }

        // Navigational Properties
        public List<Student> Students { get; set; }
        public List<ClassSchedule> ClassSchedules { get; set; }

    }
}

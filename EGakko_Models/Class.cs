using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    [Table("Classes")]
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

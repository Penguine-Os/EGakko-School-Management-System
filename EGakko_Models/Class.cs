using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
   
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string ClassName { get; set; }

        // Navigational Properties
        public virtual List<Student> Students { get; set; }
        public virtual List<ClassSchedule> ClassSchedules { get; set; }

        public Class()
        {

        }
        public Class(int id, string name)
        {
            Id = id;
            ClassName = name;
        }

    }
}

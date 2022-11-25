using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace EGakko_Models
{
    public class ClassRoomLocation
    {
        [Key]
        public int Id { get; set; }
        public string ClassRoomName { get; set; }
        public int Capacity { get; set; }
       
        // Navigational Properties
        public virtual List<ClassSchedule> ClassSchedules { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string ClassRoomName { get; set; }
        public int Capacity { get; set; }
        public bool IsOccupied { get; set; }

        // Navigational Properties
        public List<ClassSchedule> ClassSchedules { get; set; }
    }
}

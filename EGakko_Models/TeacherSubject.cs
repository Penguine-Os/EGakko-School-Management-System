using System.ComponentModel.DataAnnotations;

namespace EGakko_Models
{
    public class TeacherSubject
    {
        [Key]
        public int Id { get; set; }

        //Navigational properties
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}

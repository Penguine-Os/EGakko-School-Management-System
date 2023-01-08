using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class TeacherSubject
    {
        [Key]
        public int Id { get; set; }

        //Navigational properties
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
        public TeacherSubject(int id, int teacherId, int subjectId)
        {
            Id = id;
            SubjectId = subjectId;
            TeacherId = teacherId;
        }
        public TeacherSubject()
        {

        }
    }
}

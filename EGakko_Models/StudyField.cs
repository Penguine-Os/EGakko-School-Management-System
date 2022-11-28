using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGakko_Models
{
    public class StudyField
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigational Properties
        public int FieldId { get; set; }
        [ForeignKey("FieldId")]
        public Field Field { get; set; }

        public virtual List<Student> Students { get; set; }
        public virtual List<FieldSubject> FieldSubjects { get; set; }

        public StudyField()
        {

        }
        public StudyField(int id, int fieldId, string name, string desc)
        {
            Id = id;
            FieldId=fieldId;
            Name = name;    
            Description = desc;
        }

    }

    public class Field
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    
        public Field(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

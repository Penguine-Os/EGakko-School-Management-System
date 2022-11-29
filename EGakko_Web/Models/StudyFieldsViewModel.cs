using EGakko_Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EGakko_Web.Models
{
    public class StudyFieldsViewModel
    {
        public Field Field { get; set; }
        [Required]
        public int FieldId { get; set; }
        public IEnumerable<StudyField> StudyFields{ get; set; }
        public IEnumerable<SelectListItem> Fields { get; set; }

    }
}

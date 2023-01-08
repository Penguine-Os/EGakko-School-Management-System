using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EGakko_Web.Models
{
    public class UpdateUserViewModel
    {
        public  List<SelectListItem> Classes { get; set; }
        public  List<SelectListItem> Fields { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public string CustomUserId { get; set; }
        public string Role { get; set; }

        [Required(ErrorMessage = "First Nmae Is Required")]
        [MaxLength(50)]
        public string CustomUserFirstName { get; set; }

        [Required(ErrorMessage = "Last Name Is Required")]
        [MaxLength(50)]
        public string CustomUserLastName { get; set; }

        [Required(ErrorMessage = "Email Is Required")]
        [MaxLength(50)]
        public string CustomUserEmail { get; set; }

        [Required(ErrorMessage = "Street Name  Is Required")]
        [MaxLength(50)]
        public string CustomUserStreet { get; set; }


        public int? CustomUserHouseNumber { get; set; }


        public string CustomUserZipCode { get; set; }

        [Required(ErrorMessage = "Field Is Required")]
        public string CustomUserCity { get; set; }

        public DateTime CustomUserBirthDate { get; set; }


        public decimal TeacherSalery { get; set; }

       
        public string TeacherDiploma { get; set; }
        public bool StudentFeesArePayed { get; set; }


        public int? StudentClassId { get; set; }


        public int? StudentFieldId { get; set; }

    }
}

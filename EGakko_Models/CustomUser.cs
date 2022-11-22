using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EGakko_Models
{
    public class CustomUser : IdentityUser
    {
        [Required, PersonalData, Display(Name = "Fist Name")]
        [MaxLength(100, ErrorMessage = "First name should not exceed the max length of 100 characters")]
        public string FName { get; set; }


        [Required, PersonalData, Display(Name = "Last Name")]
        [MaxLength(100, ErrorMessage = "Last name should not exceed the max length of 100 characters")]
        public string LName { get; set; }

        [PersonalData]
        public string? Street { get; set; }

        [PersonalData]
        public int? HouseNumber { get; set; }

        [PersonalData]
        public string? ZipCode { get; set; }

        [PersonalData]
        public string? City { get; set; }

        [PersonalData]
        public DateTime? BirthDate { get; set; }

     public Gender Gender { get; set; }
    }
}

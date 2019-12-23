using DataAnnotationsExtensions;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KudyFinancials.Models
{
    public class InvestorInformationI : IdentityUser
    {
        public InvestorInformationI() : base () {}

        [Required(ErrorMessage ="First Name cannot be empty")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name cannot be empty")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Email Address cannot be empty")]
        //[Display(Name = "Email Address")]
        //[Email]
        //public string Email { get; set; }

        //[DataType(DataType.Password)]
        //[Required(ErrorMessage = "Password cannot be empty")]
        //public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Password and confirmation password must match")]
        //[Required(ErrorMessage = "Confirm Password cannot be empty")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm Password")]
        //public string ConfirmPassword { get; set; }
        public string SecurityQuestion { get; set; }

        [Required(ErrorMessage = "Answer to Security Question cannot be empty")]
        public string Answer { get; set; }
    }
}

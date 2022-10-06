using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelApp.Models
{
    [MetadataType(typeof(GusetsMetaData))]
    public  partial class Gusets
    {
       

    }
    public class GusetsMetaData
    {
        [Display(Name = "Guest ID")]
        public int gusID { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "the age is required")]
        [checkAge]
        public int age { get; set; }

        [Display(Name = "Guest name")]
        [Required(ErrorMessage = "username is required")]
        public string gusName { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "please enter valid email.")]
        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Required(ErrorMessage = "password is required")]
        [MinLength(6, ErrorMessage = "must be 6 charctars at least")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required(ErrorMessage = "phone number is required")]
        [StringLength(11, ErrorMessage = "phone number must be 11 charctar")]
        public string phone { get; set; }

        [Required(ErrorMessage = "SSN is required")]
        [StringLength(14, ErrorMessage = "SSnr must be 14 charctar")]
        public string SSN { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "gender is required")]
        public string gender { get; set; }

        [Required(ErrorMessage = "confirm password is required")]
        [MinLength(6, ErrorMessage = "must be 6 charctars at least")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "please confirm your password,this is differ from password")]
        [Display(Name = "Confirm password")]
        public string confirmPassword { get; set; }

    }
}
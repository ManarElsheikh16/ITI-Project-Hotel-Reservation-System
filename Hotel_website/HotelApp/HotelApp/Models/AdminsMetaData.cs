using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace HotelApp.Models
{ 

     [MetadataType(typeof(AdminsMetaData))]
    public partial class Admins
    {

    }
    public class AdminsMetaData
    {
        [Display(Name = "Admin ID")]
        public int adminID { get; set; }

        [Required(ErrorMessage = "username is required")]
        [Display(Name = "Username")]
        public string userName { get; set; }

        [Required(ErrorMessage = "password is required")]
        [MinLength(6, ErrorMessage = "must be 6 charctars at least")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string passward { get; set; }

        [Required(ErrorMessage = "confirm password is required")]
        [MinLength(6, ErrorMessage = "must be 6 charctars at least")]
        [DataType(DataType.Password)]
        [Compare("passward", ErrorMessage = "please confirm your password,this is differ from password")]
        [Display(Name = "Confirm password")]
        public string confirmPassword { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "please enter valid email.")]
        [Display(Name = "E-mail")]
        public string email { get; set; }
    }
}
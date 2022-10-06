using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    class Guset
    {
        [Key]
        public int gusID { get; set; }
        [Required(ErrorMessage = "your age is required")]
        public int age { get; set; }
        [Required(ErrorMessage = "user name is required")]
        public string gusName { get; set; }
        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "please enter valid email.")]
        public string email { get; set; }
        [Required(ErrorMessage = "password is required")]
        [MinLength(6, ErrorMessage = "must be 6 charctars at least")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [StringLength(11,ErrorMessage ="phone num must be 11 charctar")]
        public string phone { get; set; }
        [Required]
        [StringLength(14, ErrorMessage = "SSN must be 14 charctar")]
        public string SSN { get; set; }
        public string gender { get; set; }
        [Required(ErrorMessage = "confirm password is required")]
        [MinLength(6, ErrorMessage = "must be 6 charctars at least")]
        [DataType(DataType.Password)]
        [Compare("passward", ErrorMessage = "please confirm your password,this is differ from password")]
        public string confirmPassword { get; set; }
        public virtual ICollection<Room> rooms { get; set; }
       public virtual ICollection<Booking> booking { get; set; }
        public virtual ICollection<Fedback> fedbacks { get; set; }
    }
}

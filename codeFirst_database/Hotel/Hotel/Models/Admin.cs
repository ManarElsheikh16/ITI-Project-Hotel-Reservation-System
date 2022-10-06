using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    class Admin
    {
        [Key]
        [ForeignKey("Department")]
        public int adminID { get; set; }
        [Required(ErrorMessage ="user name is required")]
        public string userName { get; set; }
        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "please enter valid email.")]

        public string email { get; set; }
        [Required(ErrorMessage ="password is required")]
        [MinLength(6, ErrorMessage = "must be 6 charctars at least")]
        [DataType(DataType.Password)]
        public string passward { get; set; }
        [Required(ErrorMessage = "confirm password is required")]
        [MinLength(6, ErrorMessage = "must be 6 charctars at least")]
        [DataType(DataType.Password)]
        [Compare("passward",ErrorMessage ="please confirm your password,this is differ from password")]
        public string confirmPassword { get; set; }
        // [ForeignKey("deptID")]
        //public int? deptID { get; set; }
        public virtual Department Department { get; set; }
    }
}

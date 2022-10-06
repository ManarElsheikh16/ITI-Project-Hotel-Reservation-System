using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelApp.Models
{
    [MetadataType(typeof(StaffsMetaData))]
    public partial class Staffs
    {

    }
    public class StaffsMetaData
    {
        [Display(Name ="Staff ID")]
        public int staffID { get; set; }

        [Required(ErrorMessage = "staff name is required")]
        [Display(Name = "Staff name")]
        public string staffName { get; set; }

        [Required(ErrorMessage = "gender is required")]
        [Display(Name = "gender")]
        public string gender { get; set; }

        [Required(ErrorMessage = "salary")]
        [Display(Name = "Salary")]
        [checkSalary]
        public double salary { get; set; }

        [Required(ErrorMessage = "address is required")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "please enter valid email.")]
        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Required(ErrorMessage = "phone number is required")]
        [StringLength(11, ErrorMessage = "phone number must be 11 charctar")]
        public string phone { get; set; }

        public Nullable<int> deptID { get; set; }
    }
}
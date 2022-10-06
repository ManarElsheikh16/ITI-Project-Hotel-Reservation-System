using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelApp.Models
{
    [MetadataType(typeof(DepartmentsMetaData))]
    public partial class Departments
    {
        

    }
    public class DepartmentsMetaData
    {
        [Display(Name = "Department ID")]
        public int deptID { get; set; }

        [Required(ErrorMessage = "department name is required")]
        [Display(Name = "Department name")]
        public string deptName { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    class Department
    {
       [Key]
        public int deptID { get; set; }
       [Required]
        public string deptName { get; set; }
        public virtual ICollection<Staff> staffs { get; set; }
        public virtual Admin Admin { get; set; }
    }
}

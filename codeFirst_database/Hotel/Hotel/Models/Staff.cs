using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    class Staff
    {
        [Key]
        public int staffID { get; set; }
        [Required]
        public string staffName { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public double salary { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="please enter a valid email")]
        public string email { get; set; }
        [Required]
        [StringLength(11,ErrorMessage ="phone num must be 11")]
        public string phone { get; set; }
        
        public int? deptID { get; set; }
        public virtual Department Department { get; set; }
    }
}

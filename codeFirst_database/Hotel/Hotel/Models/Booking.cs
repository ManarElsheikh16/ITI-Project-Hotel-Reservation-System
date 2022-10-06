using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    class Booking
    {
        [Key]
        public int bookID { get; set; }
        public bool smoking { get; set; }
        public bool petFriendly { get; set; }
        [Required]
        [DataType(DataType.Date,ErrorMessage ="please enter a valid date")]
        public DateTime checkIn { get; set; }
        [Required]
        [DataType(DataType.Date, ErrorMessage = "please enter a valid date")]
        public DateTime checkOut { get; set; }
        public string roomType { get; set; }
        public int numberOfBed { get; set; }
        public bool reserve { get; set; }
        public bool confirmPay { get; set; }
        public int? gusID { get; set; }
        public virtual Guset Guset { get; set; }
    }

}

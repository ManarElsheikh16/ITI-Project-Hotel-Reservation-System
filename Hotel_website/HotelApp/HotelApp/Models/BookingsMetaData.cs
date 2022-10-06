using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelApp.Models
{
    [MetadataType(typeof(BookingsMetaData))]
    public partial class Bookings
    {

    }
    public class BookingsMetaData
    {
        [Display(Name = "Book ID")]
        public int bookID { get; set; }

        [Display(Name = "Smoking")]
        public bool smoking { get; set; }

        [Display(Name = "Pet friendly")]
        public bool petFriendly { get; set; }

        [Required(ErrorMessage = "you must check in")]
        [Display(Name = "Check in")]
        [DataType(DataType.Date, ErrorMessage = "must be a valid date")]
        public System.DateTime checkIn { get; set; }

        [Required(ErrorMessage = "you must check out")]
        [Display(Name = "Check out")]
        [DataType(DataType.Date, ErrorMessage = "must be a valid date")]
        public System.DateTime checkOut { get; set; }

        [Display(Name = "Room type")]
        [Required(ErrorMessage = "room type is required")]
        public string roomType { get; set; }

        [Display(Name = "Number of bed")]
        [Required(ErrorMessage = "the number of bed is required ")]
        public int numberOfBed { get; set; }
        [Display(Name = "Guest ID")]
        public Nullable<int> gusID { get; set; }

        [Required(ErrorMessage = "this field is required to complete booking ")]
        public bool reserve { get; set; }

        [Required(ErrorMessage = "you must confirm your pay to complete booking ")]
        [Display(Name = "Confirm payment")]
        public bool confirmPay { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelApp.Models
{
    [MetadataType(typeof(RoomsMetaData))]
    public partial class Rooms
    {

    }
    public class RoomsMetaData
    {
        [Display(Name = "Room number")]
        public int roomNum { get; set; }

        [Required(ErrorMessage = "floor number is required")]
        [Display(Name = "Floor number")]
        public int floorNum { get; set; }

        [Required(ErrorMessage = "price is required")]
        [Display(Name = "Price")]
        public double price { get; set; }

        [Required(ErrorMessage = "number of bed is required")]
        [Display(Name = "number of bed")]
        public int numberOfBed { get; set; }

        [Required(ErrorMessage = "room type is required")]
        [Display(Name = "Room type")]
        public string roomType { get; set; }

        [Display(Name = "Smoking")]
        public bool smoking { get; set; }

        [Display(Name = "Pet friendly")]
        public bool petFriendly { get; set; }

        [Display(Name = "Guest ID")]
        public Nullable<int> gusID { get; set; }
    }
}
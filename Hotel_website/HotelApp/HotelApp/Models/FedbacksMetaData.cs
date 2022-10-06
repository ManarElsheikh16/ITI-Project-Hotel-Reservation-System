using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelApp.Models
{
    [MetadataType(typeof(FedbacksMetaData))]
    public partial class Fedbacks
    {

    }
    public class FedbacksMetaData
    {
        [Display(Name = "Room number")]
        public int roomNum { get; set; }

        [Required(ErrorMessage = "this rating is required")]
        [Range(1, 5, ErrorMessage = "the rating must be between 1 to 5")]
        [Display(Name = "Rating")]
        public int rating { get; set; }

        [Required(ErrorMessage = "the comment is required")]
        [Display(Name = "Comment")]
        public string comment { get; set; }

        [Required(ErrorMessage = "the date is required")]
        [DataType(DataType.Date, ErrorMessage = "must be a valid date")]
        [Display(Name = "Date")]
        public System.DateTime date { get; set; }

        [Display(Name = "Guest ID")]
        public Nullable<int> gusID { get; set; }

    }
}
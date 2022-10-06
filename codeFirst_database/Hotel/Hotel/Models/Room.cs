using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    class Room
    {
        [Key]
        public int roomNum { get; set; }
        public int floorNum { get; set; }
        public double price { get; set; }
        public int numberOfBed { get; set; }
        public string roomType { get; set; }
        public bool smoking { get; set; }
        public bool petFriendly { get; set; }
        public int? gusID { get; set; }
        public Guset Guest { get; set; }

    }
}

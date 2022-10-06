using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    class Fedback
    {
        [Key]
        public int roomNum { get; set; }

        public int rating { get; set; }
        public string comment { get; set; }
        [DataType(DataType.Date,ErrorMessage ="please enter a valid date")]
        public DateTime date { get; set; }
        public int? gusID { get; set; }
        public virtual Guset Guest { get; set; }


    }
}

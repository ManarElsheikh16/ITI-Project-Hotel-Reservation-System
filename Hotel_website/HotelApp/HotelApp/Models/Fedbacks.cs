//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fedbacks
    {
        public int roomNum { get; set; }
        public int rating { get; set; }
        public string comment { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> gusID { get; set; }
    
        public virtual Gusets Gusets { get; set; }
    }
}

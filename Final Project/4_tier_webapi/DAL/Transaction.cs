//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string Activity { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public Nullable<int> Sold { get; set; }
        public Nullable<int> Buy { get; set; }
        public Nullable<int> Profit { get; set; }
    
        public virtual User User { get; set; }
    }
}

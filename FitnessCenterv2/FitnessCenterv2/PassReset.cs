//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessCenterv2
{
    using System;
    using System.Collections.Generic;
    
    public partial class PassReset
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string EMail { get; set; }
        public string AutID { get; set; }
        public Nullable<bool> isAvaliable { get; set; }
        public string oldPass { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
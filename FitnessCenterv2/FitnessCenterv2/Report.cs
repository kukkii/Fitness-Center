//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessCenterv2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}

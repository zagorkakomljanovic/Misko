//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace konekcija
{
    using System;
    using System.Collections.Generic;
    
    public partial class LogException
    {
        public int ExceptionID { get; set; }
        public Nullable<int> CardholderID { get; set; }
        public Nullable<System.TimeSpan> Worktime { get; set; }
        public Nullable<bool> ExcIN_OUT { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Cardholder Cardholder { get; set; }
    }
}

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
    
    public partial class Card
    {
        public int CardID { get; set; }
        public string CardNo { get; set; }
        public string CardNoIntCode { get; set; }
        public Nullable<int> CardholderID { get; set; }
    
        public virtual Cardholder Cardholder { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MojaEntities : DbContext
    {
        public MojaEntities()
            : base("name=MojaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccessLog> AccessLogs { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Cardholder> Cardholders { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<LogException> LogExceptions { get; set; }
        public virtual DbSet<NonWorkingDay> NonWorkingDays { get; set; }
    }
}

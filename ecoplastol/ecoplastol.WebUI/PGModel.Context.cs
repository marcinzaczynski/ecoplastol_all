﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecoplastol.WebUI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ecoplastolEntities : DbContext
    {
        public ecoplastolEntities()
            : base("name=ecoplastolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<maszyny> maszyny { get; set; }
        public virtual DbSet<meldunki> meldunki { get; set; }
        public virtual DbSet<meldunki_wady_nn> meldunki_wady_nn { get; set; }
        public virtual DbSet<meldunki_wynik> meldunki_wynik { get; set; }
        public virtual DbSet<meldunki_wynik_prz_maszyny> meldunki_wynik_prz_maszyny { get; set; }
        public virtual DbSet<operatorzy_maszyn> operatorzy_maszyn { get; set; }
        public virtual DbSet<zlecenia_produkcyjne> zlecenia_produkcyjne { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KuaförRandevuSistemi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbRandevuEntities3 : DbContext
    {
        public DbRandevuEntities3()
            : base("name=DbRandevuEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblKullanici> TblKullanici { get; set; }
        public virtual DbSet<TblMusteri> TblMusteri { get; set; }
        public virtual DbSet<TblRandevu> TblRandevu { get; set; }
        public virtual DbSet<TblTras> TblTras { get; set; }
        public virtual DbSet<TblKasa> TblKasa { get; set; }
        public virtual DbSet<TblKasaCikis> TblKasaCikis { get; set; }
        public virtual DbSet<TblNotlar> TblNotlar { get; set; }
        public virtual DbSet<TblLisans> TblLisans { get; set; }
    }
}

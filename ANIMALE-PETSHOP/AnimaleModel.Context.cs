﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ANIMALE_PETSHOP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AnimalePetshop : DbContext
    {
        public AnimalePetshop()
            : base("name=AnimalePetshop")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGENDAMENTO> AGENDAMENTO { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<FUNCIONARIO> FUNCIONARIO { get; set; }
        public virtual DbSet<LOGIN> LOGIN { get; set; }
        public virtual DbSet<PET> PET { get; set; }
        public virtual DbSet<SERVICO> SERVICO { get; set; }
        public virtual DbSet<TIPO_SERVICO> TIPO_SERVICO { get; set; }
    }
}
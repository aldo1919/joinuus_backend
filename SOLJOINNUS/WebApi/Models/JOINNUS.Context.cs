﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JOINNUSEntities1 : DbContext
    {
        public JOINNUSEntities1()
            : base("name=JOINNUSEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BOLETA> BOLETA { get; set; }
        public virtual DbSet<CANTMAX> CANTMAX { get; set; }
        public virtual DbSet<CANTMIN> CANTMIN { get; set; }
        public virtual DbSet<CANTXUSU> CANTXUSU { get; set; }
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<CIUDAD> CIUDAD { get; set; }
        public virtual DbSet<COMPRA> COMPRA { get; set; }
        public virtual DbSet<ENTRADA> ENTRADA { get; set; }
        public virtual DbSet<EVENTO> EVENTO { get; set; }
        public virtual DbSet<FINVENTA> FINVENTA { get; set; }
        public virtual DbSet<GENERO> GENERO { get; set; }
        public virtual DbSet<METPAGO> METPAGO { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<TB_USUARIO> TB_USUARIO { get; set; }
        public virtual DbSet<TICKET> TICKET { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tourdulichEntities : DbContext
    {
        public tourdulichEntities()
            : base("name=tourdulichEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chitietdiemthamquan> chitietdiemthamquan { get; set; }
        public virtual DbSet<chitietdoandulich> chitietdoandulich { get; set; }
        public virtual DbSet<chitietthanhtoan> chitietthanhtoan { get; set; }
        public virtual DbSet<diadiem> diadiem { get; set; }
        public virtual DbSet<doandulich> doandulich { get; set; }
        public virtual DbSet<giatour> giatour { get; set; }
        public virtual DbSet<gioitinh> gioitinh { get; set; }
        public virtual DbSet<khachhang> khachhang { get; set; }
        public virtual DbSet<loaihinhdulich> loaihinhdulich { get; set; }
        public virtual DbSet<loaiphieu> loaiphieu { get; set; }
        public virtual DbSet<nhanvien> nhanvien { get; set; }
        public virtual DbSet<nhiemvu> nhiemvu { get; set; }
        public virtual DbSet<phancong> phancong { get; set; }
        public virtual DbSet<phieuthanhtoan> phieuthanhtoan { get; set; }
        public virtual DbSet<tinhthanh> tinhthanh { get; set; }
        public virtual DbSet<tour> tour { get; set; }
    }
}
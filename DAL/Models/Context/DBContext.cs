using System;
using System.Collections.Generic;
using DAL.Models.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bangluong> Bangluongs { get; set; }

    public virtual DbSet<Chatlieu> Chatlieus { get; set; }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Giaoca> Giaocas { get; set; }

    public virtual DbSet<Giaocanhanvien> Giaocanhanviens { get; set; }

    public virtual DbSet<Giay> Giays { get; set; }

    public virtual DbSet<Giaychitiet> Giaychitiets { get; set; }

    public virtual DbSet<Hinhthucthanhtoan> Hinhthucthanhtoans { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Kichco> Kichcos { get; set; }

    public virtual DbSet<Kieudang> Kieudangs { get; set; }

    public virtual DbSet<Mausac> Mausacs { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    public virtual DbSet<Uudai> Uudais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= ACER\\SQLEXPRESS ;Initial Catalog= DBGIAY_DUAN1;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bangluong>(entity =>
        {
            entity.HasKey(e => e.Maluong).HasName("PK__BANGLUON__D9BA4D0057D112E1");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Bangluongs).HasConstraintName("FK__BANGLUONG__MATAI__3C69FB99");
        });

        modelBuilder.Entity<Chatlieu>(entity =>
        {
            entity.HasKey(e => e.Machatlieu).HasName("PK__CHATLIEU__80F939F80EA9AC28");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Chatlieus).HasConstraintName("FK__CHATLIEU__MATAIK__5441852A");
        });

        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Machucvu).HasName("PK__CHUCVU__9FA9FD6A240A0339");
        });

        modelBuilder.Entity<Giaoca>(entity =>
        {
            entity.HasKey(e => e.Magiaoca).HasName("PK__GIAOCA__7D3545CC35E266F0");
        });

        modelBuilder.Entity<Giaocanhanvien>(entity =>
        {
            entity.HasKey(e => e.Magiaocanhanvien).HasName("PK__GIAOCANH__B0F1BCFD4AEF1DA4");

            entity.HasOne(d => d.MagiaocaNavigation).WithMany(p => p.Giaocanhanviens).HasConstraintName("FK__GIAOCANHA__MAGIA__4222D4EF");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Giaocanhanviens).HasConstraintName("FK__GIAOCANHA__MATAI__412EB0B6");
        });

        modelBuilder.Entity<Giay>(entity =>
        {
            entity.HasKey(e => e.Magiay).HasName("PK__GIAY__0C880C58A0C25B9C");
        });

        modelBuilder.Entity<Giaychitiet>(entity =>
        {
            entity.HasKey(e => e.Magiaychitiet).HasName("PK__GIAYCHIT__196AD703E7B280FD");

            entity.HasOne(d => d.MachatlieuNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MACHA__628FA481");

            entity.HasOne(d => d.MagiayNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MAGIA__619B8048");

            entity.HasOne(d => d.MakichcoNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MAKIC__6477ECF3");

            entity.HasOne(d => d.MakieudangNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MAKIE__68487DD7");

            entity.HasOne(d => d.MamausacNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MAMAU__6383C8BA");

            entity.HasOne(d => d.MathuonghieuNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MATHU__6754599E");

            entity.HasOne(d => d.NguoisuaNavigation).WithMany(p => p.GiaychitietNguoisuaNavigations).HasConstraintName("FK__GIAYCHITI__NGUOI__66603565");

            entity.HasOne(d => d.NguoitaoNavigation).WithMany(p => p.GiaychitietNguoitaoNavigations).HasConstraintName("FK__GIAYCHITI__NGUOI__656C112C");
        });

        modelBuilder.Entity<Hinhthucthanhtoan>(entity =>
        {
            entity.HasKey(e => e.Mahinhthucthanhtoan).HasName("PK__HINHTHUC__C3B2561FBF0AB054");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahoadon).HasName("PK__HOADON__A4999DF5C7EAB372");

            entity.HasOne(d => d.MahinhthucthanhtoanNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MAHINHTH__4E88ABD4");

            entity.HasOne(d => d.MakhachhangNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MAKHACHH__4D94879B");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MATAIKHO__4BAC3F29");

            entity.HasOne(d => d.MauudaiNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MAUUDAI__4CA06362");
        });

        modelBuilder.Entity<Hoadonchitiet>(entity =>
        {
            entity.HasKey(e => e.Mahoadonchitiet).HasName("PK__HOADONCH__EF957FF0B4388D12");

            entity.HasOne(d => d.MagiaychitietNavigation).WithMany(p => p.Hoadonchitiets).HasConstraintName("FK__HOADONCHI__MAGIA__6B24EA82");

            entity.HasOne(d => d.MahoadonNavigation).WithMany(p => p.Hoadonchitiets).HasConstraintName("FK__HOADONCHI__MAHOA__6C190EBB");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makhachhang).HasName("PK__KHACHHAN__30035C2FACF0F211");
        });

        modelBuilder.Entity<Kichco>(entity =>
        {
            entity.HasKey(e => e.Makichco).HasName("PK__KICHCO__7EDFFF29766B2C9D");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Kichcos).HasConstraintName("FK__KICHCO__MATAIKHO__59FA5E80");
        });

        modelBuilder.Entity<Kieudang>(entity =>
        {
            entity.HasKey(e => e.Makieudang).HasName("PK__KIEUDANG__877F27F21863C5F1");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Kieudangs).HasConstraintName("FK__KIEUDANG__MATAIK__5CD6CB2B");
        });

        modelBuilder.Entity<Mausac>(entity =>
        {
            entity.HasKey(e => e.Mamausac).HasName("PK__MAUSAC__99E7A68F031EFCBC");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Mausacs).HasConstraintName("FK__MAUSAC__MATAIKHO__571DF1D5");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Mataikhoan).HasName("PK__TAIKHOAN__2ED8B5177B8081EA");

            entity.HasOne(d => d.MachucvuNavigation).WithMany(p => p.Taikhoans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TAIKHOAN__MACHUC__398D8EEE");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.Mathuonghieu).HasName("PK__THUONGHI__B319F63865BD7045");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Thuonghieus).HasConstraintName("FK__THUONGHIE__MATAI__5165187F");
        });

        modelBuilder.Entity<Uudai>(entity =>
        {
            entity.HasKey(e => e.Mauudai).HasName("PK__UUDAI__3F58B4FDB9552319");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Uudais).HasConstraintName("FK__UUDAI__MATAIKHOA__46E78A0C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

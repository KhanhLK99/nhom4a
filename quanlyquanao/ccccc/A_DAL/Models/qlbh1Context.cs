using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ccccc.A_DAL.Models
{
    public partial class qlbh1Context : DbContext
    {
        public qlbh1Context()
        {
        }

        public qlbh1Context(DbContextOptions<qlbh1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Dangnhap> Dangnhaps { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LKK\\SQLEXPRESS;Database=qlbh1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dangnhap>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__dangnhap__F3DBC573FBA9DE77");

                entity.ToTable("dangnhap");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .HasColumnName("username");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(10)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

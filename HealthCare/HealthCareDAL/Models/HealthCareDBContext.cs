using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HealthCareDAL.Models
{
    public partial class HealthCareDBContext : DbContext
    {
        public HealthCareDBContext()
        {
        }

        public HealthCareDBContext(DbContextOptions<HealthCareDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<QuaterInfo> QuaterInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=HealthCareDB;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductsId)
                    .HasName("ProductsId");

                entity.Property(e => e.ProductsId).HasColumnName("productsId");

                entity.Property(e => e.About)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("about");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.SaltComposition)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("saltComposition");

                entity.Property(e => e.SideEffectsDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sideEffectsDescription");

                entity.Property(e => e.UseDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("useDescription");
            });

            modelBuilder.Entity<QuaterInfo>(entity =>
            {
                entity.ToTable("QuaterInfo");

                entity.Property(e => e.QuaterInfoId).HasColumnName("quaterInfoId");

                entity.Property(e => e.Depreciation).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossProfit)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("grossProfit");

                entity.Property(e => e.Interest).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NetProfit)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("netProfit");

                entity.Property(e => e.OtherIncome)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("otherIncome");

                entity.Property(e => e.Quater)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("quater");

                entity.Property(e => e.Sales)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("sales");

                entity.Property(e => e.Tax).HasColumnType("decimal(10, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

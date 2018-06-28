using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mobilePhoneSalesWebSite.Models
{
    public partial class DDATABASEDATADEMOMDFContext : DbContext
    {
        public DDATABASEDATADEMOMDFContext()
        {
        }

        public DDATABASEDATADEMOMDFContext(DbContextOptions<DDATABASEDATADEMOMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<School> School { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Database\\DataDemo.mdf;Integrated Security=True;Connect Timeout=30");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.Property(e => e.ObjId).ValueGeneratedNever();

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(10);

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasColumnName("img")
                    .HasMaxLength(200);

                entity.Property(e => e.Introduce)
                    .IsRequired()
                    .HasColumnName("introduce")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasMaxLength(10);

                entity.Property(e => e.Price2)
                    .IsRequired()
                    .HasColumnName("price2")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Site).HasMaxLength(200);
            });
        }
    }
}

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

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<School> School { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Database\\DataDemo.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.Property(e => e.ObjId).HasColumnName("objId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.TheCity).HasColumnName("theCity");

                entity.HasOne(d => d.TheCityNavigation)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.TheCity)
                    .HasConstraintName("FK__Area__theCity__412EB0B6");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.Property(e => e.ObjId).HasColumnName("objId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(14);

                entity.Property(e => e.TheProvince).HasColumnName("theProvince");

                entity.HasOne(d => d.TheProvinceNavigation)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.TheProvince)
                    .HasConstraintName("FK__City__theProvinc__440B1D61");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.Property(e => e.ObjId).HasColumnName("objId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNum).HasMaxLength(12);

                entity.Property(e => e.Receiver).HasMaxLength(20);

                entity.Property(e => e.TheArea).HasColumnName("theArea");

                entity.HasOne(d => d.TheAreaNavigation)
                    .WithMany(p => p.Division)
                    .HasForeignKey(d => d.TheArea)
                    .HasConstraintName("FK__Division__theAre__46E78A0C");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.Property(e => e.ObjId).HasColumnName("objId");

                entity.Property(e => e.Amt).HasColumnName("amt");

                entity.Property(e => e.OrderTime)
                    .HasColumnName("orderTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TheArea).HasColumnName("theArea");

                entity.Property(e => e.TheCity).HasColumnName("theCity");

                entity.Property(e => e.TheDivision).HasColumnName("theDivision");

                entity.Property(e => e.ThePayment).HasColumnName("thePayment");

                entity.Property(e => e.ThePhone).HasColumnName("thePhone");

                entity.Property(e => e.TheProvince).HasColumnName("theProvince");

                entity.HasOne(d => d.TheAreaNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.TheArea)
                    .HasConstraintName("FK__Order__theArea__52593CB8");

                entity.HasOne(d => d.TheCityNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.TheCity)
                    .HasConstraintName("FK__Order__theCity__5165187F");

                entity.HasOne(d => d.TheDivisionNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.TheDivision)
                    .HasConstraintName("FK__Order__theDivisi__534D60F1");

                entity.HasOne(d => d.ThePaymentNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ThePayment)
                    .HasConstraintName("FK__Order__thePaymen__4F7CD00D");

                entity.HasOne(d => d.ThePhoneNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ThePhone)
                    .HasConstraintName("FK__Order__thePhone__4E88ABD4");

                entity.HasOne(d => d.TheProvinceNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.TheProvince)
                    .HasConstraintName("FK__Order__theProvin__5070F446");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.Property(e => e.ObjId).HasColumnName("objId");

                entity.Property(e => e.AccountName)
                    .HasColumnName("accountName")
                    .HasMaxLength(20);

                entity.Property(e => e.AccountNo)
                    .HasColumnName("accountNo")
                    .HasMaxLength(24);

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.PaymentState).HasColumnName("paymentState");

                entity.Property(e => e.ThePaymentType).HasColumnName("thePaymentType");

                entity.Property(e => e.TransNo)
                    .HasColumnName("transNo")
                    .HasMaxLength(16);

                entity.Property(e => e.TransTime)
                    .HasColumnName("transTime")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ThePaymentTypeNavigation)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.ThePaymentType)
                    .HasConstraintName("FK__Payment__thePaym__4BAC3F29");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.Property(e => e.ObjId).HasColumnName("objId");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(16);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasKey(e => e.ObjId);

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

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.Property(e => e.ObjId).HasColumnName("objId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
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

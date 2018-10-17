using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SendMyTesla.Config;

namespace SendMyTesla.Models
{
    public partial class MyteslaContext : DbContext
    {
        public MyteslaContext()
        {
        }

        public MyteslaContext(DbContextOptions<MyteslaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Dispatches> Dispatches { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Parts> Parts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql($"Server=localhost;Database=mytesla;User=root;Pwd={Credentials.DB_PASSWORD}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>(entity =>
            {
                entity.ToTable("cars");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BasePrice)
                    .HasColumnName("base_price")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phone_number")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Dispatches>(entity =>
            {
                entity.ToTable("dispatches");

                entity.HasIndex(e => e.ClientId)
                    .HasName("client_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Dispatches)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("dispatches_ibfk_1");
            });

            modelBuilder.Entity<Options>(entity =>
            {
                entity.ToTable("options");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(8,2)")
                    .HasDefaultValueSql("'0.00'");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("orders");

                entity.HasIndex(e => e.CarId)
                    .HasName("car_id");

                entity.HasIndex(e => e.DispatchId)
                    .HasName("dispatch_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarId)
                    .HasColumnName("car_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DispatchId)
                    .HasColumnName("dispatch_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("orders_ibfk_1");

                entity.HasOne(d => d.Dispatch)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.DispatchId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("orders_ibfk_2");
            });

            modelBuilder.Entity<Parts>(entity =>
            {
                entity.ToTable("parts");

                entity.HasIndex(e => e.CarId)
                    .HasName("car_id");

                entity.HasIndex(e => e.OptionId)
                    .HasName("option_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarId)
                    .HasColumnName("car_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("parts_ibfk_1");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.OptionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("parts_ibfk_2");
            });
        }
    }
}

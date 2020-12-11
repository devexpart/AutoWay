using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AutoWay.Models
{
    public partial class AutoWayContext : DbContext
    {
        public AutoWayContext()
        {
        }

        public AutoWayContext(DbContextOptions<AutoWayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserPassword> UserPasswords { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleImage> VehicleImages { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-48LB9LF\\SQLEXPRESS;Database=AutoWay;Trusted_Connection=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>(entity =>
            {
                entity.ToTable("Owner");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Contact).IsUnicode(false);

                entity.Property(e => e.CreatedAt).IsUnicode(false);

                entity.Property(e => e.OwnerFname)
                    .IsUnicode(false)
                    .HasColumnName("OwnerFName");

                entity.Property(e => e.OwnerLname)
                    .IsUnicode(false)
                    .HasColumnName("OwnerLName");

                entity.Property(e => e.UpdatedAt).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Owners)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Owner_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserPassword>(entity =>
            {
                entity.ToTable("UserPassword");

                entity.Property(e => e.AuthKey).IsUnicode(false);

                entity.Property(e => e.CreatedAt).IsUnicode(false);

                entity.Property(e => e.PasswordHash).IsUnicode(false);

                entity.Property(e => e.PasswordResetToken).IsUnicode(false);

                entity.Property(e => e.UpdatedAt).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPasswords)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPassword_User");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.KmsDrivce)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_Owner");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_VehicleType");
            });

            modelBuilder.Entity<VehicleImage>(entity =>
            {
                entity.ToTable("VehicleImage");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("filePath");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VehicleImages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleImage_User");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleImages)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleImage_VehicleId");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.ToTable("VehicleType");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.VehicleTypeName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleTypes)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vehicle_VehicleID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

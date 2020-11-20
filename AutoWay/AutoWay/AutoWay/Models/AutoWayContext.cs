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

        public virtual DbSet<TbVhclImg> TbVhclImgs { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserType> TblUserTypes { get; set; }
        public virtual DbSet<TblVehicle> TblVehicles { get; set; }
        public virtual DbSet<TblVehicleType> TblVehicleTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-48LB9LF\\SQLEXPRESS;Database=AutoWay;Trusted_Connection=True;");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbVhclImg>(entity =>
            {
                entity.ToTable("tb_vhcl_img");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("file_path");

                entity.Property(e => e.VhclId).HasColumnName("vhcl_id");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.AuthKey)                    
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("auth_key");

                entity.Property(e => e.City)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasMaxLength(255)              
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.PasswordHash)                  
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password_hash");

                entity.Property(e => e.PasswordResetToken)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password_reset_token");

                entity.Property(e => e.Password)
                      .IsRequired()
                      .HasMaxLength(255)
                      .IsUnicode(false)
                      .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedAt)                   
                    .HasMaxLength(255)
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserTypeId).HasColumnName("user_type_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<TblUserType>(entity =>
            {
                entity.ToTable("tbl_user_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("type_name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<TblVehicle>(entity =>
            {
                entity.ToTable("tbl_vehicle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.KmsDriven)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("kms_driven");

                entity.Property(e => e.LastRentedBy).HasColumnName("last_rented_by");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("manufacturer");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.Rent)
                    .IsUnicode(false)
                    .HasColumnName("rent");

                entity.Property(e => e.SellingPrice)
                    .IsUnicode(false)
                    .HasColumnName("selling_price");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VhclName)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("vhcl_name");

                entity.Property(e => e.VhclTypeId).HasColumnName("vhcl_type_id");
            });

            modelBuilder.Entity<TblVehicleType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_vehicle_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VhclId).HasColumnName("vhcl_id");

                entity.Property(e => e.VhclTypeName)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("vhcl_type_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

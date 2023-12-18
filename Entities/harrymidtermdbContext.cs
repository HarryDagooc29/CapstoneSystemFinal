using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HarryMidterm.Entities
{
    public partial class harrymidtermdbContext : DbContext
    {
        public harrymidtermdbContext()
        {
        }

        public harrymidtermdbContext(DbContextOptions<harrymidtermdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accountingstaff> Accountingstaffs { get; set; }
        public virtual DbSet<Addloanrecord> Addloanrecords { get; set; }
        public virtual DbSet<Capital> Capitals { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Newborrower> Newborrowers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderdetail> Orderdetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Stockhistory> Stockhistories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=harrymidtermdb;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Accountingstaff>(entity =>
            {
                entity.ToTable("accountingstaff");

                entity.Property(e => e.AccountingStaffId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AccountingStaffID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Addloanrecord>(entity =>
            {
                entity.ToTable("addloanrecords");

                entity.Property(e => e.AddloanrecordId)
                    .HasColumnType("int(11)")
                    .HasColumnName("addloanrecordID");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LoanTermDays).HasMaxLength(250);

                entity.Property(e => e.LoanTermMonths).HasMaxLength(250);

                entity.Property(e => e.PrincipalAmount).HasColumnType("int(250)");
            });

            modelBuilder.Entity<Capital>(entity =>
            {
                entity.ToTable("capital");

                entity.Property(e => e.CapitalId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CapitalID");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart");

                entity.Property(e => e.CartId).HasColumnType("int(11)");

                entity.Property(e => e.CmockStock)
                    .HasColumnType("int(250)")
                    .HasColumnName("CMockStock");

                entity.Property(e => e.CmockTotal)
                    .HasColumnType("int(250)")
                    .HasColumnName("CMockTotal");

                entity.Property(e => e.Cquantity)
                    .HasColumnType("int(250)")
                    .HasColumnName("CQuantity");

                entity.Property(e => e.ProdId).HasColumnType("int(250)");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login");

                entity.Property(e => e.LoginId)
                    .HasColumnType("int(11)")
                    .HasColumnName("LoginID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Newborrower>(entity =>
            {
                entity.ToTable("newborrower");

                entity.Property(e => e.NewBorrowerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("NewBorrowerID");

                entity.Property(e => e.BirthDate)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.BirthPlace)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Salary).HasColumnType("int(250)");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ZipCode).HasColumnType("int(250)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.OrderId).HasColumnType("int(11)");

                entity.Property(e => e.Datepurchased)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Deduction)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DiscountPercent)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PaidAmount)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SubTotal)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Sukli)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TotalAmount)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Orderdetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailsId)
                    .HasName("PRIMARY");

                entity.ToTable("orderdetail");

                entity.Property(e => e.OrderDetailsId).HasColumnType("int(11)");

                entity.Property(e => e.OrderId).HasColumnType("int(250)");

                entity.Property(e => e.ProductId).HasColumnType("int(250)");

                entity.Property(e => e.ProductTotal)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Quantity).HasColumnType("int(250)");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("category");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("price");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("status");

                entity.Property(e => e.Stock)
                    .HasColumnType("int(11)")
                    .HasColumnName("stock");

                entity.Property(e => e.Units)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("units");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("schedule");

                entity.Property(e => e.ScheduleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ScheduleID");

                entity.Property(e => e.AddloanrecordId)
                    .HasColumnType("int(11)")
                    .HasColumnName("addloanrecordID");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Stockhistory>(entity =>
            {
                entity.HasKey(e => e.AStockId)
                    .HasName("PRIMARY");

                entity.ToTable("stockhistory");

                entity.Property(e => e.AStockId)
                    .HasColumnType("int(11)")
                    .HasColumnName("a_Stock_ID");

                entity.Property(e => e.AddedStock)
                    .HasColumnType("int(11)")
                    .HasColumnName("added_stock");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("date");

                entity.Property(e => e.ProdId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prodID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.Property(e => e.DeleteStatus).HasColumnName("delete_status");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName).HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

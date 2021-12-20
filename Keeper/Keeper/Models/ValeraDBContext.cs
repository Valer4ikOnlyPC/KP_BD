using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Keeper.Models
{
    public partial class ValeraDBContext : DbContext
    {
        public ValeraDBContext()
        {
        }

        public ValeraDBContext(DbContextOptions<ValeraDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<CoffeeHouse> CoffeeHouses { get; set; } = null!;
        public virtual DbSet<CoffeeShopExpense> CoffeeShopExpenses { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderAndItem> OrderAndItems { get; set; } = null!;
        public virtual DbSet<Position> Positions { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<RevenuePerDay> RevenuePerDays { get; set; } = null!;
        public virtual DbSet<SalaryPayment> SalaryPayments { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ValeraDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CoffeeHouse>(entity =>
            {
                entity.HasKey(e => e.CoffeeShopId)
                    .HasName("PK__Coffee_h__E824BF3E8B920B60");

                entity.ToTable("Coffee_house");

                entity.Property(e => e.CoffeeShopId).HasColumnName("coffee_shop_ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.EndOfWork).HasColumnName("End_of_work");

                entity.Property(e => e.Start).HasColumnType("time(0)");
            });

            modelBuilder.Entity<CoffeeShopExpense>(entity =>
            {
                entity.HasKey(e => e.ExpenseId)
                    .HasName("PK__Coffee_s__404A76538385959D");

                entity.ToTable("Coffee_shop_expense");

                entity.Property(e => e.ExpenseId).HasColumnName("expense_ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CoffeeShopId).HasColumnName("coffee_shop_ID");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.ExpenseTypeId).HasColumnName("expense_type_ID");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("Payment_date");

                entity.HasOne(d => d.CoffeeShop)
                    .WithMany(p => p.CoffeeShopExpenses)
                    .HasForeignKey(d => d.CoffeeShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Coffee_sh__coffe__2B3F6F97");

                entity.HasOne(d => d.ExpenseType)
                    .WithMany(p => p.CoffeeShopExpenses)
                    .HasForeignKey(d => d.ExpenseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Coffee_sh__expen__2C3393D0");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.Seniority, "NonClustEmp");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.CoffeeHouseId).HasColumnName("Coffee_House_ID");

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Patronymice).HasMaxLength(50);

                entity.Property(e => e.PositionId).HasColumnName("Position_ID");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.HasOne(d => d.CoffeeHouse)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CoffeeHouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Coffee__36B12243");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Positi__37A5467C");
            });

            modelBuilder.Entity<ExpenseType>(entity =>
            {
                entity.ToTable("Expense_type");

                entity.Property(e => e.ExpenseTypeId).HasColumnName("expense_type_ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.HasIndex(e => e.Table, "NonClustOrder");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.OrderAmount)
                    .HasColumnType("money")
                    .HasColumnName("Order_Amount");

                entity.Property(e => e.Status).HasMaxLength(11);

                entity.Property(e => e.Time).HasColumnType("time(0)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__Employee___3D5E1FD2");
            });

            modelBuilder.Entity<OrderAndItem>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId });

                entity.ToTable("Order_and_Item");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderAndItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_and_Item_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderAndItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_and_Item_Product");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position");

                entity.Property(e => e.PositionId).HasColumnName("Position_ID");

                entity.Property(e => e.Rfp)
                    .HasColumnType("money")
                    .HasColumnName("RFP");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.CategoryId).HasColumnName("category_ID");

                entity.Property(e => e.CoffeeShopId).HasColumnName("coffee_shop_ID");

                entity.Property(e => e.DateOfWriteOff)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_write_off");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__categor__31EC6D26");

                entity.HasOne(d => d.CoffeeShop)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CoffeeShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Coffee_house");
            });

            modelBuilder.Entity<RevenuePerDay>(entity =>
            {
                entity.HasKey(e => e.RevenueId)
                    .HasName("PK__Revenue___C8AB41139262551D");

                entity.ToTable("Revenue_per_day");

                entity.Property(e => e.RevenueId).HasColumnName("Revenue_ID");

                entity.Property(e => e.CoffeeHouseId).HasColumnName("Coffee_House_ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.RevenueAmount)
                    .HasColumnType("money")
                    .HasColumnName("Revenue_Amount");

                entity.Property(e => e.RevenueRatio).HasColumnName("Revenue_Ratio");

                entity.HasOne(d => d.CoffeeHouse)
                    .WithMany(p => p.RevenuePerDays)
                    .HasForeignKey(d => d.CoffeeHouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Revenue_p__Coffe__267ABA7A");
            });

            modelBuilder.Entity<SalaryPayment>(entity =>
            {
                entity.HasKey(e => e.PayoutId)
                    .HasName("PK__Salary_p__3B0854140CB68B0D");

                entity.ToTable("Salary_payment");

                entity.Property(e => e.PayoutId).HasColumnName("payout_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_ID");

                entity.Property(e => e.PayoutDate)
                    .HasColumnType("date")
                    .HasColumnName("payout_date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SalaryPayments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Salary_pa__emplo__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

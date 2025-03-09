using ConsoleApp2.Configurations;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ESLAMS3DAWY; Database = CompanyCodeFirst; Integrated Security = True; TRUSTSERVERCERTIFICATE = TRUE;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .ToTable(tb => tb.HasTrigger("DeptReadOnly"));

            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());

            modelBuilder.Entity<DeptProject>()
                .Property(e => e.Date)
                .HasColumnName("Date");

            //Fluent API
              //One to One
                  //First Direction
              modelBuilder.Entity<Employee>()
                  .HasOne(a => a.address)
                  .WithOne(a => a.employee)
                  .HasForeignKey<Employee>(a => a.AddressId);

                  //Second Direction
              modelBuilder.Entity<EmpAddress>()
                  .HasOne(a => a.employee)
                  .WithOne(a => a.address)
                  .HasForeignKey<Employee>(a => a.AddressId);

              //One to Many
                  //First Direction
              modelBuilder.Entity<Employee>()
                  .HasOne(a => a.department)
                  .WithMany(a => a.employees)
                  .HasForeignKey(a => a.DepartmentId);

                  //Second Direction
              modelBuilder.Entity<Department>()
                  .HasMany(a => a.employees)
                  .WithOne(a => a.department)
                  .HasForeignKey(a => a.DepartmentId);

            //Many to Many
            //if there are NO properties on the relation
            //modelBuilder.Entity<Department>()
            //    .HasMany(a => a.projects)
            //    .WithMany(a => a.departments);

            //if there are properties on the relation
            modelBuilder.Entity<DeptProject>()
            .HasKey(a => new { a.ProjId, a.DeptId });


            //List<EmpAddress> Addresses = new List<EmpAddress>()
            //{
            //    new EmpAddress
            //    {
            //        EmpAddressId = 2,
            //        Address = "October",
            //    }
            //};

            //modelBuilder.Entity<EmpAddress>()
            //    .HasData(Addresses);

            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Employee>()
            //    .HasIndex(a => a.Salary)
            //    .IsUnique(true);

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Salary)
                .IsUnique()
                .HasFilter(null);
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<EmpAddress> EmployeeAddress { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}

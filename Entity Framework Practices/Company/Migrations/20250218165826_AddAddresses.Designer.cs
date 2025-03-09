﻿// <auto-generated />
using System;
using ConsoleApp2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp2.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20250218165826_AddAddresses")]
    partial class AddAddresses
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp2.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ConsoleApp2.Models.DeptProject", b =>
                {
                    b.Property<int>("ProjId")
                        .HasColumnType("int");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("ProjId", "DeptId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProjectId");

                    b.ToTable("DeptProject");
                });

            modelBuilder.Entity("ConsoleApp2.Models.EmpAddress", b =>
                {
                    b.Property<int>("EmpAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpAddressId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("EmpAddressId");

                    b.ToTable("EmployeeAddress");

                    b.HasData(
                        new
                        {
                            EmpAddressId = 1,
                            Address = "October",
                            EmployeeId = 0
                        });
                });

            modelBuilder.Entity("ConsoleApp2.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasComputedColumnSql("DATEDIFF(Year, BirthDate, GETDATE())");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(6000m);

                    b.HasKey("EmployeeId");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ConsoleApp2.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ConsoleApp2.Models.DeptProject", b =>
                {
                    b.HasOne("ConsoleApp2.Models.Department", "department")
                        .WithMany("DeptProjects")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp2.Models.Project", "project")
                        .WithMany("DeptProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");

                    b.Navigation("project");
                });

            modelBuilder.Entity("ConsoleApp2.Models.Employee", b =>
                {
                    b.HasOne("ConsoleApp2.Models.EmpAddress", "address")
                        .WithOne("employee")
                        .HasForeignKey("ConsoleApp2.Models.Employee", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp2.Models.Department", "department")
                        .WithMany("employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("address");

                    b.Navigation("department");
                });

            modelBuilder.Entity("ConsoleApp2.Models.Department", b =>
                {
                    b.Navigation("DeptProjects");

                    b.Navigation("employees");
                });

            modelBuilder.Entity("ConsoleApp2.Models.EmpAddress", b =>
                {
                    b.Navigation("employee")
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp2.Models.Project", b =>
                {
                    b.Navigation("DeptProjects");
                });
#pragma warning restore 612, 618
        }
    }
}

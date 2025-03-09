using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Configurations
{
    class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(a => a.Name)
                   .IsRequired()
                   .HasMaxLength(25);
            builder.Property(a => a.Salary)
                   .HasDefaultValue(6000);
            builder.Property(a => a.Age)
                   .HasComputedColumnSql("DATEDIFF(Year, BirthDate, GETDATE())");
            builder.HasQueryFilter(a => !a.IsDeleted);
        }
    }
}

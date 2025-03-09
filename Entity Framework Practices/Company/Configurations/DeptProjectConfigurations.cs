using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Configurations
{
    class DeptProjectConfigurations : IEntityTypeConfiguration<DeptProject>
    {
        public void Configure(EntityTypeBuilder<DeptProject> builder)
        {
            builder
                .Property(e => e.Date)
                .HasColumnName("Date");
        }
    }
}

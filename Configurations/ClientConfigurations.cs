using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaCare.Configurations
{
    class ClientConfigurations : IEntityTypeConfiguration<Client>
    {
        //Required : NOT NULL
        //Nullable or ? : ALLOW NULL

        //HasMaxLength
        //HasMinLength

        //HasDefaultValue
        //HasComputedColumnSql

        //HasQueryFilter
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.HashPassword)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(c => c.FName)
                   .IsRequired()
                   .HasMaxLength(15)
                   .HasColumnOrder(2);

            builder.Property(c => c.LName)
                   .HasMaxLength(15)
                   .HasColumnOrder(3);

            builder.Property(c => c.ClientAge)
                   .IsRequired()
                   .HasComputedColumnSql("DATEDIFF(Year, BirthDate, GETDATE())");

            builder.Property(c => c.Email)
                   .IsRequired();
        }
    }
}

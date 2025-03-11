using Microsoft.EntityFrameworkCore;
using PharmaCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaCare
{
    public class PharmaCareContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer
                ("Server = ESLAMS3DAWY; Database = PharmaCare;" +
                "Integrated Security = True; TRUSTSERVERCERTIFICATE = True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Client ↔ Review Relationship
            //1:N
            modelBuilder.Entity<Client>()
                        .HasMany(c => c.Reviews)
                        .WithOne(r => r.Client)
                        .HasForeignKey(c => c.ClientId);

            //N:1
            modelBuilder.Entity<Review>()
                        .HasOne(r => r.Client)
                        .WithMany(c => c.Reviews)
                        .HasForeignKey(r => r.ClientId);

            //Medicine ↔ Review Relationship
            //1:N
            modelBuilder.Entity<Medicine>()
                        .HasMany(m => m.Reviews)
                        .WithOne(r => r.Medicine)
                        .HasForeignKey(r => r.MedicineId);

            //N:1
            modelBuilder.Entity<Review>()
                        .HasOne(r => r.Medicine)
                        .WithMany(m => m.Reviews)
                        .HasForeignKey(r => r.MedicineId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
    }
}

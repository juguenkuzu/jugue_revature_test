using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mosali.Domaine.Entities;
using System;
using System.IO;
using System.Linq;

namespace Mosali.Infrastructure.Data.Context
{
    public class MosaliContext : DbContext
    {
        public MosaliContext(DbContextOptions<MosaliContext> options)
            : base(options)
        {

        }
        public MosaliContext()
        {
            
        }
        public DbSet<Employee> Employees {get;set;}
        public DbSet<Role> Roles  { get; set; }
       
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
                 


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var connectionString = configuration.GetConnectionString("sqlConnection");
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }

        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateInscription")!=null))
            {
                if (entry.State==EntityState.Added)
                {
                    entry.Property("DateInscription").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateInscription").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
        
       }
}

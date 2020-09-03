using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace health_declaration.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Province> provinces { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<Ward> wards { get; set; }
        public DbSet<Gate> gates { get; set; }
        public DbSet<Symptom> symptoms { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }
        public DbSet<Connection> connections { get; set; }
        public DbSet<Medical_Declaration> medicals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=Medical1;User=sa; Password=reallyStrongPwd123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
        }
    }
}

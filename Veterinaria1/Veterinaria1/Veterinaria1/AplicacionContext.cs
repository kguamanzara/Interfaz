using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria1
{
    class AplicacionContext:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Animal> Animales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("AppConfiguracion.json").Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteAnimal>()
                .HasKey(ca => new { ca.AnimalId, ca.ClienteId });
            modelBuilder.Entity<ClienteAnimal>()
            .HasOne(ca => ca.Cliente)
            .WithMany(c => c.ClienteAnimals)
            .HasForeignKey(ca => ca.AnimalId);
            modelBuilder.Entity<ClienteAnimal>()
           .HasOne(ca => ca.Animal)
           .WithMany(a => a.ClienteAnimals)
           .HasForeignKey(ca => ca.ClienteId);
        }
    }

}

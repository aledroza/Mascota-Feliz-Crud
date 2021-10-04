using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;
using System;

namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet <Mascota> Mascota {get; set;}
        public DbSet <Dueño> Dueño {get; set;}
        public DbSet <Medico> Medico {get; set;}
        //public DbSet <Plan> Plan {get; set;}
        public DbSet <VisitaDomiciliaria> VisitaDomiciliaria {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dueño>().HasNoKey();
            modelBuilder.Entity<Mascota>().HasNoKey();
            modelBuilder.Entity<Medico>().HasNoKey();
            //modelBuilder.Entity<Plan>().HasNoKey();
            modelBuilder.Entity<VisitaDomiciliaria>().HasNoKey();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {       
            if(!optionsBuilder.IsConfigured) 
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascotaFelizData");
            }
        } 
    }
}
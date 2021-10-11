using Microsoft.EntityFrameworkCore;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet <Persona> Personas {get;set;}
        public DbSet <Paciente> Pacientes {get;set;}
        public DbSet <Medico> Medicos {get;set;}
        public DbSet <Ciudad> Ciudades {get;set;}
        public DbSet <Sede> Sedes {get;set;}
        public DbSet <Usuario> Usuarios {get;set;}
        public DbSet <Agendamiento> Agendamientos {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MedicalAppDatas");
           }
       }   
    }

}
using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Clinica;

public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<Doctor> Doctors {get;set;}
    public DbSet<Patient> Patients {get; set;}
    public DbSet<Disease> Diseases {get; set;}
    public DbSet<Service> Services {get; set;}
    public DbSet<Appointment> Appointments {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
    }
}
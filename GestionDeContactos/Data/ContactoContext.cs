using GestionDeContactos.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace GestionDeContactos.Data
{
     class ContactoContext : DbContext
    {
        public DbSet<Contacto> Contactos {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option) 
        {
            option.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);      
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}

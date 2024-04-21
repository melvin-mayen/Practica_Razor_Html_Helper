using Microsoft.EntityFrameworkCore;


namespace Practica_Razor_Html_Helper.Models

{
    public class equiposDbContext : DbContext
    {

        public equiposDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Marcas> Marcas { get; set; }

        public DbSet<estados_equipo> estados_equipo{ get; set; }

        public DbSet<tipo_equipo> tipo_equipo { get; set; }

        public DbSet<Equipos> Equipos { get; set; }



    }
}

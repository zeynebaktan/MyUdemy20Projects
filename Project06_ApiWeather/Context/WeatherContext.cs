using Microsoft.EntityFrameworkCore;
using Project06_ApiWeather.Entities;

namespace Project06_ApiWeather.Context
{
    public class WeatherContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-81KICDV; initial catalog = Db6Project20; integrated security = true; TrustServerCertificate=True");
        }
        public DbSet<City> Cities { get; set; }
    }
}

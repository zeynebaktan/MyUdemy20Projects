using Microsoft.EntityFrameworkCore;

namespace Project06_ApiWeather.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        [Precision(5, 2)]
        public decimal Temp { get; set; }
        public string Detail { get; set; }
    }
}

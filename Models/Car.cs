
namespace Rental.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        public string DailyPrice { get; set; }

        public string Cyls { get; set; }

        public string Passengers { get; set; }
        //// 0 - Economy, 1 - mid lux, 2 - lux, 3 - sport, 4 - super sport
        public string Type { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string MpgCity { get; set; }

        public string MpgHigh { get; set; }

    }
}
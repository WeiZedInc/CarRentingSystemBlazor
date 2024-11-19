using System.ComponentModel.DataAnnotations;

namespace CarRentingSystemBlazor.Data
{
    public class Car
    {
        [Key]
        public int ID { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public bool Available { get; set; }
        public string ImageURL { get; set; }
        public decimal PriceForOneDayRent { get; set; }

        public ICollection<Order> Orders { get; set; } // Navigation property
    }
}

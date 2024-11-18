using System.ComponentModel.DataAnnotations;

namespace CarRentingSystemBlazor.Data
{
    public class Car
    {
        [Key]
        public int ID { get; set; }
        private string Mark { get; set; }
        private string Model { get; set; }
        private bool Available { get; set; }
        private string ImageURL { get; set; }
        private decimal PriceForOneDayRent { get; set; }
    }
}

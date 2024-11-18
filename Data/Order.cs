using System.ComponentModel.DataAnnotations;

namespace CarRentingSystemBlazor.Data
{
    public enum OrderStatus
    {
        Pending,
        Rejected,
        Accepted,
        Completed
    }
    public class Order
    {
        [Key] public int ID { get; set; }
        public int ClientId { get; set; }
        public int CarID { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalRentalCost { get; set; }
    }
}

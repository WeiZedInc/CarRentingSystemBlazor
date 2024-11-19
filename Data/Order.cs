using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentingSystemBlazor.Data
{
    public enum OrderStatus
    {
        Pending,
        CanceledByClient,
        Rejected,
        Accepted,
        NeedToPayForDamage,
        Completed
    }
    public class Order
    {
        [Key] public int ID { get; set; }
        public string ClientId { get; set; }

        [ForeignKey("Car")]
        public int CarID { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime RentalStart { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime RentalEnd { get; set; }

        public OrderStatus Status { get; set; }
        public decimal TotalRentalCost { get; set; }

        public Car Car { get; set; } // Navigation property

        public string? DamageDescription { get; set; }
        public decimal? DamageCost { get; set; }

        public string? RejectionReason { get; set; }
    }
}

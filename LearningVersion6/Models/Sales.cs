using System.ComponentModel.DataAnnotations;

namespace LearningVersion6.Models
{
    public class Sales
    {
        public int Id { get; set; }
        //card or cash
        [Required]
        public string PaymentType { get; set; }
        public int ItemId { get; set; }
        //sales made by?
        public int UserId { get; set; }
        public double Discount { get; set; }
        public string DiscountType { get; set; }
        public double CashCollected { get; set; }
    }
}
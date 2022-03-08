namespace LearningVersion6.Models.Finance.Payments;

public class Payments
{
    public int Id { get; set; }
    
    //The person or Company to who the payment is done to
    public string PaymentTo { get; set; }
    
    //The person who initiated the payment
    public int UserId { get; set; }
    
    public int TransactionType { get; set; }
    public DateTime PaymentDate { get; set; }
}
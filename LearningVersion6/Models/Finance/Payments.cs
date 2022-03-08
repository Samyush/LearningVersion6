namespace LearningVersion6.Models.Finance;

public class Payments
{
    public int Id { get; set; }
    public double PayAmount { get; set; }

    public int TransactionTypeId { get; set; }
    //foreign key for user id of payment initiator
    public int PaymentInitiator { get; set; }
}
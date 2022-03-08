using System.ComponentModel.DataAnnotations.Schema;

namespace LearningVersion6.Models.Finance;

public class Income
{
    public int Id { get; set; }
    public double PayAmount { get; set; }
    public int TransactionTypeId { get; set; }
    //foreign key for user id of payment initiator
    public int CashCollector { get; set; }
    
    [ForeignKey("CashCollector")] public User Users { get; set; }
}
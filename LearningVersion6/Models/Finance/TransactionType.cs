using System.ComponentModel.DataAnnotations;

namespace LearningVersion6.Models.Finance;

public class TransactionType
{
    public int Id { get; set; }
    //[Cash/ Cheque/ Card/ Tc]
    [Required]
    public string Type { get; set; }
}
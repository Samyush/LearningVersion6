using System.ComponentModel.DataAnnotations.Schema;

namespace LearningVersion6.Models
{
    public class Sales
    {
        public int Id { get; set; }
        
        public DateTime SalesDate { get; set; }
        
        public double SalesAmount { get; set; }
        
        //is foreign key for UserId
        public int StaffId { get; set; }
        
        [ForeignKey("StaffId")] 
        public User Users { get; set; }
        //is foreign key for Product or Inventory Id
        public int ProductIds { get; set; }
    }
}
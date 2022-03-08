namespace LearningVersion6.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        //foreign key
        public int ItemId { get; set; }
        public int StockedAmount { get; set; }
        public DateTime LastStocked { get; set; }
        public DateTime LastPurchased { get; set; }
    }
}
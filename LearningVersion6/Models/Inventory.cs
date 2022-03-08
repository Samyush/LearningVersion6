namespace LearningVersion6.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Item { get; set; }
        public int StockAmount { get; set; }
        public bool Status { get; set; }
        public DateTime StockNullDate { get; set; }
        public DateTime StockedDate { get; set; }
    }
}
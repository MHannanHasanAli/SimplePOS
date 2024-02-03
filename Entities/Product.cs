namespace Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; } = string.Empty;
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int CategoryId { get; set; }
    }
}

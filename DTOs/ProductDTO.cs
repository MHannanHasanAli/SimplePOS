namespace DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public List<Product> Products { get; set; }
    }
}

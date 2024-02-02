namespace DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        public List<Category> Categories { get; set; }
    }
}

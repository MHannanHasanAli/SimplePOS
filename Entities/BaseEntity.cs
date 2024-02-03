using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Today;
        public DateTime UpdatedDate { get; set; } = DateTime.Today;
        public bool Deleted { get; set; } = false;

    }
}

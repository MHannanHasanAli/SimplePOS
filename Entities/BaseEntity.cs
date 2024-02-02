using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class RoleDTO
    {
        public string Id { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}

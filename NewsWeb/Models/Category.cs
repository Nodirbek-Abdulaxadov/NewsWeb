using System.ComponentModel.DataAnnotations;

namespace NewsWeb.Models
{
    public class Category
    {
        [Key, Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}

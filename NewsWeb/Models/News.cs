using System.ComponentModel.DataAnnotations;

namespace NewsWeb.Models
{
    public class News
    {
        [Key, Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
        [Required]
        public DateTime PostedDate { get; set; }
        public uint NumberOfViews { get; set; } = 0;
        [Required]
        public string ImagePath { get; set; } = string.Empty;
        [Required]
        public Guid CategoryId { get; set; }
    }
}

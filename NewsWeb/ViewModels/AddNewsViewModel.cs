using System.ComponentModel.DataAnnotations;

namespace NewsWeb.ViewModels
{
    public class AddNewsViewModel
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
        [Required]
        public IFormFile ImageFile { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
    }
}

using NewsWeb.Models;

namespace NewsWeb.ViewModels
{
    public class IndexViewModel
    {
        public List<Category> Categories { get; set; }
        public List<News> News { get; set; }
    }
}

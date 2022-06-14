using NewsWeb.Models;

namespace NewsWeb.Services
{
    public interface ICategoryInterface
    {
        List<Category> GetCategories();
        Category GetCategoryById(Guid id);
        Category GetCategoryByName(string name);
        Category AddCategory(Category category);
        Category UpdateCategory(Category category);
        void DeleteCategory(Guid id);
    }
}

using NewsWeb.DataLayer;
using NewsWeb.Models;

namespace NewsWeb.Services
{
    public class CategoryRepository : ICategoryInterface
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public Category AddCategory(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();

            return category;
        }

        public void DeleteCategory(Guid id)
        {
            var category = dbContext.Categories.FirstOrDefault(c => c.Id == id);
            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
        }

        public List<Category> GetCategories() => dbContext.Categories.ToList();

        public Category GetCategoryById(Guid id) => dbContext.Categories.FirstOrDefault(c => c.Id == id);

        public Category GetCategoryByName(string name) => dbContext.Categories.FirstOrDefault(c => c.Name == name);

        public Category UpdateCategory(Category category)
        {
            dbContext.Categories.Update(category);
            dbContext.SaveChanges();

            return category;
        }
    }
}

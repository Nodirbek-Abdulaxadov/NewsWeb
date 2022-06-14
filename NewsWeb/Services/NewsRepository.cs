using NewsWeb.DataLayer;
using NewsWeb.Models;

namespace NewsWeb.Services
{
    public class NewsRepository : INewsInterface
    {
        private readonly ApplicationDbContext dbContext;

        public NewsRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public News AddNews(News News)
        {
            dbContext.News.Add(News);
            dbContext.SaveChanges();

            return News;
        }

        public void DeleteNews(Guid id)
        {
            var news = dbContext.News.FirstOrDefault(n => n.Id == id);
            dbContext.News.Remove(news);
            dbContext.SaveChanges();
        }

        public List<News> GetNews() => dbContext.News.ToList();

        public List<News> GetNewsByCategoryName(string name)
        {
            var category = dbContext.Categories.FirstOrDefault(c => c.Name == name);
            var filteredList = dbContext.News.Where(n => n.CategoryId == category.Id).ToList();

            return filteredList;
        }

        public News GetNewsById(Guid id) => dbContext.News.FirstOrDefault(n => n.Id == id);

        public News UpdateNews(News News)
        {
            dbContext.News.Update(News);
            dbContext.SaveChanges();

            return News;
        }
    }
}

using NewsWeb.Models;

namespace NewsWeb.Services
{
    public interface INewsInterface
    {
        List<News> GetNews();
        List<News> GetNewsByCategoryName(string name);
        News GetNewsById(Guid id);
        News AddNews(News News);
        News UpdateNews(News News);
        void DeleteNews(Guid id);
    }
}

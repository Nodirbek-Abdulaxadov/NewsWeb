using Microsoft.AspNetCore.Mvc;
using NewsWeb.Models;
using NewsWeb.Services;
using NewsWeb.ViewModels;
using System.Diagnostics;

namespace NewsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryInterface categoryInterface;
        private readonly INewsInterface newsInterface;

        public HomeController( ICategoryInterface categoryInterface,
                               INewsInterface newsInterface )
        {
            this.categoryInterface = categoryInterface;
            this.newsInterface = newsInterface;
        }

        public IActionResult Index()
        {
            IndexViewModel viewModel = new()
            {
                Categories = categoryInterface.GetCategories(),
                News = newsInterface.GetNews()
            };

            return View(viewModel);
        }

        public IActionResult CategoryFilter(string name)
        {
            IndexViewModel viewModel = new()
            {
                Categories = categoryInterface.GetCategories(),
                News = name == "All" ? newsInterface.GetNews() : newsInterface.GetNewsByCategoryName(name)
            };

            return View("News", viewModel);
        }

        public IActionResult Detail(Guid id)
        {
            var news = newsInterface.GetNewsById(id);
            return View(news);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
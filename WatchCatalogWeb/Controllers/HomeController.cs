using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WatchCatalogWeb.Models;
using WatchCatalogWeb.Repository;

namespace WatchCatalogWeb.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration configuration;
        private ServiceRepository API = new ServiceRepository();
        public HomeController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IActionResult Index()
        {
            using (HomeRepository homeRepository = new HomeRepository(API))
            {
                homeRepository.GetAllWatchInfo();
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleBrowser.Models;

namespace SampleBrowser.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpGet] public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddSongs()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddSongs(SongArtistViewModel SongInfo)
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

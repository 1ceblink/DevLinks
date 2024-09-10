using DevInBioLinks.Mocks;
using DevLinks.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevLinks.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly AllLinks _allLinks = new();

        public HomeController(ILogger<HomeController> logger, AllLinks allLinks) =>
            (_logger,_allLinks) = (logger, allLinks);


        public IActionResult Index() {
            var links = _allLinks.LinksDictionary;
            return View(links);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

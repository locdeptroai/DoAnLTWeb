using DoAnLTWeb.Data;
using DoAnLTWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoAnLTWeb.Controllers
{
    public class HomeController : Controller
    {
		private readonly DoAnLTWebContext _context;

		public HomeController(DoAnLTWebContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View(_context.Product.ToList());
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
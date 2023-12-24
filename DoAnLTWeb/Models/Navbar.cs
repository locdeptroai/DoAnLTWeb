using DoAnLTWeb.Data;
using Microsoft.AspNetCore.Mvc;
namespace DoAnLTWeb.Models

{
	public class Navbar: ViewComponent
	{
		private readonly DoAnLTWebContext _context;

		public Navbar(DoAnLTWebContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}

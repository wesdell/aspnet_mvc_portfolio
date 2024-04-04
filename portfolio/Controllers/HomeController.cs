using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;
using System.Diagnostics;

namespace portfolio.Controllers
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
			UserMock userData = new UserMock();
			ProjectsMock projectsData = new ProjectsMock();
			HomeIndexViewModel model = new HomeIndexViewModel() { Projects = projectsData.GetProjects().Take(3).ToList(), User = userData.GetUser() };

			return View(model);
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

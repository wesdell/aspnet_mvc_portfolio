using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;
using System.Diagnostics;

namespace portfolio.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly UserMock _user;
		private readonly ProjectsMock _projects;

		public HomeController(ILogger<HomeController> logger, UserMock user, ProjectsMock projects)
		{
			this._logger = logger;
			this._user = user;
			this._projects = projects;
		}

		public IActionResult Index()
		{
			HomeIndexViewModel model = new HomeIndexViewModel() { Projects = _projects.GetProjects().Take(3).ToList(), User = _user.GetUser() };
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

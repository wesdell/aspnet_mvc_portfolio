using Microsoft.AspNetCore.Mvc;
using portfolio.Interfaces;
using portfolio.Models;
using System.Diagnostics;

namespace portfolio.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IUsers _user;
		private readonly IProjects _projects;

		public HomeController(ILogger<HomeController> logger, IUsers user, IProjects projects)
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

		public IActionResult Projects()
		{
			List<ProjectViewModel> model = _projects.GetProjects();
			return View(model);
		}

		public IActionResult Contact()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Contact(ContactViewModel formData)
		{
			return RedirectToAction("Index");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

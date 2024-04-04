using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
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

		private User GetUser()
		{
			return new User()
			{
				Name = "John Doe",
				Age = 20
			};
		}

		private List<ProjectViewModel> GetProjects()
		{
			return new List<ProjectViewModel>()
			{
				new ProjectViewModel()
				{
					Title = "Lorem",
					Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
					ImageURL = "/img/unknown.jpg",
					Link = "https://amazon.com"
				},
				new ProjectViewModel()
				{
					Title = "Ipsum",
					Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
					ImageURL = "/img/unknown.jpg",
					Link = "https://facebook.com"
				},
				new ProjectViewModel()
				{
					Title = "Lorem",
					Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
					ImageURL = "/img/unknown.jpg",
					Link = "https://amazon.com"
				},
				new ProjectViewModel()
				{
					Title = "Ipsum",
					Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
					ImageURL = "/img/unknown.jpg",
					Link = "https://facebook.com"
				}
			};
		}

		public IActionResult Index()
		{
			User user = GetUser();
			List<ProjectViewModel> projects = GetProjects().Take(3).ToList();
			HomeIndexViewModel model = new HomeIndexViewModel() { Projects = projects, User = user };

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

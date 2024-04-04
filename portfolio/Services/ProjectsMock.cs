using portfolio.Models;

namespace portfolio.Services
{
	public class ProjectsMock
	{
		public List<ProjectViewModel> GetProjects()
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
	}
}

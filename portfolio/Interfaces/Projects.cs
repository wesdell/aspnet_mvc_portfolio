using portfolio.Models;

namespace portfolio.Interfaces
{
	public interface IProject
	{
		string Title { get; set; }
		string Description { get; set; }
		string ImageURL { get; set; }
		string Link { get; set; }
	}
	public interface IProjects
	{
		List<ProjectViewModel> GetProjects();
	}
}

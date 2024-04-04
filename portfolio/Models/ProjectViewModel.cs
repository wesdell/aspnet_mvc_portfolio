using portfolio.Interfaces;

namespace portfolio.Models
{
	public class ProjectViewModel : IProject
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageURL { get; set; }
		public string Link { get; set; }

	}
}

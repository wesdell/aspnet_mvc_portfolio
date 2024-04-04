namespace portfolio.Models
{
	public class HomeIndexViewModel
	{
		public User User { get; set; }
		public IEnumerable<ProjectViewModel> Projects { get; set; }
	}
}

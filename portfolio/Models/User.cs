using portfolio.Interfaces;

namespace portfolio.Models
{
	public class User : IUser
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}
}

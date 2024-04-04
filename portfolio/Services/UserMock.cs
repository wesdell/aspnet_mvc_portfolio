using portfolio.Models;

namespace portfolio.Services
{
	public class UserMock
	{
		public User GetUser()
		{
			return new User()
			{
				Name = "John Doe",
				Age = 20
			};
		}
	}
}

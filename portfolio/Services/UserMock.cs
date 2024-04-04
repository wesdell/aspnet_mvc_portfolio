using portfolio.Interfaces;
using portfolio.Models;

namespace portfolio.Services
{
	public class UserMock : IUsers
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

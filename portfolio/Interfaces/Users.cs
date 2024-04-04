using portfolio.Models;

namespace portfolio.Interfaces
{
	public interface IUser
	{
		string Name { get; set; }
		int Age { get; set; }
	}

	public interface IUsers
	{
		User GetUser();
	}
}

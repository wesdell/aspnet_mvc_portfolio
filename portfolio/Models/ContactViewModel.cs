using portfolio.Interfaces;

namespace portfolio.Models
{
	public class ContactViewModel : IContact
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Message { get; set; }
	}
}
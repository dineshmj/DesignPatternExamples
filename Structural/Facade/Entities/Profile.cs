using DesignPatterns.Utilities;

namespace DesignPatterns.Structural.Facade.Entities
{
	public sealed class Profile
		: IdentifiableEntityBase<string>
	{
		public string Password { get; private set; }
		public int CustomerId { get; set; }

		public Profile (string password, int customerId)
		{
			this.Password = password;
			this.CustomerId = customerId;
		}
	}
}
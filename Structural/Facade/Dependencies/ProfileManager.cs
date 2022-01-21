using DesignPatterns.Structural.Facade.Entities;
using DesignPatterns.Utilities;

namespace DesignPatterns.Structural.Facade.Dependencies
{
	public sealed class ProfileManager
		: IProfileManager
	{
		private readonly RepositoryBase<Profile, string> profileRepo = new ProfileRepository ();

		public Profile CreateDefaultProfile (Customer customer)
		{
			var newProfile = new Profile ("defaultPassword", customer.Id);
			this.profileRepo.CreateNew (newProfile);

			return newProfile;
		}
	}
}
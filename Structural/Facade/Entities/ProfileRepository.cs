using System;

using DesignPatterns.Utilities;

namespace DesignPatterns.Structural.Facade.Entities
{
	public sealed class ProfileRepository
		: RepositoryBase<Profile, string>
	{
		protected override string GenerateNewId ()
		{
			return Guid.NewGuid ().ToString ();
		}
	}
}
using System;

using DesignPatterns.Utilities;

namespace DesignPatterns.Structural.Facade.Entities
{
	public sealed class EmailRepository
		: RepositoryBase<Email, string>
	{
		protected override string GenerateNewId ()
		{
			return Guid.NewGuid ().ToString ();
		}
	}
}
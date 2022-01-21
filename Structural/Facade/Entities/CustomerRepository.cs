using System;

using DesignPatterns.Utilities;

namespace DesignPatterns.Structural.Facade.Entities
{
	public sealed class CustomerRepository
		: RepositoryBase<Customer, int>
	{
		static int customerId = -1;

		protected override int GenerateNewId ()
		{
			customerId++;
			return customerId;
		}
	}
}
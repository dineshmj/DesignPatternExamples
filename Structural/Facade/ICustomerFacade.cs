using System.Collections.Generic;

using DesignPatterns.Structural.Facade.Entities;

namespace DesignPatterns.Structural.Facade
{
	public interface ICustomerFacade
	{
		IList<string> CreateCustomer (Customer customer);
	}
}
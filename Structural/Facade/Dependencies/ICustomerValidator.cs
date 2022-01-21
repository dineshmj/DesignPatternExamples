using System.Collections.Generic;

using DesignPatterns.Structural.Facade.Entities;

namespace DesignPatterns.Structural.Facade.Dependencies
{
	public interface ICustomerValidator
	{
		IList<string> Validate (Customer customer);
	}
}
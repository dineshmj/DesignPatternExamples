using DesignPatterns.Structural.Facade.Entities;

namespace DesignPatterns.Structural.Facade.Dependencies
{
	public interface IProfileManager
	{
		Profile CreateDefaultProfile (Customer customer);
	}
}
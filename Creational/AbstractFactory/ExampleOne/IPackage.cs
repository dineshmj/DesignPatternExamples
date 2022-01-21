using DesignPatterns.Creational.AbstractFactory.ExampleOne.Entities;

namespace DesignPatterns.Creational.AbstractFactory
{
	// An abstraction to represent the "packaging" products of the factory.
	public interface IPackage
	{
		PackageType PackageType { get; }
	}
}
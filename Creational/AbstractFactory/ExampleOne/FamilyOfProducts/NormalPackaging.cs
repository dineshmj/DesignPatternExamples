using DesignPatterns.Creational.AbstractFactory.ExampleOne.Entities;

namespace DesignPatterns.Creational.AbstractFactory.ExampleOne.FamilyOfProducts
{
	public class NormalPackaging
		: IPackage
	{
		public PackageType PackageType
		{
			get  { return PackageType.Standard; }  
		}
	}
}
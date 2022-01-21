using DesignPatterns.Creational.AbstractFactory.ExampleOne.Entities;

namespace DesignPatterns.Creational.AbstractFactory.ExampleOne.FamilyOfProducts
{
	public class FragileHandleWithCarePackaging
		: IPackage
	{
		public PackageType PackageType
		{
			get  { return PackageType.FragileHandleWithCare; }  
		}
	}
}
using System.ComponentModel;

namespace DesignPatterns.Creational.AbstractFactory.ExampleOne.Entities
{
	public enum PackageType
	{
		[Description ("Standard Packaging")]
		Standard,

		[Description ("Fragile! Handle-with-care Packaging")]
		FragileHandleWithCare
	}
}
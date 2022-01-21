using System.ComponentModel;

namespace DesignPatterns.Creational.AbstractFactory.ExampleOne.Entities
{
	public enum DeliveryCarrier
	{
		[Description ("Regular Postage")]
		Post,

		[Description ("Private Courier")]
		Courier
	}
}
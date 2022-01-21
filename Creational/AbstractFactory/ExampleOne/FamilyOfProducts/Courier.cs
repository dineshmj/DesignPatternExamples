using DesignPatterns.Creational.AbstractFactory.ExampleOne.Entities;

namespace DesignPatterns.Creational.AbstractFactory.ExampleOne.FamilyOfProducts
{
	public class Courier
		: IDelivery
	{
		public DeliveryCarrier DeliveryCarrier 
		{
			get { return DeliveryCarrier.Courier; }
		}
	}
}
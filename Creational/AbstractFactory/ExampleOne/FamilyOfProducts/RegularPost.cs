using DesignPatterns.Creational.AbstractFactory.ExampleOne.Entities;

namespace DesignPatterns.Creational.AbstractFactory.ExampleOne.FamilyOfProducts
{
	public class RegularPost
		: IDelivery
	{
		public DeliveryCarrier DeliveryCarrier 
		{
			get { return DeliveryCarrier.Post; }
		}
	}
}
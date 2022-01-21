using DesignPatterns.Creational.AbstractFactory.ExampleOne.Entities;

namespace DesignPatterns.Creational.AbstractFactory
{
	// An abstraction to represent the "delivery" products of the factory.
	public interface IDelivery
	{
		DeliveryCarrier DeliveryCarrier { get; }
	}
}
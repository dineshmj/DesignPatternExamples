namespace DesignPatterns.Creational.AbstractFactory
{
	public interface IPackAndDeliverFactory
	{
		//
		// NOTE: In the "abstract factory" design pattern, the factory that produces products itself is abstracted.
		//

		IPackage CreatePackage ();
		IDelivery DeliverItem ();
	}
}
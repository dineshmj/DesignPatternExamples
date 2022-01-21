using DesignPatterns.Creational.AbstractFactory.ExampleOne.FamilyOfProducts;

namespace DesignPatterns.Creational.AbstractFactory.ExampleOne.Factories
{
	public class FragilePackAndDeliverFactory
		: IPackAndDeliverFactory
	{
		//
		// NOTE: While the "factory method" design pattern uses "inheritance" / interface implementation approach,
		// NOTE: the "abstract factory" design pattern relies on "composition" approach, where multiple products are produced by the factory.
		//

		public IPackage Package { get; set; }


		public virtual IPackage CreatePackage ()
		{
			return new FragileHandleWithCarePackaging ();
		}

		public virtual IDelivery DeliverItem ()
		{
			return new Courier ();
		}
	}
}
namespace DesignPatterns.Creational.FactoryMethod.Factories
{
	public class PlatinumCreditCardFactory
		: ICreditCardFactory
	{
		public CreditCardBase GetCreditCard ()
		{
			return new PlatinumCreditCard ();
		}
	}
}
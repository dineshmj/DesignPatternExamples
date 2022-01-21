namespace DesignPatterns.Creational.FactoryMethod.Factories
{
	public class TitaniumCreditCardFactory
		: ICreditCardFactory
	{
		public CreditCardBase GetCreditCard ()
		{
			return new TitaniumCreditCard ();
		}
	}
}
namespace DesignPatterns.Creational.FactoryMethod.Factories
{
	public class MoneyBackCreditCardFactory
		: ICreditCardFactory
	{
		public CreditCardBase GetCreditCard ()
		{
			return new MoneyBackCreditCard ();
		}
	}
}
namespace DesignPatterns.Creational.FactoryMethod
{
	public class MoneyBackCreditCard
		: CreditCardBase
	{
		public MoneyBackCreditCard ()
			: base (50000, 0)
		{
			this.CardType = "Money-Back Credit Card";
		}
	}
}
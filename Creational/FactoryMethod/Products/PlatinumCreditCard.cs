namespace DesignPatterns.Creational.FactoryMethod
{
	public class PlatinumCreditCard
		: CreditCardBase
	{
		public PlatinumCreditCard ()
			: base (500000, 1000)
		{
			this.CardType = "Platinum Credit Card";
		}
	}
}
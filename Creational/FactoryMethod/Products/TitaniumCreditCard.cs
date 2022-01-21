namespace DesignPatterns.Creational.FactoryMethod
{
	public class TitaniumCreditCard
		: CreditCardBase
	{
		public TitaniumCreditCard ()
			: base (100000, 500)
		{
			this.CardType = "Titanium Credit Card";
		}
	}
}
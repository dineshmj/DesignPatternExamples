namespace DesignPatterns.Creational.FactoryMethod
{
	public abstract class CreditCardBase
	{
		public string CardType { get; protected set; }
		public double CreditLimit { get; private set; }
		public double AnnualCharge { get; private set; }

		public CreditCardBase (double creditLimit, double annualCharge)
		{
			this.CreditLimit = creditLimit;
			this.AnnualCharge = annualCharge;
		}
	}
}
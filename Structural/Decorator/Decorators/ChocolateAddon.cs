namespace DesignPatterns.Structural.Decorator.Decorators
{
	public sealed class ChocolateAddon
		: ICoffee
	{
		private readonly ICoffee baseCoffee;

		public ChocolateAddon (ICoffee baseCoffee)
		{
			this.baseCoffee = baseCoffee;
		}
		public string GetDescription ()
		{
			return this.baseCoffee.GetDescription () + ", with Chocolate";
		}

		public double GetPrice ()
		{
			return this.baseCoffee.GetPrice () + 0.5;
		}
	}
}
namespace DesignPatterns.Structural.Decorator.Decorators
{
	public sealed class CaramelAddon
		: ICoffee
	{
		private readonly ICoffee baseCoffee;

		public CaramelAddon (ICoffee baseCoffee)
		{
			this.baseCoffee = baseCoffee;
		}
		public string GetDescription ()
		{
			return this.baseCoffee.GetDescription () + ", with Caramel";
		}

		public double GetPrice ()
		{
			return this.baseCoffee.GetPrice () + 1.5;
		}
	}
}
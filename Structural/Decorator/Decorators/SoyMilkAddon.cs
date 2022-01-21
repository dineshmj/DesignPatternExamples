namespace DesignPatterns.Structural.Decorator.Decorators
{
	public sealed class SoyMilkAddon
		: ICoffee
	{
		private readonly ICoffee baseCoffee;

		public SoyMilkAddon (ICoffee baseCoffee)
		{
			this.baseCoffee = baseCoffee;
		}
		public string GetDescription ()
		{
			return this.baseCoffee.GetDescription () + ", with Soy Milk";
		}

		public double GetPrice ()
		{
			return this.baseCoffee.GetPrice () + 0.8;
		}
	}
}
namespace DesignPatterns.Structural.Decorator.Concretions
{
	public sealed class Latte
		: CoffeeBase
	{
		public override string GetDescription ()
		{
			return $"{ base.GetDescription () } Latte";
		}

		public override double GetPrice ()
		{
			return 1;
		}
	}
}
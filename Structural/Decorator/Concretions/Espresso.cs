namespace DesignPatterns.Structural.Decorator.Concretions
{
	public sealed class Espresso
		: CoffeeBase
	{
		public override string GetDescription ()
		{
			return $"{ base.GetDescription () } Espresso";
		}

		public override double GetPrice ()
		{
			return 2;
		}
	}
}
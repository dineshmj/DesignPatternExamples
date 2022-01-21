namespace DesignPatterns.Structural.Decorator
{
	public abstract class CoffeeBase
		: ICoffee
	{
		public virtual string GetDescription ()
		{
			return "Coffee";
		}

		public abstract double GetPrice ();
	}
}
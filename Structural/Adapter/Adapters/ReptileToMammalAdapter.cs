using DesignPatterns.Structural.Adapter.Adaptees;

namespace DesignPatterns.Structural.Adapter.Adapters
{
	public sealed class ReptileToMammalAdapter
		: IMammal
	{
		private readonly IReptile reptile;

		public ReptileToMammalAdapter (IReptile reptile)
		{
			this.reptile = reptile;
		}

		public IChild GiveBirth ()
		{
			var egg = this.reptile.LayEgg ();
			var offspring = egg.Hatch ();

			return offspring;
		}
	}
}
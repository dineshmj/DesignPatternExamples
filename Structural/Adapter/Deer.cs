namespace DesignPatterns.Structural.Adapter
{
	public sealed class Deer
		: IMammal
	{
		public IChild GiveBirth ()
		{
			return new Fawn ();
		}
	}
}
namespace DesignPatterns.Structural.Adapter.Adaptees
{
	public sealed class Alligator
		: IReptile
	{
		public IEgg LayEgg ()
		{
			return new AlligatorEgg ();
		}
	}
}
namespace DesignPatterns.Structural.Adapter.Adaptees
{
	public sealed class AlligatorEgg
		: IEgg
	{
		public IChild Hatch ()
		{
			return new Hatchling ();
		}
	}
}
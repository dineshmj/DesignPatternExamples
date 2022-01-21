namespace DesignPatterns.Structural.Adapter.Adaptees
{
	public sealed class Hatchling
		: IChild
	{
		public string Cry ()
		{
			return "Baby alligator \"Hatchling\" makes sound!";
		}
	}
}
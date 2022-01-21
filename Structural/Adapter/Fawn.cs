using System;

namespace DesignPatterns.Structural.Adapter
{
	public sealed class Fawn
		: IChild
	{
		public string Cry ()
		{
			return "Baby deer \"Fawn\" bleats!";
		}
	}
}
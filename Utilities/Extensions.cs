using System;
using System.ComponentModel;

namespace DesignPatterns.Utilities
{
	public static class Extensions
	{
		public static string GetDescription (this Enum enumValue)
		{
			var enumType = enumValue.GetType ();
			var enumMembers = enumType.GetMember (enumValue.ToString ());
			var descriptionAttributes = enumMembers ?[0]?.GetCustomAttributes (typeof (DescriptionAttribute), false);
			var description = ((DescriptionAttribute) descriptionAttributes ?[0])?.Description;

			return description ?? enumValue.ToString ();
		}
	}
}
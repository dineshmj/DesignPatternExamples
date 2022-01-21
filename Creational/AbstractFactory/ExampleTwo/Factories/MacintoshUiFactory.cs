using DesignPatterns.Creational.AbstractFactory.ExampleTwo.FamilyOfProducts;

namespace DesignPatterns.Creational.AbstractFactory.ExampleTwo.Factories
{
	public class MacintoshUiFactory
		: IUserInterfaceFactory
	{
		public ILabel GetLabel ()
		{
			return new MacintoshLabel ();
		}

		public IPushButton GetPushButton ()
		{
			return new MacintoshPushButton ();
		}

		public ITextBox GetTextBox ()
		{
			return new MacintoshTextBox ();
		}
	}
}
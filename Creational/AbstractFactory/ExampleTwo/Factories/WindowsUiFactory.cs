using DesignPatterns.Creational.AbstractFactory.ExampleTwo.FamilyOfProducts;

namespace DesignPatterns.Creational.AbstractFactory.ExampleTwo.Factories
{
	public class WindowsUiFactory
		: IUserInterfaceFactory
	{
		public ILabel GetLabel ()
		{
			return new WindowsLabel ();
		}

		public IPushButton GetPushButton ()
		{
			return new WindowsPushButton ();
		}

		public ITextBox GetTextBox ()
		{
			return new WindowsTextBox ();
		}
	}
}
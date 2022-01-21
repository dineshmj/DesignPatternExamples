using DesignPatterns.Creational.AbstractFactory.ExampleTwo.FamilyOfProducts;

namespace DesignPatterns.Creational.AbstractFactory.ExampleTwo.Factories
{
	public class LinuxUiFactory
		: IUserInterfaceFactory
	{
		public ILabel GetLabel ()
		{
			return new LinuxLabel ();
		}

		public IPushButton GetPushButton ()
		{
			return new LinuxPushButton ();
		}

		public ITextBox GetTextBox ()
		{
			return new LinuxTextBox ();
		}
	}
}
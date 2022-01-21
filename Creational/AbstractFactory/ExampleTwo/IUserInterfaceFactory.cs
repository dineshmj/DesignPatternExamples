namespace DesignPatterns.Creational.AbstractFactory.ExampleTwo
{
	public interface IUserInterfaceFactory
	{
		ILabel GetLabel ();
		ITextBox GetTextBox ();
		IPushButton GetPushButton ();
	}
}
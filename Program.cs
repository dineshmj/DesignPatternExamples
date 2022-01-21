using System;
using System.Collections.Generic;
using System.Linq;

using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Observer.Entities;
using DesignPatterns.Behavioral.Observer.Observable;
using DesignPatterns.Behavioral.Observer.Observers;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Strategy.Clients;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.ExampleOne.Factories;
using DesignPatterns.Creational.AbstractFactory.ExampleTwo;
using DesignPatterns.Creational.AbstractFactory.ExampleTwo.Factories;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Adapter.Adaptees;
using DesignPatterns.Structural.Adapter.Adapters;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Decorator.Concretions;
using DesignPatterns.Structural.Decorator.Decorators;
using DesignPatterns.Utilities;

namespace DesignPatterns
{
	class Program
	{
		private const string PREFIX = "\t\t>> ";

		static void Main (string [] args)
		{
			while (true)
			{
				Console.Clear ();

				Console.WriteLine ($"Select the design pattern to demonstrate: ");
				Console.WriteLine ($"\t 1\tCreational\t\tAbstract factory");
				Console.WriteLine ($"\t 2\tCreational\t\tFactory method");
				Console.WriteLine ($"\t 3\tCreational\t\tSingleton");
				Console.WriteLine ();
				Console.WriteLine ($"\t11\tBehavioral\t\tStrategy");
				Console.WriteLine ($"\t12\tBehavioral\t\tObserver");
				Console.WriteLine ();
				Console.WriteLine ($"\t21\tStructural\t\tDecorator");
				Console.WriteLine ($"\t22\tStructural\t\tAdapter");
				Console.WriteLine ();
				Console.WriteLine ($"Enter -1 to exit the program.");
				Console.WriteLine ();
				Console.Write ($"Enter your choice here ===> ");

				var response = Console.ReadLine ().Trim ();

				switch (response)
				{
					// Exit the program.
					case "-1":
						Console.WriteLine ($"Thank you for using this design patterns demo program.");
						Console.WriteLine ();
						Console.WriteLine ();
						Environment.Exit (0);
						break;

					// Creational
					case "1":
						Program.DemoAbstractFactoryOne ();
						Program.DemoAbstractFactoryTwo ();
						break;

					case "2":
						Program.DemoFactoryMethod ();
						break;

					case "3":
						Program.DemoSingleton ();
						break;

					// Behavioral
					case "11":
						Program.DemoStrategy ();
						break;

					case "12":
						Program.DemoObserver ();
						break;

					// Structural
					case "21":
						Program.DemoDecorator ();
						break;

					case "22":
						Program.DemoAdapter ();
						break;
				}
			}
		}

		private static void DemoAbstractFactoryOne ()
		{
			Program.FlashDemoBegins ();

			IPackAndDeliverFactory factory;

			Console.Write ($"{ PREFIX }Is your article fragile? (Y/N) ");

			var response = Console.ReadLine ();
			switch (response)
			{
				case "Y":
				case "y":
					factory = new FragilePackAndDeliverFactory ();
					break;

				case "N":
				case "n":
					factory = new StandardPackAndDeliverFactory ();
					break;

				default:
					Console.WriteLine ();
					Console.WriteLine ($"{ PREFIX }Answer to the asked question is invalid!");
					Console.Write ($"{ PREFIX }Press ENTER to continue ...");
					Console.ReadLine ();

					Program.FlashDemoCompleted ();
					return;
			}

			var packaging = factory.CreatePackage ();
			var delivery = factory.DeliverItem ();

			Console.WriteLine ();
			Console.WriteLine ($"{ PREFIX }\tYour packaging option will be \"{ packaging.PackageType.GetDescription () }\"");
			Console.WriteLine ($"{ PREFIX }\tYour delivery option will be \"{ delivery.DeliveryCarrier.GetDescription () }\"");

			Program.FlashDemoCompleted ();
		}

		private static void DemoAbstractFactoryTwo ()
		{
			Program.FlashDemoBegins ();

			IUserInterfaceFactory factory;

			Console.WriteLine ($"{ PREFIX }Which is your laptop's operating system?");
			Console.WriteLine ($"{ PREFIX }\t1\tWindows 10");
			Console.WriteLine ($"{ PREFIX }\t2\tLinux");
			Console.WriteLine ($"{ PREFIX }\t3\tApple Macintosh");
			Console.WriteLine ();
			Console.Write ($"{ PREFIX } Enter your choice here ===> ");

			var response = Console.ReadLine ();
			switch (response)
			{
				case "1":
					factory = new WindowsUiFactory ();
					break;

				case "2":
					factory = new LinuxUiFactory ();
					break;

				case "3":
					factory = new MacintoshUiFactory ();
					break;

				default:
					Console.WriteLine ();
					Console.WriteLine ($"{ PREFIX }Answer to the asked question is invalid!");
					Console.Write ($"{ PREFIX }Press ENTER to continue ...");
					Console.ReadLine ();

					Program.FlashDemoCompleted ();
					return;
			}

			var label = factory.GetLabel ();
			var textBox = factory.GetTextBox ();
			var pushButton = factory.GetPushButton ();

			Console.WriteLine ();
			Console.WriteLine ($"{ PREFIX }\tThe application's user interface will use \"{ label.LabelDescription }\"");
			Console.WriteLine ($"{ PREFIX }\tThe application's user interface will use \"{ textBox.TextBoxDescription }\"");
			Console.WriteLine ($"{ PREFIX }\tThe application's user interface will use \"{ pushButton.PushButtonDescription }\"");

			Program.FlashDemoCompleted ();
		}

		private static void DemoFactoryMethod ()
		{
			Program.FlashDemoBegins ();

			ICreditCardFactory factory;

			Console.WriteLine ($"{ PREFIX }What kind of credit card do you want?");
			Console.WriteLine ($"{ PREFIX }\t1 : Money-back Credit Card");
			Console.WriteLine ($"{ PREFIX }\t2 : Titanium Credit Card");
			Console.WriteLine ($"{ PREFIX }\t3 : Platinum Credit Card");
			Console.WriteLine ();
			Console.Write ($"{ PREFIX } Enter your choice here ===> ");

			var response = Console.ReadLine ();

			switch (response)
			{
				case "1":
					factory = new MoneyBackCreditCardFactory ();
					break;

				case "2":
					factory = new TitaniumCreditCardFactory ();
					break;

				case "3":
					factory = new PlatinumCreditCardFactory ();
					break;

				default:
					Console.WriteLine ();
					Console.WriteLine ($"{ PREFIX }Answer to the asked question is invalid!");
					Console.Write ($"{ PREFIX }Press ENTER to continue ...");
					Console.ReadLine ();

					Program.FlashDemoCompleted ();
					return;
			}

			var creditCard = factory.GetCreditCard ();

			Console.WriteLine ();
			Console.WriteLine ($"{ PREFIX }\tYour credit card's type is \"{ creditCard.CardType }\"");
			Console.WriteLine ($"{ PREFIX }\tYour credit card's credit limit is $ { creditCard.CreditLimit }");
			Console.WriteLine ($"{ PREFIX }\tYour credit card's annual charge will be $ { creditCard.AnnualCharge }");

			Program.FlashDemoCompleted ();
		}

		private static void DemoSingleton ()
		{
			Program.FlashDemoBegins ();
			Program.FlashDemoCompleted ();
		}

		private static void DemoStrategy ()
		{
			Program.FlashDemoBegins ();

			var startedOn = DateTime.Today.AddYears (-5);
			var principal = 1000;
			var interestPercentage = 8;

			var accounts
				= new List<AccountBase> {
					new SavingsBankAccount (principal, startedOn, interestPercentage),
					new CurrentAccount (principal, startedOn),
					new LoanAccount (principal, startedOn, interestPercentage)
				};

			accounts.ForEach (acc => {
				Console.WriteLine ($"{ PREFIX }Account type = { acc.AccountType }, Principal = $ { acc.Principal:F2}, Interest percentage = { acc.InterestPercentage }%, Started on = { acc.StartedOn.ToString ("dd-MMM-yyyy") }");
				Console.WriteLine ($"{ PREFIX }Interest amount now = $ { acc.InterestAmount:F2}");
				Console.WriteLine ($"{ PREFIX }Computing interest ...");
				
				acc.ComputeInterest ();

				Console.WriteLine ($"{ PREFIX }Interest amount after computing = $ { acc.InterestAmount:F2}");
				Console.WriteLine ($"{ PREFIX }~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			});

			Program.FlashDemoCompleted ();
		}

		private static void DemoObserver ()
		{
			Program.FlashDemoBegins ();

			// Observable.
			var weatherStation = new WeatherStationObservable ();

			// Observers.
			var phone = new PhoneWeatherObserver (weatherStation);
			var laptop = new LaptopWeatherObserver (weatherStation);
			var airportDisplay = new AirPortWeatherObserver (weatherStation);

			var observers = new List<ObserverBase<WeatherData>> { phone, laptop, airportDisplay };

			// Display current weather.
			Console.WriteLine ($"{ PREFIX }The current weather data is given below ...");
			Console.WriteLine ();

			observers.ForEach (o => {
				var displayer = o as IDisplay;
				Console.WriteLine ($"{ PREFIX }\t{ displayer.GetDisplayMessage () }");
			});

			Console.WriteLine ();

			// Update weather data.
			Console.WriteLine ($"{ PREFIX }The weather station is about to get readings from the sensors ...");
			weatherStation.Change ();
			Console.WriteLine ($"{ PREFIX }The sensors have been read, and all subscribers have been notified of the change in weather data.");
			Console.WriteLine ();

			// Display the new weather data.
			observers.ForEach (o => {
				var displayer = o as IDisplay;
				Console.WriteLine ($"{ PREFIX }\t{ displayer.GetDisplayMessage () }");
			});

			Program.FlashDemoCompleted ();
		}

		private static void DemoDecorator ()
		{
			Program.FlashDemoBegins ();
			
			ICoffee coffee;


			Console.WriteLine ($"{ PREFIX }Which coffee do you want?");
			Console.WriteLine ();
			Console.WriteLine ($"{ PREFIX }\t(a) Latte");
			Console.WriteLine ($"{ PREFIX }\t(b) Espresso");
			Console.WriteLine ();
			Console.Write ($" { PREFIX }\tEnter your choice ===> ");
			var response = Console.ReadLine ();

			switch (response.ToUpper ())
			{
				case "A":
				case "LATTE":
					coffee = new Latte ();
					break;

				case "B":
				case "ESPRESSO":
					coffee = new Espresso ();
					break;

				default:
					Console.WriteLine ();
					Console.WriteLine ($"{ PREFIX }Answer to the asked question is invalid!");
					Console.Write ($"{ PREFIX }Press ENTER to continue ...");
					Console.ReadLine ();

					Program.FlashDemoCompleted ();
					return;
			}

			Console.WriteLine ();
			Console.WriteLine ($"{ PREFIX }Your coffee now is \"{ coffee.GetDescription () }\", and it will cost you $ { coffee.GetPrice () }.");
			Console.WriteLine ();

			Console.Write ($"{ PREFIX }Do you want to add Chocolate? (Y/N) ");
			response = Console.ReadLine ();

			if (response.ToUpper () == "Y")
			{
				Console.WriteLine ($"{PREFIX}You opted for Chocolate addon.");
				Console.WriteLine ();

				coffee = new ChocolateAddon (coffee);
				Console.WriteLine ($"{ PREFIX }Your coffee now is \"{ coffee.GetDescription () }\", and it will cost you $ { coffee.GetPrice () }.");
			}

			Console.WriteLine ();
			Console.Write ($"{ PREFIX }Do you want to add Caramel? (Y/N) ");
			response = Console.ReadLine ();

			if (response.ToUpper () == "Y")
			{
				Console.WriteLine ($"{PREFIX}You opted for Caramel addon.");
				Console.WriteLine ();

				coffee = new CaramelAddon (coffee);
				Console.WriteLine ($"{ PREFIX }Your coffee now is \"{ coffee.GetDescription () }\", and it will cost you $ { coffee.GetPrice () }.");
			}

			Console.WriteLine ();
			Console.Write ($"{ PREFIX }Do you want to add Soy Milk? (Y/N) ");
			response = Console.ReadLine ();

			if (response.ToUpper () == "Y")
			{
				Console.WriteLine ($"{PREFIX}You opted for Soy Milk addon.");
				Console.WriteLine ();

				coffee = new SoyMilkAddon (coffee);
				Console.WriteLine ($"{ PREFIX }Your coffee now is \"{ coffee.GetDescription () }\", and it will cost you $ { coffee.GetPrice () }.");
			}

			Program.FlashDemoCompleted ();
		}

		private static void DemoAdapter ()
		{
			Program.FlashDemoBegins ();

			var alligator = new Alligator ();
			var mammals = new IMammal [] { new Deer (), new ReptileToMammalAdapter (alligator) };

			var children
				= mammals
					.Select (ma => ma.GiveBirth ())
					.ToList ();

			Console.WriteLine ($"{ PREFIX }There are { children.Count } children!");
			Console.WriteLine ();

			children.ForEach (ch => Console.WriteLine ($"{ PREFIX }{ ch.Cry () }"));

			Program.FlashDemoCompleted ();
		}

		private static void FlashDemoBegins ()
		{
			Console.WriteLine ();
			Console.WriteLine ("==================================");
			Console.WriteLine ("The selected demo begins now.");
			Console.WriteLine ();
			Console.WriteLine ();
		}

		private static void FlashDemoCompleted ()
		{
			Console.WriteLine ();
			Console.WriteLine ("The selected demo is now complete.");
			Console.WriteLine ("==================================");
			Console.WriteLine ();
			Console.Write ($"Press ENTER to continue ...");
			Console.ReadLine ();
		}
	}
}
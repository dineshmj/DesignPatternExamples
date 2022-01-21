using DesignPatterns.Behavioral.Observer.Entities;

namespace DesignPatterns.Behavioral.Observer.Observers
{
	public sealed class LaptopWeatherObserver
		: ObserverBase<WeatherData>, IDisplay
	{
		private readonly string displaySource = "Laptop";

		public LaptopWeatherObserver (IObservable<WeatherData> weatherStationObservable)
			: base (weatherStationObservable)
		{
		}

		public string GetDisplayMessage ()
		{
			return $"Displayed on { this.displaySource }: Temperature = { base.data?.TemperatureInCelcius }°C, Humidity = { base.data?.HumidityInGramPerMCube } g/m³, Atmospheric Pressure = { base.data?.AtmosphericPressureInPascal } Pa.";
		}
	}
}
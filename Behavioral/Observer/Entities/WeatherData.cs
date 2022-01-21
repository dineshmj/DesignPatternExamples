namespace DesignPatterns.Behavioral.Observer.Entities
{
	public sealed class WeatherData
	{
		public double TemperatureInCelcius { get; private set; }
		public double HumidityInGramPerMCube { get; private set; }
		public double AtmosphericPressureInPascal { get; private set; }

		public WeatherData (double temp, double humidity, double atmosPressure)
		{
			this.TemperatureInCelcius = temp;
			this.HumidityInGramPerMCube = humidity;
			this.AtmosphericPressureInPascal = atmosPressure;
		}
	}
}
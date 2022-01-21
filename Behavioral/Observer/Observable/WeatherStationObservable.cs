using System;

using DesignPatterns.Behavioral.Observer.Entities;

namespace DesignPatterns.Behavioral.Observer.Observable
{
	public sealed class WeatherStationObservable
		: ObservableBase<WeatherData>
	{
		public WeatherStationObservable ()
		{
			this.RefreshData ();
		}

		public void Change ()
		{
			this.RefreshData ();
			base.Notify ();
		}

		private void RefreshData ()
		{
			var tempRand = new Random ();
			var humidityRand = new Random ();
			var atmosPressureRand = new Random ();

			var temp = tempRand.Next (15, 50);
			var humidity = humidityRand.Next (2, 5) + humidityRand.Next (1, 10) / 10;
			var atmosPressure = 101000 + atmosPressureRand.Next (0, 325);

			base.data = new WeatherData (temp, humidity, atmosPressure);
		}
	}
}
using System;
using System.ComponentModel;

namespace WisejNavigationApplication1.Model
{
	/// <summary>
	/// Represents a weather forecast.
	/// </summary>
	public class WeatherForecast
	{
		[SRDisplayName("Date")]
		public DateTime Date { get; set; }

		[SRDisplayName("Temp. (C)")]
		public int TemperatureC { get; set; }

		[SRDisplayName("Temp. (F)")]
		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		[SRDisplayName("Summary")]
		public string Summary { get; set; }

		[SRDisplayName("Temp. (K)")]
		public double TemperatureK => TemperatureC + 273.15;
	}
}
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using WisejNavigationApplication1.Model;

namespace WisejNavigationApplication1.Data
{
	/// <summary>
	/// Represents a service for fetching random weather forestcasts.
	/// </summary>
	public class WeatherForecastService
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		public Task<BindingList<WeatherForecast>> GetForecastAsync(DateTime startDate, int count = 5)
		{
			var rand = new Random();
			var list = new BindingList<WeatherForecast>();
			for (var i = 0; i < count; i++)
			{
				list.Add(new WeatherForecast
				{
					Date = startDate.AddDays(i),
					TemperatureC = rand.Next(-20, 55),
					Summary = Summaries[rand.Next(Summaries.Length)]
				});
			}

			return Task.FromResult(list);
		}
	}
}
using System;
using System.Data;
using Wisej.Web;
using WisejNavigationApplication1.Data;

namespace WisejNavigationApplication1.Panels
{
	/// <summary>
	/// Represents a reusable control for hosting weather forecasts.
	/// </summary>
	public partial class WeatherForecastPanel : Wisej.Web.UserControl
	{
		public WeatherForecastPanel()
		{
			InitializeComponent();
		}

		private void WeatherForecastPanel_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private async void LoadData()
		{
			var count = 0;
			int.TryParse(this.comboBoxNumbeFetch.Text, out count);

			this.dataGridViewData.DataSource =
				await new WeatherForecastService().GetForecastAsync(DateTime.Now, count);

			this.dataGridViewData.Columns["Date"].DefaultCellStyle.Format = "d";
			this.dataGridViewData.Columns["TemperatureK"].DefaultCellStyle.Format = "N3";
		}

		private void buttonClickMe_Click(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}

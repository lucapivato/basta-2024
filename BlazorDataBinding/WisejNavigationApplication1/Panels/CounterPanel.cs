using System;
using Wisej.Web;
using WisejNavigationApplication1.Controls;

namespace WisejNavigationApplication1.Panels
{
	/// <summary>
	/// Represents a reusable control for hosting counters.
	/// </summary>
	public partial class CounterPanel : Wisej.Web.UserControl
	{
		private int currentCount;

		public CounterPanel()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, EventArgs e)
		{
			this.currentCount++;
			this.labelCurrentCount.Text = $"Current count: {currentCount}";
		}

		private void countersPanel_ToolClick(object sender, ToolClickEventArgs e)
		{
			var container = (Panel)sender;
			switch (e.Tool.Name)
			{
				case "Add":
					container.Controls.Add(new Counter());
					break;

				case "Remove":
					if (container.Controls.Count > 0)
						container.Controls[container.Controls.Count - 1].Dispose();
					break;
			}
		}
	}
}

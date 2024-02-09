using System;
using Wisej.Web;

namespace WisejNavigationApplication1
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			this.navigationBar.SelectedItem = this.navigationBarHome;
		}
		private void ShowPanel(string panelName)
		{
			this.panelMain.Controls.Clear(true);

			var panel = (Control)Activator.CreateInstance(Type.GetType($"WisejNavigationApplication1.Panels.{panelName}"));
			panel.Dock = DockStyle.Fill;
			panel.Parent = this.panelMain;

			var animationIn = this.animationIn.GetAnimation(panel);
			animationIn.Event = "appear";
			animationIn.Name = "slideLeftIn";
		}

		private void navigationBar_SelectedItemChanged(object sender, EventArgs e)
		{
			ShowPanel((string)this.navigationBar.SelectedItem.Tag);
		}

		private void navigationBar_TitleClick(object sender, EventArgs e)
		{
			this.navigationBar.SelectedItem = this.navigationBarHome;
		}

		private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
		{
			Application.LoadTheme(this.comboBoxTheme.Text);
		}

		private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Navigate("https://docs.wisej.com", target: "_blank");
		}


	}
}

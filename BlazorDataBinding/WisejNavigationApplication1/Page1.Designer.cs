namespace WisejNavigationApplication1
{
	partial class Page1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
			this.navigationBar = new Wisej.Web.Ext.NavigationBar.NavigationBar();
			this.navigationBarHome = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.navigationBarCounter = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.navigationBarWeatherForecast = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.panelTop = new Wisej.Web.Panel();
			this.comboBoxTheme = new Wisej.Web.ComboBox();
			this.linkLabelAbout = new Wisej.Web.LinkLabel();
			this.panelMain = new Wisej.Web.FlexLayoutPanel();
			this.animationIn = new Wisej.Web.Animation(this.components);
			this.menuItem1 = new Wisej.Web.MenuItem();
			this.menuItem2 = new Wisej.Web.MenuItem();
			this.menuItem3 = new Wisej.Web.MenuItem();
			this.panelTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// navigationBar
			// 
			this.navigationBar.Dock = Wisej.Web.DockStyle.Left;
			this.navigationBar.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navigationBarHome,
            this.navigationBarCounter,
            this.navigationBarWeatherForecast});
			this.navigationBar.Logo = "Images\\wisej.png";
			this.navigationBar.Name = "navigationBar";
			this.navigationBar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBar.ResponsiveProfiles"))));
			this.navigationBar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBar.ResponsiveProfiles1"))));
			this.navigationBar.ShowUser = false;
			this.navigationBar.Size = new System.Drawing.Size(207, 769);
			this.navigationBar.TabIndex = 0;
			this.navigationBar.Text = "WisejApp";
			this.navigationBar.TitleClick += new System.EventHandler(this.navigationBar_TitleClick);
			this.navigationBar.SelectedItemChanged += new System.EventHandler(this.navigationBar_SelectedItemChanged);
			// 
			// navigationBarHome
			// 
			this.navigationBarHome.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/house-door-fill.svg";
			this.navigationBarHome.Name = "navigationBarHome";
			this.navigationBarHome.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBarHome.ResponsiveProfiles"))));
			this.navigationBarHome.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBarHome.ResponsiveProfiles1"))));
			this.navigationBarHome.Tag = "HomePanel";
			this.navigationBarHome.Text = "Home";
			// 
			// navigationBarCounter
			// 
			this.navigationBarCounter.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/plus-square.svg";
			this.navigationBarCounter.Name = "navigationBarCounter";
			this.navigationBarCounter.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBarCounter.ResponsiveProfiles"))));
			this.navigationBarCounter.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBarCounter.ResponsiveProfiles1"))));
			this.navigationBarCounter.Tag = "CounterPanel";
			this.navigationBarCounter.Text = "Counter";
			// 
			// navigationBarWeatherForecast
			// 
			this.navigationBarWeatherForecast.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/grid-3x3.svg";
			this.navigationBarWeatherForecast.Name = "navigationBarWeatherForecast";
			this.navigationBarWeatherForecast.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBarWeatherForecast.ResponsiveProfiles"))));
			this.navigationBarWeatherForecast.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBarWeatherForecast.ResponsiveProfiles1"))));
			this.navigationBarWeatherForecast.Tag = "WeatherForecastPanel";
			this.navigationBarWeatherForecast.Text = "Wheather Forecast";
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(247, 247, 247);
			this.panelTop.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panelTop.Controls.Add(this.comboBoxTheme);
			this.panelTop.Controls.Add(this.linkLabelAbout);
			this.panelTop.CssStyle = "border-radius:0px;\r\n";
			this.panelTop.Dock = Wisej.Web.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(207, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelTop.ResponsiveProfiles"))));
			this.panelTop.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelTop.ResponsiveProfiles1"))));
			this.panelTop.Size = new System.Drawing.Size(1121, 58);
			this.panelTop.TabIndex = 1;
			// 
			// comboBoxTheme
			// 
			this.comboBoxTheme.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxTheme.Items.AddRange(new object[] {
            "Bootstrap-4",
            "Material-3",
            "Blue-1",
            "Blue-2",
            "Blue-3",
            "Graphite-3",
            "Clear-3",
            "Classic-2",
            "Clear-2",
            "Clear-1",
            "Vista-2"});
			this.comboBoxTheme.Label.Position = Wisej.Web.LabelPosition.Left;
			this.comboBoxTheme.LabelText = "Theme";
			this.comboBoxTheme.Location = new System.Drawing.Point(22, 16);
			this.comboBoxTheme.Name = "comboBoxTheme";
			this.comboBoxTheme.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("comboBoxTheme.ResponsiveProfiles"))));
			this.comboBoxTheme.Size = new System.Drawing.Size(245, 22);
			this.comboBoxTheme.TabIndex = 1;
			this.comboBoxTheme.Text = "Bootstrap-4";
			this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
			// 
			// linkLabelAbout
			// 
			this.linkLabelAbout.Anchor = Wisej.Web.AnchorStyles.Right;
			this.linkLabelAbout.AutoSize = true;
			this.linkLabelAbout.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.linkLabelAbout.Location = new System.Drawing.Point(1038, 17);
			this.linkLabelAbout.Name = "linkLabelAbout";
			this.linkLabelAbout.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("linkLabelAbout.ResponsiveProfiles"))));
			this.linkLabelAbout.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("linkLabelAbout.ResponsiveProfiles1"))));
			this.linkLabelAbout.Size = new System.Drawing.Size(56, 22);
			this.linkLabelAbout.TabIndex = 0;
			this.linkLabelAbout.Text = "About";
			this.linkLabelAbout.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
			// 
			// panelMain
			// 
			this.panelMain.Dock = Wisej.Web.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(207, 58);
			this.panelMain.Name = "panelMain";
			this.panelMain.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelMain.ResponsiveProfiles"))));
			this.panelMain.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelMain.ResponsiveProfiles1"))));
			this.panelMain.Size = new System.Drawing.Size(1121, 711);
			this.panelMain.TabIndex = 2;
			// 
			// menuItem1
			// 
			this.menuItem1.Index = -1;
			this.menuItem1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
			this.menuItem1.Name = "menuItem1";
			this.menuItem1.Text = "menuItem1";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Name = "menuItem2";
			this.menuItem2.Text = "menuItem2";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Name = "menuItem3";
			this.menuItem3.Text = "menuItem3";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.navigationBar);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1328, 769);
			this.Load += new System.EventHandler(this.Page1_Load);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Ext.NavigationBar.NavigationBar navigationBar;
		private Wisej.Web.Panel panelTop;
		private Wisej.Web.FlexLayoutPanel panelMain;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarCounter;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarWeatherForecast;
		private Wisej.Web.LinkLabel linkLabelAbout;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarHome;
		private Wisej.Web.Animation animationIn;
		private Wisej.Web.ComboBox comboBoxTheme;
		private Wisej.Web.MenuItem menuItem1;
		private Wisej.Web.MenuItem menuItem2;
		private Wisej.Web.MenuItem menuItem3;
	}
}


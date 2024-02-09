namespace WisejNavigationApplication1.Panels
{
	partial class WeatherForecastPanel
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
			this.dataGridViewData = new Wisej.Web.DataGridView();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.comboBoxNumbeFetch = new Wisej.Web.ComboBox();
			this.buttonClickMe = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewData
			// 
			this.dataGridViewData.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
			| Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
			this.dataGridViewData.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewData.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGridViewData.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Horizontal;
			this.dataGridViewData.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewData.DefaultRowHeight = 42;
			this.dataGridViewData.DefaultSortMode = Wisej.Web.DataGridViewColumnsSortMode.NotSortable;
			this.dataGridViewData.Location = new System.Drawing.Point(17, 176);
			this.dataGridViewData.Margin = new Wisej.Web.Padding(3, 3, 3, 15);
			this.dataGridViewData.Name = "dataGridViewData";
			this.dataGridViewData.RowHeadersVisible = false;
			this.dataGridViewData.ShowFocusCell = false;
			this.dataGridViewData.Size = new System.Drawing.Size(822, 203);
			this.dataGridViewData.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("windowTitle", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(17, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(327, 54);
			this.label1.TabIndex = 2;
			this.label1.Text = "Weather forecast";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(345, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "This component demonstrates fetching data from a service.";
			// 
			// comboBoxNumbeFetch
			// 
			this.comboBoxNumbeFetch.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxNumbeFetch.Items.AddRange(new object[] {
			"5",
			"100",
			"1000",
			"10000",
			"100000",
			"1000000"});
			this.comboBoxNumbeFetch.Location = new System.Drawing.Point(17, 126);
			this.comboBoxNumbeFetch.Name = "comboBoxNumbeFetch";
			this.comboBoxNumbeFetch.Size = new System.Drawing.Size(120, 30);
			this.comboBoxNumbeFetch.TabIndex = 4;
			this.comboBoxNumbeFetch.Text = "5";
			// 
			// buttonClickMe
			// 
			this.buttonClickMe.Location = new System.Drawing.Point(171, 126);
			this.buttonClickMe.Name = "buttonClickMe";
			this.buttonClickMe.Size = new System.Drawing.Size(119, 30);
			this.buttonClickMe.TabIndex = 5;
			this.buttonClickMe.Text = "Click me";
			this.buttonClickMe.Click += new System.EventHandler(this.buttonClickMe_Click);
			// 
			// WeatherForecastPanel
			// 
			this.Controls.Add(this.buttonClickMe);
			this.Controls.Add(this.comboBoxNumbeFetch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewData);
			this.Name = "WeatherForecastPanel";
			this.Size = new System.Drawing.Size(857, 405);
			this.Load += new System.EventHandler(this.WeatherForecastPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.DataGridView dataGridViewData;
		private Wisej.Web.Label label1;
		private Wisej.Web.Label label2;
		private Wisej.Web.ComboBox comboBoxNumbeFetch;
		private Wisej.Web.Button buttonClickMe;
	}
}

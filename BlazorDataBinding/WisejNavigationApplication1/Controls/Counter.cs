using System;
using Wisej.Web;

namespace WisejNavigationApplication1.Controls
{
	/// <summary>
	/// Represents a reusable counter control.
	/// </summary>
	public class Counter : Wisej.Web.FlexLayoutPanel
	{
		private int currentCount;

		private Button buttonCount;
		private Label labelCurrentCount;

		public Counter()
		{
			InitializeComponent();
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonCount = new Wisej.Web.Button();
			this.labelCurrentCount = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// button
			// 
			this.buttonCount.Location = new System.Drawing.Point(3, 37);
			this.buttonCount.Name = "button";
			this.buttonCount.Repeat = true;
			this.buttonCount.Size = new System.Drawing.Size(229, 41);
			this.buttonCount.TabIndex = 8;
			this.buttonCount.Text = "Click me";
			this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
			// 
			// label2
			// 
			this.labelCurrentCount.AutoSize = true;
			this.labelCurrentCount.Location = new System.Drawing.Point(3, 3);
			this.labelCurrentCount.Name = "label2";
			this.labelCurrentCount.Size = new System.Drawing.Size(229, 18);
			this.labelCurrentCount.TabIndex = 7;
			this.labelCurrentCount.Text = "Current count: 0";
			// 
			// Counter
			// 
			this.Controls.Add(this.labelCurrentCount);
			this.Controls.Add(this.buttonCount);
			this.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.Name = "Counter";
			this.Size = new System.Drawing.Size(235, 82);
			this.Text = "Counter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private void buttonCount_Click(object sender, EventArgs e)
		{
			Increase();
		}

		public void Increase()
		{
			this.currentCount++;
			this.labelCurrentCount.Text = $"Current count: {currentCount}";
		}
	}
}

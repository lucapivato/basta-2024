namespace WisejNavigationApplication1.Panels
{
	partial class CounterPanel
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
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			this.label1 = new Wisej.Web.Label();
			this.labelCurrentCount = new Wisej.Web.Label();
			this.buttonClickMe = new Wisej.Web.Button();
			this.countersPanel = new Wisej.Web.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("windowTitle", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(17, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 54);
			this.label1.TabIndex = 4;
			this.label1.Text = "Counter";
			// 
			// labelCurrentCount
			// 
			this.labelCurrentCount.AutoSize = true;
			this.labelCurrentCount.Location = new System.Drawing.Point(17, 74);
			this.labelCurrentCount.Name = "labelCurrentCount";
			this.labelCurrentCount.Size = new System.Drawing.Size(97, 18);
			this.labelCurrentCount.TabIndex = 5;
			this.labelCurrentCount.Text = "Current count: 0";
			// 
			// buttonClickMe
			// 
			this.buttonClickMe.AppearanceKey = "button-ok";
			this.buttonClickMe.Location = new System.Drawing.Point(17, 119);
			this.buttonClickMe.Name = "buttonClickMe";
			this.buttonClickMe.Repeat = true;
			this.buttonClickMe.Size = new System.Drawing.Size(125, 41);
			this.buttonClickMe.TabIndex = 6;
			this.buttonClickMe.Text = "Click me";
			this.buttonClickMe.Click += new System.EventHandler(this.button_Click);
			// 
			// countersPanel
			// 
			this.countersPanel.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
			| Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
			this.countersPanel.AutoScroll = true;
			this.countersPanel.HeaderBackColor = System.Drawing.Color.Transparent;
			this.countersPanel.HeaderForeColor = System.Drawing.Color.Black;
			this.countersPanel.HeaderSize = 42;
			this.countersPanel.Location = new System.Drawing.Point(17, 195);
			this.countersPanel.Name = "countersPanel";
			this.countersPanel.ShowCloseButton = false;
			this.countersPanel.ShowHeader = true;
			this.countersPanel.Size = new System.Drawing.Size(802, 164);
			this.countersPanel.TabIndex = 7;
			this.countersPanel.Text = "Counters";
			componentTool1.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus-circle-fill.svg?color=#43BF3F";
			componentTool1.Name = "Add";
			componentTool1.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool2.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash-fill.svg?color=#FF4700";
			componentTool2.Name = "Remove";
			componentTool2.Position = Wisej.Web.LeftRightAlignment.Left;
			this.countersPanel.Tools.AddRange(new Wisej.Web.ComponentTool[] {
			componentTool1,
			componentTool2});
			this.countersPanel.ToolClick += new Wisej.Web.ToolClickEventHandler(this.countersPanel_ToolClick);
			// 
			// CounterPanel
			// 
			this.Controls.Add(this.countersPanel);
			this.Controls.Add(this.buttonClickMe);
			this.Controls.Add(this.labelCurrentCount);
			this.Controls.Add(this.label1);
			this.Name = "CounterPanel";
			this.Size = new System.Drawing.Size(836, 379);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Wisej.Web.Label label1;
		private Wisej.Web.Label labelCurrentCount;
		private Wisej.Web.Button buttonClickMe;
		private Wisej.Web.FlowLayoutPanel countersPanel;
	}
}

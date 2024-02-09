namespace WisejNavigationApplication1.Panels
{
	partial class HomePanel
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
			this.label2 = new Wisej.Web.Label();
			this.label1 = new Wisej.Web.Label();
			this.surveyPrompt1 = new WisejNavigationApplication1.Controls.SurveyPrompt();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "Welcome to your new app.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("windowTitle", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(17, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 43);
			this.label1.TabIndex = 4;
			this.label1.Text = "Hello, World!";
			// 
			// surveyPrompt1
			// 
			this.surveyPrompt1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
			this.surveyPrompt1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowOnly;
			this.surveyPrompt1.Location = new System.Drawing.Point(17, 126);
			this.surveyPrompt1.Name = "surveyPrompt1";
			this.surveyPrompt1.Size = new System.Drawing.Size(694, 48);
			this.surveyPrompt1.TabIndex = 6;
			this.surveyPrompt1.Text = "How is Wisej working for you?";
			// 
			// HomePanel
			// 
			this.Controls.Add(this.surveyPrompt1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "HomePanel";
			this.Size = new System.Drawing.Size(737, 637);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label label2;
		private Wisej.Web.Label label1;
		private Controls.SurveyPrompt surveyPrompt1;
	}
}

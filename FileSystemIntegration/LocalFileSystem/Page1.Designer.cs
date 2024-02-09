namespace LocalFileSystem
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
			this.button1 = new Wisej.Web.Button();
			this.listView1 = new Wisej.Web.ListView();
			this.columnHeader1 = new Wisej.Web.ColumnHeader();
			this.columnHeader2 = new Wisej.Web.ColumnHeader();
			this.columnHeader3 = new Wisej.Web.ColumnHeader();
			this.button2 = new Wisej.Web.Button();
			this.button3 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(50, 49);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 54);
			this.button1.TabIndex = 0;
			this.button1.Text = "List Local Files";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.Location = new System.Drawing.Point(50, 140);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(989, 659);
			this.listView1.TabIndex = 1;
			this.listView1.View = Wisej.Web.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Name = "columnHeader1";
			this.columnHeader1.Text = "File Name";
			this.columnHeader1.Width = -1;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Name = "columnHeader2";
			this.columnHeader2.Text = "Size";
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Name = "columnHeader3";
			this.columnHeader3.Text = "Date";
			this.columnHeader3.Width = 200;
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(262, 49);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 54);
			this.button2.TabIndex = 2;
			this.button2.Text = "Read Text File";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(402, 49);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(134, 54);
			this.button3.TabIndex = 3;
			this.button3.Text = "Write Text File";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1077, 852);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button button1;
		private Wisej.Web.ListView listView1;
		private Wisej.Web.ColumnHeader columnHeader1;
		private Wisej.Web.ColumnHeader columnHeader2;
		private Wisej.Web.ColumnHeader columnHeader3;
		private Wisej.Web.Button button2;
		private Wisej.Web.Button button3;
	}
}


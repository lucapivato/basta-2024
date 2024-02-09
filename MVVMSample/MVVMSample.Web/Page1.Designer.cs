namespace MVVMSample.Web
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
			this.splitContainer1 = new Wisej.Web.SplitContainer();
			this.listBox1 = new Wisej.Web.ListBox();
			this.label1 = new Wisej.Web.Label();
			this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
			this.button1 = new Wisej.Web.Button();
			this.textBox1 = new Wisej.Web.TextBox();
			this.labelCurrentName = new Wisej.Web.Label();
			this.label3 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listBox1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(1459, 852);
			this.splitContainer1.SplitterDistance = 467;
			this.splitContainer1.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.listBox1.Location = new System.Drawing.Point(0, 30);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(465, 820);
			this.listBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(465, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Added Names";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelCurrentName, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 850);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "Add me";
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.textBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(109, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(869, 22);
			this.textBox1.TabIndex = 3;
			// 
			// labelCurrentName
			// 
			this.labelCurrentName.AutoEllipsis = true;
			this.labelCurrentName.Dock = Wisej.Web.DockStyle.Fill;
			this.labelCurrentName.Location = new System.Drawing.Point(109, 31);
			this.labelCurrentName.Name = "labelCurrentName";
			this.labelCurrentName.Size = new System.Drawing.Size(869, 22);
			this.labelCurrentName.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 33);
			this.label3.Margin = new Wisej.Web.Padding(3, 5, 3, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 18);
			this.label3.TabIndex = 1;
			this.label3.Text = "Your name is:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1459, 852);
			this.Load += new System.EventHandler(this.Page1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.SplitContainer splitContainer1;
		private Wisej.Web.Label label1;
		private Wisej.Web.ListBox listBox1;
		private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
		private Wisej.Web.Label label2;
		private Wisej.Web.Label label3;
		private Wisej.Web.TextBox textBox1;
		private Wisej.Web.Label labelCurrentName;
		private Wisej.Web.Button button1;
	}
}


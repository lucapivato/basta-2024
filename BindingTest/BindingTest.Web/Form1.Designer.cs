namespace BindingTest
{
	partial class Form1
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
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grid = new Wisej.Web.DataGridView();
			this.txtModel = new Wisej.Web.TextBox();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.txtName = new Wisej.Web.TextBox();
			this.label3 = new Wisej.Web.Label();
			this.lstPassengers = new Wisej.Web.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			// 
			// grid
			// 
			this.grid.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
						| Wisej.Web.AnchorStyles.Left)
						| Wisej.Web.AnchorStyles.Right)));
			this.grid.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Location = new System.Drawing.Point(12, 12);
			this.grid.Name = "grid";
			this.grid.Size = new System.Drawing.Size(343, 136);
			this.grid.TabIndex = 0;
			// 
			// txtModel
			// 
			this.txtModel.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)
						| Wisej.Web.AnchorStyles.Right)));
			this.txtModel.Location = new System.Drawing.Point(54, 154);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(301, 20);
			this.txtModel.TabIndex = 1;
			this.txtModel.Text = "txtModel";
			// 
			// label1
			// 
			this.label1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 157);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Model:";
			// 
			// label2
			// 
			this.label2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(361, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.txtName.Location = new System.Drawing.Point(405, 154);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(108, 20);
			this.txtName.TabIndex = 4;
			this.txtName.Text = "txtName";
			// 
			// label3
			// 
			this.label3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(361, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Passengers on selected plane:";
			// 
			// lstPassengers
			// 
			this.lstPassengers.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
						| Wisej.Web.AnchorStyles.Right)));
			this.lstPassengers.FormattingEnabled = true;
			this.lstPassengers.Location = new System.Drawing.Point(364, 28);
			this.lstPassengers.Name = "lstPassengers";
			this.lstPassengers.Size = new System.Drawing.Size(149, 121);
			this.lstPassengers.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 182);
			this.Controls.Add(this.lstPassengers);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtModel);
			this.Controls.Add(this.grid);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.DataGridView grid;
		private Wisej.Web.TextBox txtModel;
		private Wisej.Web.Label label1;
		private Wisej.Web.Label label2;
		private Wisej.Web.TextBox txtName;
		private Wisej.Web.Label label3;
		private Wisej.Web.ListBox lstPassengers;
	}
}


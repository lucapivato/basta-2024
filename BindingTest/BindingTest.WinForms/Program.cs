using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BindingTest
{
	static class Program
	{
		/// <summary>
		/// https://www.codeproject.com/Articles/24656/A-Detailed-Data-Binding-Tutorial
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			if (MessageBox.Show("Would you like to show the DataSet-based example (Form2)? Click No for the object-based example (Form1).", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				Application.Run(new Form2());
			else
				Application.Run(new Form1());
		}
	}
}

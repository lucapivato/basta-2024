using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Plot3D
{
	/// <summary>
	/// https://www.codeproject.com/Articles/5293980/Editor3D-A-Windows-Forms-Render-Control-with-inter
	/// </summary>
	static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
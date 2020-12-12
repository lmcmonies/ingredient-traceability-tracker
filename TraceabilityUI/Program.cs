using System;
using TraceabilityLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TraceabilityUI
{
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
            //Initialise Text File Connection for writing to text files.
            TraceabilityLibrary.GlobalConfig.InitialiseConnection(true);

            Application.Run(new TraceabilityForm());
        }
    }
}

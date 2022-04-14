using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace TestTask
{
    static class Program
    {
       static public List<General> list = new List<General>();
       static public string typeOfSort = "Сортировки нет";
       static public DateTime startTime = DateTime.Now.Date;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

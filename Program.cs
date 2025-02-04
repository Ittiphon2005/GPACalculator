using System;
using System.Windows.Forms;

namespace GPACalculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GPACalculatorApp.Form1());
        }
    }
}

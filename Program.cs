using System;
using System.Windows.Forms;

namespace StudentApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain()); // Запускаем главную форму
        }
    }
}

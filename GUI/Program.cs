using System;
using System.Windows;

namespace GUI
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            MainWindow w = new MainWindow();
            app.Run(w);
        }
    }
}
using System;
using System.Windows.Forms;
using ToDoApp.Data;

namespace ToDoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var data = Ukladani.Nacist();

            if (data.PrvniSpusteni)
            {
                var welcome = new FormWelcome();

                if (welcome.ShowDialog() == DialogResult.OK)
                {
                    data.PrvniSpusteni = false;
                    data.Ulozit();
                }
            }

            Application.Run(new Form1());
        }
    }
}
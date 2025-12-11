using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using CropsDictonary.Core;

namespace Crops_Dictonary
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var services = new ServiceCollection();
            services.AddSingleton<ICropService, CropService>();
            services.AddTransient<Form1>();
            ServiceProvider = services.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }
    }
}
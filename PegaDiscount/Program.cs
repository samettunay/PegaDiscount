using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PageDiscount;
using System;
using System.IO;
using System.Windows.Forms;

namespace PegaDiscount
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PegaDiscountForm());
        }
    }
}

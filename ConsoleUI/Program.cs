using Microsoft.Toolkit.Uwp.Notifications;
using System.Net.Sockets;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            new ToastContentBuilder()
                .AddAppLogoOverride(new Uri(Path.GetFullPath("pegasus.png")), ToastGenericAppLogoCrop.Default)
                .AddText("Uçak Biletinde Uygun Fiyat!")
                .AddText("Fiyat: ")
                .AddText("Tarih: ")
                .AddAttributionText(" to ")
                .Show();
        }
    }
}
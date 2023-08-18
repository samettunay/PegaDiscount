using Microsoft.Toolkit.Uwp.Notifications;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using PegaDiscount.Models;
using PegaDiscount.Helpers;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PageDiscount
{
    public partial class PegaDiscountForm : Form
    {
        private readonly WebDriverHelper _driverHelper;
        private readonly AppSettingsModel _settingsModel;
        private readonly string _url;
        private readonly List<TicketModel> _ticketModels;

        public PegaDiscountForm()
        {
            InitializeComponent();
            _driverHelper = new WebDriverHelper();
            _settingsModel = new AppSettingsModel();
            _ticketModels = new List<TicketModel>();

            _url = $"https://web.flypgs.com/flexible-search?adultCount={_settingsModel.AdultCount}&arrivalPort={_settingsModel.ArrivalPort}&currency=TL&dateOption=1&departureDate={_settingsModel.DepartureDate}&departurePort={_settingsModel.DeparturePort}&language=tr";
        }

        private void PegaDiscountForm_Load(object sender, EventArgs e)
        {
            Task.Run(main);
            //Thread.Sleep(1 * 60 * 1000);
        }

        private async Task main()
        {
            IWebDriver driver = _driverHelper.CreateNewWebDriver();
            driver.Navigate().GoToUrl(_url);
            checkProperPrices(driver);
        }

        private void checkProperPrices(IWebDriver driver)
        {
            var calendarDays = driver.FindElements(By.CssSelector(".calendar-day-wrapper"));


            foreach (var day in calendarDays)
            {
                var amountElement = day.FindElements(By.ClassName("amount")).FirstOrDefault();
                var dayElement = day.FindElements(By.ClassName("day")).FirstOrDefault();
                if (amountElement != null && dayElement != null)
                {
                    if (!string.IsNullOrEmpty(amountElement.Text))
                    {
                        int ticketPrice = Convert.ToInt32(amountElement.Text.Replace(",", "").Trim());
                        int ticketDay = Convert.ToInt32(dayElement.Text.Trim());

                        if (_settingsModel.SelectedPrice >= ticketPrice)

                        if (!_ticketModels.Any(tm => tm.Day == ticketDay))
                        {
                            var newTicketModel = new TicketModel()
                            {
                                Day = ticketDay,
                                ArrivalPort = _settingsModel.ArrivalPort,
                                DeparturePort = _settingsModel.DeparturePort,
                                DepartureDate = _settingsModel.DepartureDate,
                                AdultCount = _settingsModel.AdultCount,
                                PriceStr = amountElement.Text
                            };
                            _ticketModels.Add(newTicketModel);
                            showToastNotification(newTicketModel);
                        }
                    }
                }
            }
        }

        private void showToastNotification(TicketModel ticket)
        {
            string newUrl = $"https://web.flypgs.com/booking?adultCount={ticket.AdultCount}&arrivalPort={ticket.ArrivalPort}&currency=TL&dateOption=1&departureDate={ticket.DepartureDate}-{ticket.Day}&departurePort={ticket.DeparturePort}&language=tr";

            ToastButton button = new ToastButton("Tarayıcıda aç", newUrl)
            {
                ActivationType = ToastActivationType.Protocol
            };

            new ToastContentBuilder()
                .AddAppLogoOverride(new Uri(Path.GetFullPath("pegasus.png")), ToastGenericAppLogoCrop.Default)
                .AddText("Uçak Biletinde Uygun Fiyat!")
                .AddText($"{ticket.DepartureDate}-{ticket.Day} Fiyat: {ticket.PriceStr} TL")
                .AddAttributionText(ticket.DeparturePort + " to " + ticket.ArrivalPort)
                .AddButton(button)
                .Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

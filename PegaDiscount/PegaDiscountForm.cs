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
            Thread.Sleep(3000);
        }

        private async Task main()
        {
            while (true)
            {
                IWebDriver driver = _driverHelper.CreateNewWebDriver();
                driver.Navigate().GoToUrl(_url);
                checkProperPrices(driver);
            }
        }

        private void checkProperPrices(IWebDriver driver)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    try
                    {
                        string priceText = driver.FindElement(By.XPath($"//*[@id=\"boarding-card-body\"]/div/div[3]/div[1]/div/div[2]/div[3]/div[1]/div/div/div/div[2]/div[2]/div/div[2]/div/table/tbody/tr[{i}]/td[{j}]/div/div[2]/div/span[1]")).Text;

                        string dayText = driver.FindElement(By.XPath($"//*[@id=\"boarding-card-body\"]/div/div[3]/div[1]/div/div[2]/div[3]/div[1]/div/div/div/div[2]/div[2]/div/div[2]/div/table/tbody/tr[{i}]/td[{j}]/div/div[1]")).Text;

                        int ticketPrice = Convert.ToInt32(priceText.Replace(",", "").Trim());
                        int ticketDay = Convert.ToInt32(dayText.Trim());

                        if (_settingsModel.SelectedPrice >= ticketPrice)
                        {
                            if (!_ticketModels.Any(tm=>tm.Day == ticketDay))
                            {
                                var newTicketModel = new TicketModel()
                                {
                                    Day = ticketDay,
                                    ArrivalPort = _settingsModel.ArrivalPort,
                                    DeparturePort = _settingsModel.DeparturePort,
                                    DepartureDate = _settingsModel.DepartureDate,
                                    AdultCount = _settingsModel.AdultCount,
                                    PriceStr = priceText
                                };
                                _ticketModels.Add(newTicketModel);
                                showToastNotification(newTicketModel);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // Element boş
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

        private void hideThisForm(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

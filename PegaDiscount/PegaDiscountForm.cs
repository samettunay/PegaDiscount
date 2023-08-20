using Microsoft.Toolkit.Uwp.Notifications;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using PegaDiscount.Models;
using PegaDiscount.Helpers;
using System.Threading.Tasks;
using PegaDiscount.Utilities.Settings;
using PegaDiscount.Service;
using PegaDiscount.Utilities.Helpers;

namespace PageDiscount
{
    public partial class PegaDiscountForm : Form
    {
        private readonly WebDriverHelper _driverHelper;
        private readonly List<TicketModel> _ticketModels;
        private readonly ITicketService _ticketService;
        private readonly ISettings _settings;
        private readonly string _url;

        public PegaDiscountForm()
        {
            InitializeComponent();
            _driverHelper = new WebDriverHelper();
            _settings = new AppSettings();
            _ticketModels = new List<TicketModel>();
            _ticketService = new TicketService(_ticketModels);

            TicketModel urlTicketModel = new TicketModel()
            {
                AdultCount = _settings.AdultCount,
                ArrivalPort = _settings.ArrivalPort,
                DepartureDate = _settings.DepartureDate,
                DeparturePort = _settings.DeparturePort,
            };

            _url = PegaUrlHelper.CreateUrl(urlTicketModel);
            Console.WriteLine(_url);
        }

        private void PegaDiscountForm_Load(object sender, EventArgs e)
        {
            Task.Run(main);
            //Thread.Sleep(_settingsModel.LoopTimeMinute * 60 * 1000);
        }

        private async Task main()
        {
            IWebDriver driver = _driverHelper.CreateNewWebDriver();
            driver.Navigate().GoToUrl(_url);
            processCalendarTicketDays(driver);
        }

        private void processCalendarTicketDays(IWebDriver driver)
        {
            var calendarDays = driver.FindElements(By.CssSelector("div.calendar-day-wrapper"));

            foreach (var day in calendarDays)
            {
                var ticketAmount = day.FindElements(By.ClassName("amount")).FirstOrDefault();
                var ticketDay = day.FindElements(By.ClassName("day")).FirstOrDefault();

                bool checkNullElements = ticketAmount != null && ticketDay != null;
                bool isTicketModelNotInList = !_ticketService.IsExists(ticketDay.Text);

                if (isTicketModelNotInList && checkNullElements)
                {
                    var newTicketModel = new TicketModel()
                    {
                        Day = ticketDay.Text,
                        Price = ticketAmount.Text,
                        DeparturePort = _settings.DeparturePort,
                        ArrivalPort = _settings.ArrivalPort,
                        AdultCount = _settings.AdultCount,
                        DepartureDate = _settings.DepartureDate,
                    };

                    var addedTicket = _ticketService.Add(newTicketModel, _settings.SelectedPrice);
                    showToastNotification(addedTicket);
                }
            }
        }

        private void showToastNotification(TicketModel ticket)
        {
            if (ticket == null) { return; }

            string toastUrl = PegaUrlHelper.CreateUrl(ticket, false);

            ToastButton button = new ToastButton(Messages.ToastButtonText, toastUrl)
            {
                ActivationType = ToastActivationType.Protocol
            };

            new ToastContentBuilder()
                .AddAppLogoOverride(new Uri(Path.GetFullPath(Messages.ToastImage)), ToastGenericAppLogoCrop.Default)
                .AddText(Messages.ToastTitle)
                .AddText($"{ticket.DepartureDate}{ticket.Day} Fiyat: {ticket.Price} TL")
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

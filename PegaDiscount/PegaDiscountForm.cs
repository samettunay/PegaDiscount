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
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PegaDiscount.Utilities.Extensions;
using PegaDiscount.Utilities.Loggers;
using System.Threading;

namespace PageDiscount
{
    public partial class PegaDiscountForm : Form
    {
        private readonly ITicketService _ticketService;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly WebDriverHelper _driverHelper;
        private readonly List<TicketModel> _ticketModels;
        private readonly AppSettings _settings;
        private bool isRunButtonClicked = false;
        private readonly string _url;

        public PegaDiscountForm()
        {
            InitializeComponent();

            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json")
                .Build();

            _logger = new TxtLogger();
            _driverHelper = new WebDriverHelper();
            _settings = new AppSettings(_configuration);
            _ticketModels = new List<TicketModel>();
            _ticketService = new TicketService(_ticketModels, _logger);

            this.Resize += PegaDiscountForm_Resize;

            TicketModel urlTicketModel = new TicketModel()
            {
                AdultCount = _settings.AdultCount,
                DeparturePort = _settings.DeparturePort,
                ArrivalPort = _settings.ArrivalPort,
                DepartureDate = _settings.DepartureDate,
            };

            _url = PegaUrlHelper.CreateUrl(urlTicketModel);
        }

        private void PegaDiscountForm_Load(object sender, EventArgs e)
        {
            adultCountTextBox.Text = _settings.AdultCount;
            departurePortTextBox.Text = _settings.DeparturePort;
            arrivalPortTextBox.Text = _settings.ArrivalPort;
            departureDateTextBox.Text = _settings.DepartureDate;
            selectedPriceTextBox.Text = _settings.SelectedPrice;
            loopTimeTextbox.Text = _settings.LoopTimeMinute;
            notifyIcon1.Icon = new System.Drawing.Icon("pegasus.ico");
        }

        private async Task main()
        {
            try
            {
                _logger.WriteLog(Messages.AppStarting);
                IWebDriver driver = _driverHelper.CreateNewWebDriver();
                driver.Navigate().GoToUrl(_url);
                processCalendarTicketDays(driver);
                await Task.Delay(_settings.LoopTimeMinute.ToInt32() * 60 * 1000);
            }
            catch (Exception ex)
            {

                _logger.WriteLog(ex.Message);
            }
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

                    var addedTicket = _ticketService.Add(newTicketModel, _settings.SelectedPrice.ToInt32());
                    showToastNotification(addedTicket);
                }
            }
            driver.Quit();
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

        private async void runButton_Click(object sender, EventArgs e)
        {

            runButton.Enabled = false;
            stopButton.Enabled = true;

            while (!runButton.Enabled)
            {
                await Task.Run(main);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            runButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void PegaDiscountForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

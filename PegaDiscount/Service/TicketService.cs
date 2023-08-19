using PegaDiscount.Models;
using PegaDiscount.Utilities.Settings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PegaDiscount.Service
{
    public class TicketService : ITicketService
    {
        private readonly ISettings _settings;

        public TicketService(ISettings settings)
        {
            _settings = settings;
        }

        public TicketModel CreateTicketModel(string amount, string day)
        {
            if (!string.IsNullOrEmpty(amount) && !string.IsNullOrEmpty(day))
            {
                int ticketPrice = Convert.ToInt32(amount.Replace(",", "").Trim());
                int ticketDay = Convert.ToInt32(day.Trim());

                if (_settings.SelectedPrice >= ticketPrice)
                {
                    var newTicketModel = new TicketModel()
                    {
                        Day = ticketDay,
                        ArrivalPort = _settings.ArrivalPort,
                        DeparturePort = _settings.DeparturePort,
                        DepartureDate = _settings.DepartureDate,
                        AdultCount = _settings.AdultCount,
                        PriceStr = amount
                    };

                    return newTicketModel;
                }
            }
            return null;
        }
    }
}

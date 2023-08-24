using PegaDiscount.Models;
using PegaDiscount.Utilities.Extensions;
using PegaDiscount.Utilities.Loggers;
using PegaDiscount.Utilities.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Windows.UI.Xaml.Automation;

namespace PegaDiscount.Service
{
    public class TicketService : ITicketService
    {
        private readonly IList<TicketModel> _ticketModels;
        private readonly ILogger _logger;

        public TicketService(IList<TicketModel> ticketModels, ILogger logger)
        {
            _ticketModels = ticketModels;
            _logger = logger;
        }

        public IEnumerable<TicketModel> GetTicketModels() 
        {
            return _ticketModels;
        }

        public TicketModel Add(TicketModel ticket, int selectedPrice)
        {
            if (string.IsNullOrEmpty(ticket.Price) && string.IsNullOrEmpty(ticket.Day))
            {
                return null;
            }

            var price = ticket.Price.Replace(",", "").Trim().ToInt32();
            ticket.Day = ticket.Day.Trim();

            if (selectedPrice <= price)
            {
                _logger.WriteLog($"{Messages.PriceNotFound} Fiyat: {price}");
                return null;
            }

            _ticketModels.Add(ticket);
            return ticket;
        }

        public bool IsExists(string ticketDay)
        {
            return _ticketModels.Any(tm => tm.Day == ticketDay.Trim());
        }
    }
}

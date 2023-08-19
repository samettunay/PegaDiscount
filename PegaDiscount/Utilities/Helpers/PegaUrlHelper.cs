using PegaDiscount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegaDiscount.Utilities.Helpers
{
    public static class PegaUrlHelper
    {
        public static string CreateUrl(TicketModel ticket, bool isFlexibleSearch = true)
        {
            string calendarUrl = "flexible-search";
            string ticketDay = ticket.Day == 0 ? "" : ticket.Day.ToString();

            if (!isFlexibleSearch)
            {
                calendarUrl = "booking";
                ticket.DepartureDate += "-";
            }

            return $"https://web.flypgs.com/{calendarUrl}?adultCount={ticket.AdultCount}&arrivalPort={ticket.ArrivalPort}&currency=TL&dateOption=1&departureDate={ticket.DepartureDate}{ticketDay}&departurePort={ticket.DeparturePort}&language=tr";
        }
    }
}

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

            if (!isFlexibleSearch)
            {
                calendarUrl = "booking";
                ticket.DepartureDate += "-";
            }

            return $"https://web.flypgs.com/{calendarUrl}?adultCount={ticket.AdultCount}&arrivalPort={ticket.ArrivalPort}&currency=TL&dateOption=1&departureDate={ticket.DepartureDate}{ticket.Day}&departurePort={ticket.DeparturePort}&language=tr";
        }
    }
}

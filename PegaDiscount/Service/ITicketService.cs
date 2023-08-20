using PegaDiscount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegaDiscount.Service
{
    public interface ITicketService
    {
        TicketModel Add(TicketModel ticket, int selectedPrice);
        bool IsExists(string ticketDay);
    }
}

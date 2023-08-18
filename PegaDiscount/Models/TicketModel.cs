using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegaDiscount.Models
{
    public class TicketModel
    {
        public int Day { get; set; }
        public string DeparturePort { get; set; }
        public string ArrivalPort { get; set; }
        public string DepartureDate { get; set; }
        public string AdultCount { get; set; }
        public string PriceStr { get; set; }
        public decimal Price => Convert.ToDecimal(PriceStr);
    }
}

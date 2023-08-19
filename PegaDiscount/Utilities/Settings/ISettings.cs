using System.Configuration;
using System;

namespace PegaDiscount.Utilities.Settings
{
    public interface ISettings
    {
        string AdultCount { get; set; }
        string DeparturePort { get; set; }
        string ArrivalPort { get; set; }
        string DepartureDate { get; set; }
        int LoopTimeMinute { get; set; }
        int SelectedPrice { get; set; }
    }
}
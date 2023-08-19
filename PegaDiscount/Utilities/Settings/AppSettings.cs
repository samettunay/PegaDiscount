using System;
using System.Configuration;


namespace PegaDiscount.Utilities.Settings
{
    public class AppSettings : ISettings
    {
        public string AdultCount { get; set; } = ConfigurationManager.AppSettings["adultCount"];
        public string DeparturePort { get; set; } = ConfigurationManager.AppSettings["departurePort"];
        public string ArrivalPort { get; set; } = ConfigurationManager.AppSettings["arrivalPort"];
        public string DepartureDate { get; set; } = ConfigurationManager.AppSettings["departureDate"];
        public int LoopTimeMinute { get; set; } = Convert.ToInt32(ConfigurationManager.AppSettings["loopTimeMinute"]);
        public int SelectedPrice { get; set; } = Convert.ToInt32(ConfigurationManager.AppSettings["selectedPrice"]);
    }
}

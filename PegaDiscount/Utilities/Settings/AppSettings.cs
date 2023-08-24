using Microsoft.Extensions.Configuration;
using PegaDiscount.Utilities.Extensions;
using System;
using System.Configuration;


namespace PegaDiscount.Utilities.Settings
{
    public class AppSettings
    {
        private readonly IConfiguration _configuration;

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string AdultCount 
        { 
            get => _configuration.GetSection("adultCount").Value; 
            set => _configuration["adultCount"] = value; 
        }

        public string DeparturePort 
        { 
            get => _configuration.GetSection("departurePort").Value; 
            set => _configuration["departurePort"] = value;
        }

        public string ArrivalPort 
        { 
            get => _configuration.GetSection("arrivalPort").Value; 
            set => _configuration["arrivalPort"] = value;
        }

        public string DepartureDate 
        { 
            get => _configuration.GetSection("departureDate").Value; 
            set => _configuration["departureDate"] = value;
        }
        public string LoopTimeMinute 
        { 
            get => _configuration.GetSection("loopTimeMinute").Value; 
            set => _configuration["loopTimeMinute"] = value;
        }

        public string SelectedPrice 
        { 
            get => _configuration.GetSection("selectedPrice").Value; 
            set => _configuration["selectedPrice"] = value;
        }
    }
}

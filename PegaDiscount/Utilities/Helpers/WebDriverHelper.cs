using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PegaDiscount.Helpers
{
    public class WebDriverHelper
    {
        private string defaultHeadlessArgument = "--headless";
        private string defaultUserAgentArgument = "user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/92.0.4515.131 Safari/537.36";
        private string defaultDriverPath = "chromedriver.exe";

        public IWebDriver CreateNewWebDriver(string driverPath = null, string headlessArgument = null, string userAgentArgument = null, bool hideCommandPromptWindow = true)
        {
            var effectiveDriverPath = driverPath ?? defaultDriverPath;
            var effectiveHeadlessArgument = headlessArgument ?? defaultHeadlessArgument;
            var effectiveUserAgentArgument = userAgentArgument ?? defaultUserAgentArgument;

            var chromeDriverService = ChromeDriverService.CreateDefaultService(Path.GetFullPath(effectiveDriverPath));
            chromeDriverService.HideCommandPromptWindow = hideCommandPromptWindow;

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument(effectiveHeadlessArgument);
            chromeOptions.AddArgument(effectiveUserAgentArgument);

            IWebDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);
            return driver;
        }
    }
}

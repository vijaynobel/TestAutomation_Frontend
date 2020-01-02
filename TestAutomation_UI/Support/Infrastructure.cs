using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Configuration;
using System.Diagnostics;

namespace TestAutomation_UI.Support
{
    class Infrastructure
    {
        private static IWebDriver _webDriver;
        public static IWebDriver Driver
        {
            get
            {
                if (_webDriver == null)
                    Initializechromedriver();
                return _webDriver;
            }
        }

        private static void Initializechromedriver()
        {
            foreach (var process in Process.GetProcessesByName("chromedriver.exe"))
            {
                process.Kill();
            }

            
            var webdriverspath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            var chromeOptions = new ChromeOptions();

            chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
            chromeOptions.AddArgument("--no-sandbox");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("incognito");
            chromeOptions.AddArgument("start-maximized");
            _webDriver = new ChromeDriver(webdriverspath, chromeOptions);

        }
    }
}

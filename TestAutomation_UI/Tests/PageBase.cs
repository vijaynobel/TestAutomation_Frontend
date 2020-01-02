using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestAutomation_UI.Support;

namespace TestAutomation_UI.Tests
{
    class PageBase
    {
        //protected IWebDriver Driver;

        public static IWebDriver Driver
        {
            get
            {
                return Infrastructure.Driver;
            }
        }
    }
}

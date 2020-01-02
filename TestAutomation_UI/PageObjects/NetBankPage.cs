using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomation_UI.Tests;
namespace TestAutomation_UI.PageObjects
{
    class NetBankPage:PageBase
    {
        private class NetBankProp
        {
            public const string nbUserName= "txtMyClientNumber_field";
            public const string nbPassword = "txtMyPassword_field";
            public const string nbLogon = "btnLogon_field";
        }
        
        [FindsBy(How=How.Id,Using =NetBankProp.nbUserName)]
        public IWebElement _txtNbUserName;

        [FindsBy(How = How.Id, Using = NetBankProp.nbPassword)]
        public IWebElement _txtNbPassword;

        [FindsBy(How = How.Id, Using = NetBankProp.nbLogon)]
        public IWebElement _btnNbLogon;

        public NetBankPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void NetbankLogin()
        {
            _txtNbUserName.SendKeys("efds");
            _txtNbPassword.SendKeys("erew");
            _btnNbLogon.Click();
        }
    }
}

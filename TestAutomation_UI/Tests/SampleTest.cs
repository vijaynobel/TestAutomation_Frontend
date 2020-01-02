using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using TestAutomation_UI.PageObjects;

namespace TestAutomation_UI.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Sample Tests")]
    [AllureDisplayIgnored]
    class SampleTest:PageBase
    {
        NetBankPage NBH= new NetBankPage();

        [SetUp]
        public void TestOneTime()
        {
            Console.WriteLine("Test One Time setup");
        }

        [TearDown]
        public void TestOneTear()
        {
            Console.WriteLine("Test One Tear");
        }

        
        [Test(Description = "Add two integers and returns the sum")]
        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("8911")]
        [AllureTms("532")]
        [AllureOwner("Anton")]
        [AllureSubSuite("TestOne")]
        public void TestA()
        {
            Driver.Navigate().GoToUrl("https://www.my.commbank.com.au/netbank/Logon/Logon.aspx");
            Console.WriteLine("Test Begins...");
            NBH.NetbankLogin();
        }
    }
}

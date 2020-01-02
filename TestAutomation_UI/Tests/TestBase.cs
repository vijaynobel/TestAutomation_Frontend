using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestAutomation_UI.Support;

namespace TestAutomation_UI.Tests
{
    [SetUpFixture]
    class TestBase
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.WriteLine("Project One Time Setup...");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("Project One Time Tear...");
            Infrastructure.Driver.Close();
            Infrastructure.Driver.Quit();

            //Generate Allure report
            string allureToolPath= Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            allureToolPath= Path.GetFullPath(Path.Combine(allureToolPath,@"Tools\allure-2.13.1\bin"));

            string allureResults = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            allureResults = Path.GetFullPath(Path.Combine(allureResults, @"Results"));

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            startInfo.FileName = "cmd.exe";
            startInfo.WorkingDirectory = allureToolPath;
            string cmd= @"allure generate "+allureResults +" --clean";
            startInfo.Arguments = "/c "+cmd;
            process.StartInfo = startInfo;
            process.Start();

            process.WaitForExit();
            process.Close();


        }
    }
}

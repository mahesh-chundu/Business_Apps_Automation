using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using TechTalk.SpecFlow;
using Bussiness_Application_Automation.TestData;

namespace Bussiness_Application_Automation.Pages
{
    [Binding]
    internal class LoginToOktaPreview
    {
        
        public static class DriverManager
        {
            public static IWebDriver driver { get; set; }
        }
        [BeforeScenario]
        public void Login()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            DriverManager.driver = new ChromeDriver();
            DriverManager.driver.Navigate().GoToUrl(data.BaseUrl);
            DriverManager.driver.Manage().Window.Maximize();
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var Username = DriverManager.driver.FindElement(By.XPath("//input[@id='okta-signin-username']"));
            Username.SendKeys(data.Username);
            var Password = DriverManager.driver.FindElement(By.XPath("//input[@id='okta-signin-password']"));
            Password.SendKeys(data.Password);
            var Submit = DriverManager.driver.FindElement(By.XPath("//input[@id='okta-signin-submit']"));
            Submit.Click();
        }
        [Test]
        public void SRPAddNewRebate()
        {
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var AddNewRebate_Button = DriverManager.driver.FindElement(By.XPath("//button[@id='btnAddNewRebate']"));
            AddNewRebate_Button.Click();
        }
        [Test]
        public void IVPAddNewProgram()
        {
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var AddNewProgram_Button = DriverManager.driver.FindElement(By.XPath("//button[text()='ADD NEW PROGRAM']"));
            AddNewProgram_Button.Click();
        }
        [Test]
        public void SRPClickOnProgramCode()
        {
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var ProgramCode_Link = DriverManager.driver.FindElement(By.XPath("//td[@data-header='Program Code']//a"));
            ProgramCode_Link.Click();
        }

        [Test]
        public void IVPScreenMinimize()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverManager.driver;
            js.ExecuteScript("document.body.style.zoom = '80%';");
        }
        [Test]
        public void Await_IVP()
        {
            Thread.Sleep(8000);
        }

    }
}

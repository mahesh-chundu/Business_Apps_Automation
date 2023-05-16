using Bussiness_Application_Automation.Pages;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static Bussiness_Application_Automation.Pages.LoginToOktaPreview;
using System.Diagnostics.Metrics;
using NUnit.Framework;
using SpecFlow.NetCore;

namespace Bussiness_Application_Automation.StepDefinitions
{
    [Binding]
    internal class Ivp_LoginToOkta
    {
        public static class DriverManager
        {
            public static IWebDriver driver { get; set; }
        }
        [Given("I am on the login page")]
        public void GivenIamontheloginpage()
        {
                string json = File.ReadAllText("config.json");
                var data = JsonConvert.DeserializeObject<data>(json);
                DriverManager.driver = new ChromeDriver();
                DriverManager.driver.Navigate().GoToUrl(data.BaseUrl);
                DriverManager.driver.Manage().Window.Maximize();
        }
        [When("I enter valid credentials")]
        public void WhenIentervalidcredentials()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var Username = DriverManager.driver.FindElement(By.XPath("//input[@id='okta-signin-username']"));
            Username.SendKeys(data.Username);
            var Password = DriverManager.driver.FindElement(By.XPath("//input[@id='okta-signin-password']"));
            Password.SendKeys(data.Password);
        }
        [Then("I click on the login button")]
        public void ThenIclickontheloginbutton()
        {
            var Submit = DriverManager.driver.FindElement(By.XPath("//input[@id='okta-signin-submit']"));
            Submit.Click();
        }
        [Given("I am on the Dashboard Page")]
        public void GivenIamontheDashboardPage()
        {
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        [When("The Add New Program Button is avaliable")]
        public void WhenTheAddNewProgramButtonisavaliable()
        {
           var AddNewProgram_Button = DriverManager.driver.FindElement(By.XPath("//button[text()='ADD NEW PROGRAM']"));
            AddNewProgram_Button.Click();
        }
        [Then("I click on the Add New Program Button")]
        public void ThenIclickontheAddNewProgramButton()
        {
            //Assertion can be applied--> Verify the Page had landed onthe correct URL.
        }

    }
}

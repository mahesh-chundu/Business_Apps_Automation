using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Bussiness_Application_Automation.Pages
{
    internal class IVP_NewProgramPage : LoginToOktaPreview
    {
        private string inputValue;
        [Test]
        public void IvpScreenMinimize()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverManager.driver;
            js.ExecuteScript("document.body.style.zoom = '70%';");
        }
        [Test]
        public void ImplicitWait()
        {
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        [Test]
        public void Approval()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement approval = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_Approval']"));
            SelectElement dropdown = new SelectElement(approval);
            dropdown.SelectByValue(data.Approval);

        }
        [Test]
        public void Status()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement status = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_Status']"));
            SelectElement dropdown = new SelectElement(status);
            dropdown.SelectByValue(data.Status);

        }
        [Test]
        public void ShipStartDate()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement shipStartDate = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-Input_ShipStart2']//input[@id='b4-b4-Input_TextVar']"));
            shipStartDate.SendKeys(data.StartDate);

        }
        [Test]
        public void ShipEndDate()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement shipEndDate = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-Input_ShipEnd2']//input[@id='b4-b7-Input_TextVar']"));
            shipEndDate.SendKeys(data.EndDate);
        }
        [Test]
        public void Year()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement year = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_Year']"));
            SelectElement dropdown = new SelectElement(year);
            dropdown.SelectByValue(data.Year);

        }
        [Test]
        public void NationalAcct()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement nationalAcct = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_NationalAcctInd']"));
            SelectElement dropdown = new SelectElement(nationalAcct);
            dropdown.SelectByValue(data.NationalAcct);

        }
        [Test]
        public void Category()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement category = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_Category']"));
            SelectElement dropdown = new SelectElement(category);
            dropdown.SelectByValue(data.Category);

        }
        [Test]
        public void AllBranches()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement allBranches = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_AllBranches']"));
            SelectElement dropdown = new SelectElement(allBranches);
            dropdown.SelectByValue(data.AllBranches);

        }
        [Test]
        public void SubmitDate()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement submitDate = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-Input_SubmitDate2']//input[@id='b4-b1-Input_TextVar']"));
            submitDate.SendKeys(data.SubmitDate);
        }
        [Test]
        public void PayMode()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement payMode = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_PayMode']"));
            SelectElement dropdown = new SelectElement(payMode);
            dropdown.SelectByValue(data.PayMode);

        }
        [Test]
        public void SalesType()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement salesType = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b5']//../following-sibling::div//button[1]"));
            IWebElement salesType1 = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b5']//../following-sibling::div//button[2]"));
            IWebElement salesType2 = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b5']//../following-sibling::div//button[3]"));
            if (data.SalesType == "1")
            {
                salesType.Click();
            }
            else if (data.SalesType == "2")
            {
                salesType1.Click();
            }
            else
            {
                salesType2.Click();
            }

        }
        [Test]
        public void PurchaseType()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement purchaseType = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b6']//../following-sibling::div//button[1]"));
            IWebElement purchaseType1 = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b6']//../following-sibling::div//button[2]"));
            if (data.PurType == "1")
            {
                purchaseType.Click();
            }
            else
            {
                purchaseType1.Click();
            }

        }
        [Test]
        public void AllCustomers()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement allCustomers = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_AllCustomers']"));
            SelectElement dropdown = new SelectElement(allCustomers);
            dropdown.SelectByValue(data.AllCustomers);

        }
        [Test]
        public void AllShipTos()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement allShipTos = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_AllShipTos']"));
            SelectElement dropdown = new SelectElement(allShipTos);
            dropdown.SelectByValue(data.AllShipTos);

        }
        [Test]
        public void InvoiceRequired()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement invoiceRequired = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_InvoiceRequiredInd']"));
            SelectElement dropdown = new SelectElement(invoiceRequired);
            dropdown.SelectByValue(data.InvoiceRequired);

        }
        [Test]
        public void CalcFactor()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement calcFactor = DriverManager.driver.FindElement(By.XPath("//label[text()='Calc. Factor:']//../following-sibling::div//input"));
            calcFactor.SendKeys(data.CalcFactor);
        }
        [Test]
        public void IvpProgram()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement ivpProgram = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_IVPProgram']"));
            SelectElement dropdown = new SelectElement(ivpProgram);
            dropdown.SelectByValue(data.IvpProgram);

        }
        [Test]
        public void PriceIncrease()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement priceIncrease = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_PriceIncrease']"));
            SelectElement dropdown = new SelectElement(priceIncrease);
            dropdown.SelectByValue(data.PriceIncrease);

        }
        [Test]
        public void Commodity()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement commodity = DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_CommodityInd']"));
            SelectElement dropdown = new SelectElement(commodity);
            dropdown.SelectByValue(data.Commodity);

        }
        [Test]
        public void OwnerName()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement ownerName = DriverManager.driver.FindElement(By.CssSelector(".drop-down-field-value"));
            ownerName.Click();
            Thread.Sleep(1000);
            IWebElement ownerNameSearch = DriverManager.driver.FindElement(By.XPath("//div[@class='dropdown-search-box']//input"));
            ownerNameSearch.SendKeys(data.OwnerName);
            Thread.Sleep(1000);
            IWebElement ownerNameSelect = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-b3-ChoicesList']//span"));
            ownerNameSelect.Click();
        }
        [Test]
        public void GroupId()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement groupId = DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_GroupId']"));
            groupId.SendKeys(data.GroupId);
        }
        [Test]
        public void CustomerSearch()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement customerSearch = DriverManager.driver.FindElement(By.XPath("//label[@id='b4-Label_Customer']//../following-sibling::a"));
            customerSearch.Click();
            IWebElement clickDropdown = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-LazyDropdownSearch_Customer']"));
            clickDropdown.Click();
            IWebElement searchTerm = DriverManager.driver.FindElement(By.XPath("//input[@id='b4-b8-Input_SearchTerm']"));
            searchTerm.SendKeys(data.CustomerSearch);
            IWebElement select = DriverManager.driver.FindElement(By.XPath("//div[@class='choices__item needsclick choices__item--choice choices__item--selectable is-highlighted']//span"));
            select.Click();
        }
        [Test]
        public void SupplierSearch()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement supplierSearch = DriverManager.driver.FindElement(By.XPath("//label[@id='b4-Label_Supplier']//../following-sibling::a"));
            supplierSearch.Click();
            IWebElement clickDropdown = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-LazyDropdownSearch_Supplier']"));
            clickDropdown.Click();
            IWebElement searchTerm = DriverManager.driver.FindElement(By.XPath("//input[@id='b4-b10-Input_SearchTerm']"));
            searchTerm.SendKeys(data.SupplierSearch);
            IWebElement select = DriverManager.driver.FindElement(By.XPath("//div[@class='choices__item needsclick choices__item--choice choices__item--selectable is-highlighted']//span"));
            select.Click();
        }
        [Test]
        public void JodName()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement jobName = DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_JobName']"));
            jobName.SendKeys(data.JobName);
        }
        [Test]
        public void DealId()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement dealId = DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_DealId']"));
            dealId.SendKeys(data.DealId);
        }
        [Test]
        public void VendorProgramId()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement vendorProgramId = DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_VendorProgramId']"));
            vendorProgramId.SendKeys(data.VendorProgramId);
        }
        [Test]
        public void Program()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement program = DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_Program']"));
            program.SendKeys(data.Program);
        }
        [Test]
        public void Comments()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement comments = DriverManager.driver.FindElement(By.XPath("//textarea[@id='b4-TextArea_Comments']"));
            comments.SendKeys(data.Comments);
        }
        [Test]
        public void CreateProgram()
        { 
            IWebElement createProgramButton = DriverManager.driver.FindElement(By.XPath("//div[@id='b4-b12-Button']//button"));
            createProgramButton.Click();
        }
        [Test]
        public void CloseProgram()
        {
            IWebElement closeProgramButton = DriverManager.driver.FindElement(By.XPath("//div[@id='b1-Actions']//a"));
            closeProgramButton.Click();
        }
        [Test]
        public void DashboardYearFilter()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            var num = data.DashboardYearDropdown;
            IWebElement click = DriverManager.driver.FindElement(By.XPath("//div[@id='Dropdown_Year']"));
            click.Click();
            IWebElement dashboardYearFilter = DriverManager.driver.FindElement(By.XPath($"//div[@id='Dropdown_Year']//div[@data-value='{num}']"));
            dashboardYearFilter.Click();
        }
        [Test]
        public void DashboardStatusFilter()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement dashboardStatusFilter = DriverManager.driver.FindElement(By.XPath("//input[@id='Input_Status']"));
            dashboardStatusFilter.SendKeys(data.DashboardStatusFilter);
            dashboardStatusFilter.SendKeys(Keys.Enter);
        }
        [Test]
        public void GetProgramCodeValue()
        {
            IWebElement getProgramCodeValue = DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_ProgramCode']"));
            inputValue = getProgramCodeValue.GetAttribute("value");

        }
        [Test]
        public void ClickProgramLink()
        {
            string value = inputValue;
            IWebElement programSearch = DriverManager.driver.FindElement(By.XPath("//input[@id='Input_Program']"));
            programSearch.SendKeys(value);
            Thread.Sleep(1000);
            programSearch.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            IWebElement clickProgramLink = DriverManager.driver.FindElement(By.XPath("//td[@data-header='Program']//a"));
            clickProgramLink.Click();
        }
        [Test]
        public void ClickNoteTab()
        {
            string json = File.ReadAllText("config.json");
            var data = JsonConvert.DeserializeObject<data>(json);
            IWebElement clickNoteTab = DriverManager.driver.FindElement(By.XPath("//div[@id='b5-TabHeader_Note']//span"));
            clickNoteTab.Click();
            IWebElement addNewNote = DriverManager.driver.FindElement(By.XPath("//button[text()='ADD NEW NOTE']"));
            addNewNote.Click();
            IWebElement addNote = DriverManager.driver.FindElement(By.XPath("//textarea[@id='b5-b49-TextArea_Note']"));
            addNote.SendKeys(data.Note);
            IWebElement AddNoteButton = DriverManager.driver.FindElement(By.XPath("//div[@class='btn-label OSInline']//span[text()='Add Note']//..//..//..//button"));
            AddNoteButton.Click();
        }
        [Test]
        public void SaveProgram()
        {
            IWebElement saveProgram = DriverManager.driver.FindElement(By.XPath("//div[@class='btn-label OSInline']//span[text()='SAVE PROGRAM']//..//..//..//button"));
            saveProgram.Click();
        }
        [Test]
        public void Await()
        {
            Thread.Sleep(8000);
        }
        [Test]
        public void Await_()
        {
            Thread.Sleep(18000);
        }
        [Test]
        public void CloseProgram2()
        {
            IWebElement closeProgram2 = DriverManager.driver.FindElement(By.XPath("//div[@id='b1-Actions']//a"));
            closeProgram2.Click();
        }
        [Test]
        public void TearDown()
        {
            DriverManager.driver.Quit();
        }
    }
}

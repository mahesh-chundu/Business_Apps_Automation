using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;
//using OpenQA.Selenium.DevTools.V110.Input;
using OpenQA.Selenium.DevTools.V112.IndexedDB;
using NUnit.Framework;

namespace Bussiness_Application_Automation.Pages
{
    internal class SRP_NewRequestPage : LoginToOktaPreview
    {
        [Test]
        public void PayMode(string num)
        {
            //var objSelect = driver.FindElement(By.XPath("//select[@id='b18-Dropdown_PayMode']"));
            IWebElement payMode = DriverManager.driver.FindElement(By.XPath("//select[@id='b18-Dropdown_PayMode']"));
            SelectElement dropdown = new SelectElement(payMode);
            dropdown.SelectByValue(num);

        }
        [Test]
        public void Incentive(string num)
        {
            IWebElement incentive = DriverManager.driver.FindElement(By.XPath("//select[@id='b18-Dropdown_Incentive']"));
            SelectElement dropdown = new SelectElement(incentive);
            dropdown.SelectByValue(num);
        }
        [Test]
        public void Category(string num)
        {
            IWebElement category = DriverManager.driver.FindElement(By.XPath("//select[@id='b18-Dropdown_Category']"));
            SelectElement dropdown = new SelectElement(category);
            dropdown.SelectByValue(num);
        }
        [Test]
        public void ShipStartDate(string date)
        {
            IWebElement shipStartDate = DriverManager.driver.FindElement(By.XPath("//input[@id='b18-Input_ShipStart']"));
            shipStartDate.SendKeys(date);

        }
        [Test]
        public void ShipEndDate(string date)
        {
            IWebElement shipEndDate = DriverManager.driver.FindElement(By.XPath("//input[@id='b18-Input_ShipEnd']"));
            shipEndDate.SendKeys(date);

        }
        [Test]
        public void PurTypr(string num)
        {
            IWebElement purType1 = DriverManager.driver.FindElement(By.CssSelector("button[id='b18-btnWSHE']"));
            IWebElement purType2 = DriverManager.driver.FindElement(By.XPath("//div[@class='ThemeGrid_Width9']//button[@id='b18-btnDirect']"));
            IWebElement purType3 = DriverManager.driver.FindElement(By.XPath("//div[@class='ThemeGrid_Width9']//button[@id='b18-btnJQWHSE']"));
            IWebElement purType4 = DriverManager.driver.FindElement(By.XPath("//div[@class='ThemeGrid_Width9']//button[@id='b18-btnJQDIR']"));
            if (num == "1")
            {
                //IWebElement purType1 = DriverManager.driver.FindElement(By.XPath("//button[text()='WHSE']"));
                purType1.Click();

            }
            else if (num == "2")
            {
                //IWebElement purType2 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnDirect']"));
                purType2.Click();
            }
            else if (num == "3")
            {
                //IWebElement purType3 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQWHSE']"));
                purType3.Click();
            }
            else if (num == "4")
            {
                //IWebElement purType4 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQDIR']"));
                purType4.Click();
            }
            else if (num == "5")
            {
                //IWebElement purType11 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnWSHE']"));
                purType1.Click();
                //IWebElement purType12 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnDirect']"));
                purType2.Click();
            }
            else if (num == "6")
            {
                //IWebElement purType13 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnWSHE']"));
                purType1.Click();
                //IWebElement purType31 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQWHSE']"));
                purType3.Click();
            }
            else if (num == "7")
            {
                //IWebElement purType14 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnWSHE']"));
                purType1.Click();
                //IWebElement purType41 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQDIR']"));
                purType4.Click();
            }
            else if (num == "9")
            {
                //IWebElement purType23 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnDirect']"));
                purType2.Click();
                //IWebElement purType32 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQWHSE']"));
                purType3.Click();
            }
            else if (num == "10")
            {
                //IWebElement purType24 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnDirect']"));
                purType2.Click();
                //IWebElement purType42 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQDIR']"));
                purType4.Click();
            }
            else if (num == "11")
            {
                //IWebElement purType34 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQWHSE']"));
                purType3.Click();
                //IWebElement purType43 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQDIR']"));
                purType4.Click();
            }
            else if (num == "12")
            {
                //IWebElement purType111 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnWSHE']"));
                purType1.Click();
                //IWebElement purType222 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnDirect']"));
                purType2.Click();
                //IWebElement purType333 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQWHSE']"));
                purType3.Click();
                //IWebElement purType444 = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnJQDIR']"));
                purType4.Click();
            }
        }
        [Test]
        public void ProgramCode(string code)
        {
            IWebElement programCode = DriverManager.driver.FindElement(By.XPath("//input[@id='b18-Input_ProgramCode']"));
            programCode.SendKeys(code);
        }
        [Test]
        public void ProgramDesc(string desc)
        {
            IWebElement programDesc = DriverManager.driver.FindElement(By.XPath("//input[@id='b18-Input_Program']"));
            programDesc.SendKeys(desc);
        }
        [Test]
        public void Supplier(string supp)
        {
            IWebElement supplier = DriverManager.driver.FindElement(By.XPath("//div[@id='b18-Dropdown_supplier']"));
            supplier.Click();
            IWebElement search = DriverManager.driver.FindElement(By.XPath("//input[@id='b18-b3-Input_SearchTerm']"));
            search.SendKeys(supp);
            IWebElement searchResult = DriverManager.driver.FindElement(By.XPath("//div[@class='choices__item needsclick choices__item--choice choices__item--selectable is-highlighted']"));
            searchResult.Click();
        }
        [Test]
        public void Comments(string comm)
        {
            IWebElement comments = DriverManager.driver.FindElement(By.XPath("//textarea[@id='b18-TextArea_Comments']"));
            comments.SendKeys(comm);
        }
        [Test]
        public void SaveChanges()
        {
            IWebElement saveChanges = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-btnSaveRebate']"));
            saveChanges.Click();
        }
        [Test]
        public void RebateCodeTab(string rebate_code)
        {
            IWebElement rebateCode = DriverManager.driver.FindElement(By.XPath("//div[@id='b18-Navigation_RebateCodes']"));
            rebateCode.Click();
            IWebElement addNewRecordButton = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-b19-btnAddNewRecord']"));
            addNewRecordButton.Click();
            IWebElement selectRebateCode = DriverManager.driver.FindElement(By.XPath($"//td[@data-header='Rebate Code']//span[text()='{rebate_code}']//..//..//input"));
            selectRebateCode.Click();
            IWebElement addToList = DriverManager.driver.FindElement(By.XPath("//div[@id='b18-b19-b6-Button']"));
            addToList.Click();
        }
        [Test]
        public void GatesTab(string num)
        {
            IWebElement gatesTab = DriverManager.driver.FindElement(By.XPath("//div[@id='b18-Navigation_Gates']"));
            gatesTab.Click();
            IWebElement addNewGateButton = DriverManager.driver.FindElement(By.XPath("//button[@id='b18-b28-btnAddNewGate']"));
            addNewGateButton.Click();
            IWebElement selectRebateCode = DriverManager.driver.FindElement(By.XPath("//td[@data-header='Supplier Rebate Code']//select"));
            SelectElement dropdown = new SelectElement(selectRebateCode);
            dropdown.SelectByValue(num);
        }
        [Test]
        public void StatesTab(string name)
        {
            IWebElement statesTab = DriverManager.driver.FindElement(By.XPath("//div[@id='b18-Navigation_States']"));
            statesTab.Click();
            IWebElement nameSearch = DriverManager.driver.FindElement(By.XPath("//input[@id='b18-b32-Input_Name']"));
            nameSearch.SendKeys(name);
            IWebElement pageCheckbox = DriverManager.driver.FindElement(By.XPath($"//span[text()='{name}']//..//..//span//input"));
            pageCheckbox.Click();
            IWebElement markActive = DriverManager.driver.FindElement(By.XPath("//button[text()='MARK ACTIVE']"));
            markActive.Click();
            nameSearch.Clear();
        }
        [Test]
        public void BranchesTab(string name)
        {
            IWebElement branchesTab = DriverManager.driver.FindElement(By.XPath("//div[@id='b18-Navigation_Branches']"));
            branchesTab.Click();
            IWebElement nameSearch = DriverManager.driver.FindElement(By.XPath("//input[@id='b18-b34-Input_BranchNumber2']"));
            nameSearch.SendKeys(name);
            IWebElement pageCheckbox = DriverManager.driver.FindElement(By.XPath($"//span[text()='{name}']//..//..//span//input"));
            pageCheckbox.Click();
            IWebElement markActive = DriverManager.driver.FindElement(By.XPath("//div[@data-block='WebBlocks.RebateBranchesBlock']//button"));
            markActive.Click();
            nameSearch.Clear();
        }
        [Test]
        public void NotesTab(string mess)
        {
            IWebElement notesTab = DriverManager.driver.FindElement(By.XPath("//div[@id='b18-Navigation_Notes']"));
            notesTab.Click();
            IWebElement addNewNote = DriverManager.driver.FindElement(By.XPath("//div[@data-block='WebBlocks.Notes']//button"));
            addNewNote.Click();
            IWebElement message = DriverManager.driver.FindElement(By.XPath("//textarea[@id='b18-b36-b2-TextArea_Note']"));
            message.SendKeys(mess);
            IWebElement addNotes = DriverManager.driver.FindElement(By.XPath("//div[@id='b18-b36-b2-b2-Button']//button"));
            addNotes.Click();
        }
        [Test]
        public void LinkClose()
        {
            IWebElement linkClose = DriverManager.driver.FindElement(By.XPath("//a[@id='lnkClose']"));
            linkClose.Click();
        }
    }
}

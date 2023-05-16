using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenQA.Selenium.Interactions;
using Bussiness_Application_Automation.Pages;

namespace Bussiness_Application_Automation.Actions
{
    internal class IVP_DashboardPage:LoginToOktaPreview
    {
        [Test]
        static void Main(string[] args)
        {
            LoginToOktaPreview IVP = new LoginToOktaPreview();
            IVP.Login();
            IVP.IVPAddNewProgram();
            IVP_NewProgramPage newProgram = new IVP_NewProgramPage();
            newProgram.ImplicitWait();
            newProgram.Approval();
            newProgram.Status();
            newProgram.ShipStartDate();
            newProgram.Await();
            newProgram.ShipEndDate();
            newProgram.Year();
            newProgram.NationalAcct();
            newProgram.Category();
            newProgram.AllBranches();
            newProgram.SubmitDate();
            newProgram.PayMode();
            newProgram.SalesType();
            newProgram.PurchaseType();
            newProgram.AllCustomers();
            newProgram.AllShipTos();
            newProgram.InvoiceRequired();
            newProgram.Await();
            newProgram.CalcFactor();
            newProgram.IvpProgram();
            newProgram.PriceIncrease();
            newProgram.Commodity();
            newProgram.Await();
            newProgram.OwnerName();
            newProgram.GroupId();
            newProgram.Await();
            newProgram.Await();
            newProgram.CustomerSearch();
            newProgram.Await();
            newProgram.SupplierSearch();
            newProgram.JodName();
            newProgram.DealId();
            newProgram.VendorProgramId();
            newProgram.Program();
            newProgram.Comments();
            newProgram.Await();
            newProgram.CreateProgram();
            newProgram.Await_();
            newProgram.GetProgramCodeValue();
            newProgram.Await();
            newProgram.CloseProgram();
            newProgram.Await();
            newProgram.DashboardYearFilter();
            newProgram.Await();
            newProgram.DashboardStatusFilter();
            newProgram.Await_();
            newProgram.ClickProgramLink();
            newProgram.Await();
            newProgram.validateProgramCodeOnEditScreen();
            newProgram.ClickNoteTab();
            newProgram.Await();
            newProgram.SaveProgram();
            newProgram.Await_();
            newProgram.CloseProgram2();
            newProgram.TearDown();
        }
    }
}

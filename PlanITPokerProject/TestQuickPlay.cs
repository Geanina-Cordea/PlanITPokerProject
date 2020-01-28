using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    [TestClass]
    public class TestQuickPlay
    {

        IWebDriver driver;
        [TestMethod]
        public void QuickPlayPage()
        {
            
            var home = new HomePage(driver);
            home.StartQuickPlay();

            var quick = new QuickPlayPage(driver);
            quick.RoomsPage("ana");           
            
            System.Threading.Thread.Sleep(4000);
            driver.Close();
        }
        
    }
}

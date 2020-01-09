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
        [TestMethod]
        public void QuickPlayPage()
        {
            IWebDriver driver;

            var home = new HomePage(driver);
            var roomPage = home.QuickPlay();

            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
        
    }
}

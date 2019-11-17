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
    public class HomePage
    {
        [TestMethod]
        public void QuickPlayPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[@class='btn btn-default btn-lg btn-six']")).Click();
            QuickPlay play = new QuickPlay(driver);
            play.TypeUsername();
            play.ClickOnEnterButton();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }


    }
}

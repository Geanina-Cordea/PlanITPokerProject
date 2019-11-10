using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace GetSocialUnitTest
{
    [TestClass]
    public class GetSocialTest
    {
        [TestMethod]
        public void GetSocialMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath(" //a[@class='social-icon facebook-icon']")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();
        }
    }
}
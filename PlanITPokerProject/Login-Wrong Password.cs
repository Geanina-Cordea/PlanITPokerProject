using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginUnitTest4
{
    [TestClass]
    public class LoginTest4
    {
        [TestMethod]
        public void LoginWrongPasswordMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/authentication/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("inputEmail")).SendKeys("ann.mk@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("floaredecamp");
            driver.FindElement(By.ClassName("btn")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
    }
}

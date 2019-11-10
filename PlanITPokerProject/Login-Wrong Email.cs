using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginUnitTest3
{
    [TestClass]
    public class LoginTest3
    {
        [TestMethod]
        public void LoginWrongEmailMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/authentication/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("inputEmail")).SendKeys("an.mk@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("C@sadelemn38");
            driver.FindElement(By.ClassName("btn")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ForgettenPasswordUnitTest2
{
    [TestClass]
    public class ForgettenPasswordTest2
    {
        [TestMethod]
        public void ForgettenPasswordNoEmailMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/authentication/restorepassword/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("inputEmail")).SendKeys("");
            driver.FindElement(By.ClassName("btn")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
    }
}

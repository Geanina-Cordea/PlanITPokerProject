using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SignUpUnitTest2
{
    [TestClass]
    public class SignUpTest2
    {
        [TestMethod]
        public void SignUpExistentEmailMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/signup/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("inputName")).SendKeys("Ann");
            driver.FindElement(By.Name("inputEmail")).SendKeys("ann.mk@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("5uMMert!medays");
            driver.FindElement(By.ClassName("btn")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
    }
}

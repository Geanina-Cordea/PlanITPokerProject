using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SignUpUnitTest5
{
    [TestClass]
    public class SignUpTest5
    {
        [TestMethod]
        public void SignUpSpecialCharacterNameMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/signup/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("inputName")).SendKeys("&");
            driver.FindElement(By.Name("inputEmail")).SendKeys("racheljohn@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("forever*5One90");
            driver.FindElement(By.ClassName("btn")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
    }
}

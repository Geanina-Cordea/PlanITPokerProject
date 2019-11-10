using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SignUpUnitTest4
{
    [TestClass]
    public class SignUpTest4
    {
        [TestMethod]
        public void SignUpNoNameMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/signup/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("inputName")).SendKeys("");
            driver.FindElement(By.Name("inputEmail")).SendKeys("alice.life@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("gr^^nF1eld");
            driver.FindElement(By.ClassName("btn")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
    }
}

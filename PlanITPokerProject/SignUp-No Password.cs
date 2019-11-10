using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SignUpUnitTest6
{
    [TestClass]
    public class SignUpTest6
    {
        [TestMethod]
        public void SignUpNoPasswordMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/signup/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("inputName")).SendKeys("Mark");
            driver.FindElement(By.Name("inputEmail")).SendKeys("mark.lk@gamil.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("");
            driver.FindElement(By.ClassName("btn")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
    }
}

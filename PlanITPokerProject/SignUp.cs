using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SignUpUnitTest1
{
    [TestClass]
    public class SignUpTest1
    {
        [TestMethod]
        public void SignUpMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/signup/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("inputName")).SendKeys("Ale");
            driver.FindElement(By.Name("inputEmail")).SendKeys("ale.kl@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("Down2Town");
            driver.FindElement(By.ClassName("btn")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
    }
}

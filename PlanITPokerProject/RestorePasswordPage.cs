using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace PlanITPokerProject
{
    public class RestorePasswordPage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public RestorePasswordPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterEmail()
        {
            IWebElement enterEmail = driver.FindElement(By.Name("inputEmail"));
            enterEmail.SendKeys("ann.mk@gmail.com");

            IWebElement restorePassordButton = driver.FindElement(By.ClassName("btn"));
            restorePassordButton.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("navbar")));

            Assert.Contains("message", driver.PageSource);
        }
    }
}

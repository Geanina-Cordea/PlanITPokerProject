using OpenQA.Selenium;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace PlanITPokerProject
{
    public class EnterCredentialsPage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public EnterCredentialsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
      
        public BoardPage EnterEmailAndPassword()
        {
            IWebElement enterEmail = driver.FindElement(By.Name("inputEmail"));
            enterEmail.SendKeys("ann.mk@gmail.com");
            IWebElement enterPassword = driver.FindElement(By.Name("inputPassword"));
            enterPassword.SendKeys("C@sadelemn38");
            IWebElement clickOnLoginButton = driver.FindElement(By.ClassName("btn"));
            clickOnLoginButton.Click();

            Assert.Contains("board", driver.PageSource);

            return new BoardPage(driver);
        }
        
        public BoardPage EnterNameEmailAndPassword()
        {
            IWebElement enterName = driver.FindElement(By.Name("inputName"));
            enterName.SendKeys("Nick");
            IWebElement enterEmail = driver.FindElement(By.Name("inputEmail"));
            enterEmail.SendKeys("nicksmith@gmail.com");
            IWebElement enterPassword = driver.FindElement(By.Name("inputPassword"));
            enterPassword.SendKeys("wint&r20");
            IWebElement clickOnSignupButton = driver.FindElement(By.ClassName("btn"));
            clickOnSignupButton.Click();

            Assert.Contains("board", driver.PageSource);

            return new BoardPage(driver);
        }
        
        public BoardPage EnterUsername()
        {
            IWebElement enterName = driver.FindElement(By.Name("inputName"));
            enterName.SendKeys("Ana");
            IWebElement clickOnEnterButton = driver.FindElement(By.ClassName("btn"));
            clickOnEnterButton.Click();

            Assert.Contains("board", driver.PageSource);

            return new BoardPage(driver);
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

using OpenQA.Selenium;
using Xunit;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{     
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;          
        }

        public EnterCredentialsPage StartQuickPlay()
        {            
            IWebElement clickOnQuickPlay = driver.FindElement(By.CssSelector("[href*='/quickplay']"));
            clickOnQuickPlay.Click();

            Assert.Contains("Enter your name", driver.PageSource);

            return new EnterCredentialsPage(driver);
        }

        public EnterCredentialsPage StartLogin()
        {
            IWebElement clickOnLogin = driver.FindElement(By.CssSelector("[href*='/authentication']"));
            clickOnLogin.Click();


            Assert.Contains("Enter your email", driver.PageSource);

            return new EnterCredentialsPage(driver);
        }
         
        public EnterCredentialsPage StartSignUp()
        {
            IWebElement clickOnSignup = driver.FindElement(By.CssSelector("[href*='/signup']"));
            clickOnSignup.Click();

            Assert.Contains("Enter your name", driver.PageSource);

            return new EnterCredentialsPage(driver);
        }

        public EnterCredentialsPage StartRestorePassword ()
        {
            IWebElement clickOnLogin = driver.FindElement(By.CssSelector("[href*='/authentication']"));
            clickOnLogin.Click();
            IWebElement clickForgottenPassword = driver.FindElement(By.CssSelector("[href*='/authentication/restorepassword']"));
            clickForgottenPassword.Click(); 

            Assert.Contains("Enter your email", driver.PageSource);

            return new EnterCredentialsPage(driver);

        }
        public void StartLoginWithGmail()
        {
            IWebElement clickOnLogin = driver.FindElement(By.CssSelector("[href*='/authentication']"));
            clickOnLogin.Click();
            IWebElement clickGmailButton = driver.FindElement(By.Name("provider"));
            clickGmailButton.Click();

            Assert.Contains("Conectați-vă – Conturi Google", driver.PageSource);
        }
    }
}

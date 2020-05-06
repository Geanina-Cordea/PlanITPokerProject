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

        public QuickPlayPage StartQuickPlay()
        {            
            IWebElement ClickOnQuickPlay = driver.FindElement(By.CssSelector("[href*='/quickplay']"));
            ClickOnQuickPlay.Click();

            Assert.Contains("Enter your name", driver.PageSource);

            return new QuickPlayPage(driver);
        }

        public LoginPage StartLogin()
        {
            IWebElement ClickOnLogin = driver.FindElement(By.CssSelector("[href*='/authentication']"));
            ClickOnLogin.Click();


            Assert.Contains("Enter your email", driver.PageSource);

            return new LoginPage(driver);
        }
         
        public SignupPage StartSignUp()
        {
            IWebElement ClickOnLogin = driver.FindElement(By.CssSelector("[href*='/signup']"));
            ClickOnLogin.Click();

            Assert.Contains("Enter your name", driver.PageSource);

            return new SignupPage(driver);
        }

        public RestorePasswordPage StartRestorePassword ()
        {
            IWebElement ClickOnLogin = driver.FindElement(By.CssSelector("[href*='/authentication']"));
            ClickOnLogin.Click();

            IWebElement ClickForgottenPassword = driver.FindElement(By.CssSelector("[href*='/authentication/restorepassword']"));
            ClickForgottenPassword.Click(); 

            Assert.Contains("Enter your email", driver.PageSource);

            return new RestorePasswordPage(driver);
        }

    }
}

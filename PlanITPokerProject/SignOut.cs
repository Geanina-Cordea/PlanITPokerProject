using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class SignOut
    {
        IWebDriver driver;
        WebDriverWait wait;

        public SignOut(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }


        public void ClickOnSignOut()
        {
            IWebElement profileName = driver.FindElement(By.Id("profile-img"));
            profileName.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("dropdown-toggle")));

            IWebElement signOutButton = driver.FindElement(By.CssSelector("[href*='/authentication/logout/']"));
            signOutButton.Click();

        }
        
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class InvitePage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public InvitePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public void SendInvitation()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("emailsInput")));

            IWebElement enterEmail = driver.FindElement(By.Name("emailsInput"));
            enterEmail.SendKeys("mark.gh@gmail.com");

            IWebElement clickOnSendInvitation = driver.FindElement(By.XPath("//button[contains(text(),'Send invitation')]"));
            clickOnSendInvitation.Click();
        }
    }
}

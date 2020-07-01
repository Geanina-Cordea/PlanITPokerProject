using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PlanITPokerProject
{
    public class PlayroomPage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public PlayroomPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        
        [Obsolete]
        public VotePage EnterStoryname()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));

            IWebElement enterStoryName = driver.FindElement(By.Name("inputName"));
            enterStoryName.SendKeys("Story1");
            IWebElement clickOnSaveAndClose = driver.FindElement(By.XPath("//button[contains(text(),'Save & Close')]"));
            clickOnSaveAndClose.Click();
           
            return new VotePage(driver);
        }

        [Obsolete]
        public InvitePage EnterNewStoryname()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));

            IWebElement enterStoryName = driver.FindElement(By.Name("inputName"));
            enterStoryName.SendKeys("Story1");
            IWebElement clickOnSaveAndClose = driver.FindElement(By.XPath("//button[contains(text(),'Save & Close')]"));
            clickOnSaveAndClose.Click();

            return new InvitePage (driver);
        }
    }
}

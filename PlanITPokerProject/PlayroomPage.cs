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

        By Storyname = By.Name("inputName");
        By SaveCloseButton = By.XPath("//button[contains(text(),'Save & Close')]");
       

        [Obsolete]
        public void EnterStoryname()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));           

            driver.FindElement(Storyname).SendKeys("Story1");
            driver.FindElement(SaveCloseButton).Click();
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class PlayroomPage
    {
        IWebDriver driver;
        By Storyname = By.Name("inputName");
        By SaveCloseButton = By.XPath("//button[contains(text(),'Save & Close')]");

        public PlayroomPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterStoryname()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(Storyname).SendKeys("Story1");
            driver.FindElement(SaveCloseButton).Click();

        }
    }
}

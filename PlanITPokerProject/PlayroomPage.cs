using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        [Obsolete]
        public void EnterStoryname()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));           

            driver.FindElement(Storyname).SendKeys("Story1");
            driver.FindElement(SaveCloseButton).Click();
        }
    }
}

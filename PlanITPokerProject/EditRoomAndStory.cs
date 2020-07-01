using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class EditRoomAndStory
    {
        IWebDriver driver;
        WebDriverWait wait;

        public EditRoomAndStory(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [Obsolete]
        public SignOut RenameCurrentRoomAndStory()
        {
            IWebElement roomName = driver.FindElement(By.XPath("//*[text()='Room1']"));
            roomName.Click();

            IWebElement renameRoom = driver.FindElement(By.ClassName("form-control"));
            renameRoom.Clear();
            renameRoom.SendKeys("PlayRoom");

            IWebElement checkNewRoomName = driver.FindElement(By.ClassName("glyphicon"));
            checkNewRoomName.Click();

            IWebElement storyName = driver.FindElement(By.XPath("//*[text()='Story1']"));
            storyName.Click();

            IWebElement renameStory = driver.FindElement(By.ClassName("form-control"));
            renameStory.Clear();
            renameStory.SendKeys("NewStory");

            IWebElement checkNewStoryName = driver.FindElement(By.ClassName("glyphicon"));
            checkNewStoryName.Click();

            return new SignOut(driver);
        }
    
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class BoardPage
    {
        IWebDriver driver;
        By Roomname = By.Id("createRoomNameInput");
        By CreateButton = By.ClassName("btn");
               
        public BoardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public PlayroomPage EnterRoomname()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(Roomname).SendKeys("Room1");
            driver.FindElement(CreateButton).Click();

            return new PlayroomPage(driver);
        }

    }
}

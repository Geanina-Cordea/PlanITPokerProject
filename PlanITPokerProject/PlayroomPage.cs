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
        By Roomname = By.Id("createRoomNameInput");
        By CreateButton = By.ClassName("btn");
               
        public PlayroomPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void RunPlayroom ()
        {
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(Roomname).SendKeys("Room1");
            driver.FindElement(CreateButton).Click();

        }

    }
}

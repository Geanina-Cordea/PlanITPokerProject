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
    
    public class BoardPage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public BoardPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        By Roomname = By.Id("createRoomNameInput");
        By CreateButton = By.ClassName("btn");        
                
        [Obsolete]
        public PlayroomPage EnterRoomname()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("createRoomNameInput")));

            driver.FindElement(Roomname).SendKeys("Room1");
            driver.FindElement(CreateButton).Click();

            return new PlayroomPage(driver);
        }




    }



}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        [Obsolete]
        public PlayroomPage CreateRoomOnScrumMode()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("createRoomNameInput")));

            IWebElement enterRoomName = driver.FindElement(By.Id("createRoomNameInput"));
            enterRoomName.SendKeys("Room1");
            IWebElement createButton = driver.FindElement(By.ClassName("btn"));
            createButton.Click();

            return new PlayroomPage(driver);
        }
        
        [Obsolete]
        public PlayroomPage CreateRoomOnSequentialModeAndCountdown()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='Create Room']")));

            IWebElement createRoomButton = driver.FindElement(By.XPath("//*[text()='Create Room']"));
            createRoomButton.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("createRoomNameInput")));

            IWebElement enterRoomName = driver.FindElement(By.Id("createRoomNameInput"));
            enterRoomName.SendKeys("Room2");

            SelectElement selectCardsType = new SelectElement(driver.FindElement(By.ClassName("card-set-type")));
            selectCardsType.SelectByValue("3");

            IWebElement countDownTimer = driver.FindElement(By.XPath("//div[@class='ng-scope']//div[1]//div[1]//div[1]//div[1]//div[2]//form[1]//div[8]//div[1]//label[1]"));
            countDownTimer.Click();

            SelectElement selectCountDownValues = new SelectElement(driver.FindElement(By.XPath("//div[@class='col-sm-4']//select[@class='form-control ng-pristine ng-valid']")));
            selectCountDownValues.SelectByValue("4");

            IWebElement createButton = driver.FindElement(By.ClassName("btn"));
            createButton.Click();

            return new PlayroomPage(driver);
        }

        [Obsolete]
        public  PlayroomPage CreateRoomWithTshirtMode()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='Create Room']")));

            IWebElement createRoomButton = driver.FindElement(By.XPath("//*[text()='Create Room']"));
            createRoomButton.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("createRoomNameInput")));

            IWebElement enterRoomName = driver.FindElement(By.Id("createRoomNameInput"));
            enterRoomName.SendKeys("Room5");

            SelectElement selectCardsType = new SelectElement(driver.FindElement(By.ClassName("card-set-type")));
            selectCardsType.SelectByValue("5");

            IWebElement createButton = driver.FindElement(By.ClassName("btn"));
            createButton.Click();

            return new PlayroomPage(driver);
        }         

    }
 }

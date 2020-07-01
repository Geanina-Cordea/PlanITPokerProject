using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class VotePage        
    {
        IWebDriver driver;
        WebDriverWait wait;

        public VotePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [Obsolete]
        public EditRoomAndStory OneVoting()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn-start")));

            IWebElement startButton = driver.FindElement(By.Id("btn-start"));
            startButton.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'Clear')]")));

            IWebElement clickOnCard = driver.FindElement(By.XPath("//div[@class='center-icon ng-binding'][contains(text(),'8')]"));
            clickOnCard.Click();
            
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'Finish')]")));

            IWebElement finishButton = driver.FindElement(By.XPath("//button[contains(text(),'Finish')]"));
            finishButton.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'Clear')]")));

            IWebElement clearVotes = driver.FindElement(By.XPath("//button[contains(text(),'Clear')]"));
            clearVotes.Click();
            
            return new EditRoomAndStory(driver);
        }

        public void DoubleVoting()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn-start")));

            IWebElement startButton = driver.FindElement(By.Id("btn-start"));
            startButton.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'Clear')]")));

            IWebElement clickOnCard = driver.FindElement(By.XPath("//div[@class='center-icon ng-binding'][contains(text(),'13')]"));
            clickOnCard.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("form-control")));

            IWebElement clearVotes = driver.FindElement(By.XPath("//button[contains(text(),'Clear')]"));
            clearVotes.Click();
            
            IWebElement resetTimer = driver.FindElement(By.XPath("//button[contains(text(),'Reset')]"));
            resetTimer.Click();
                       
            IWebElement clickOnNewCard = driver.FindElement(By.XPath("//div[@class='center-icon ng-binding'][contains(text(),'8')]"));
            clickOnNewCard.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("toast-message")));

            IWebElement finishButton = driver.FindElement(By.XPath("//button[contains(text(),'Finish')]"));            
            finishButton.Click();

        }
    }
}

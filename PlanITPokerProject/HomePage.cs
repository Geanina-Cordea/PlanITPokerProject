using OpenQA.Selenium;
using Xunit;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{     
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;          
        }

        public QuickPlayPage StartQuickPlay()
        {            
            IWebElement ClickOnQuickPlay = driver.FindElement(By.CssSelector("[href*='/quickplay']"));
            ClickOnQuickPlay.Click();

            Assert.Contains("Enter your name", driver.PageSource);

            return new QuickPlayPage(driver);
        }             
               
    }
}

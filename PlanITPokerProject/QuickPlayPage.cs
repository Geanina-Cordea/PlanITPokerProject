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
    public class QuickPlayPage
    {

        IWebDriver driver;
        
        public QuickPlayPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By Username = By.Name("inputName");
        By EnterButton = By.ClassName("btn");

        public BoardPage EnterUsername(string inputName)
        {
            driver.FindElement(Username).SendKeys(inputName);
            driver.FindElement(EnterButton).Click();
            
            return new BoardPage(driver);
           
        } 
    }       
}


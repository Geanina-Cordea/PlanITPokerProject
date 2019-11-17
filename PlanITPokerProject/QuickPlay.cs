using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class QuickPlay
    {
        IWebDriver driver;
        By Username = By.Name("inputName");
        By EnterButton = By.ClassName("btn");

        public QuickPlay(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUsername()
        {
            driver.FindElement(Username).SendKeys("Ana");
        }       
        public void ClickOnEnterButton()
        {
            driver.FindElement(EnterButton).Click();
        }

    }
}

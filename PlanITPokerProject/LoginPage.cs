using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By Email = By.Name("inputEmail");
        By Password = By.Name("inputPassword");
        By LoginButton = By.ClassName("btn");

        public BoardPage EnterEmailAndPassword()
        {
            driver.FindElement(Email).SendKeys("ann.mk@gmail.com");
            driver.FindElement(Password).SendKeys("C@sadelemn38");
            driver.FindElement(LoginButton).Click();

            return new BoardPage(driver);
        }
    }
}

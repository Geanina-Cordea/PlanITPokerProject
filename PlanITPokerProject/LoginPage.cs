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
        By Username = By.Name("inputEmail");
        By Password = By.Name("inputPassword");
        By LoginButton = By.ClassName("btn");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUsername()
        {
            driver.FindElement(Username).SendKeys("ann.mk@gmail.com");           
        }
        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("C@sadelemn38");
        }
        public void ClickOnLoginButton()
        {
            driver.FindElement(LoginButton).Click();
        }



    }
}

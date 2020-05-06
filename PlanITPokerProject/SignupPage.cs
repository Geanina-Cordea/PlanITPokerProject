using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class SignupPage
    {
        IWebDriver driver;
        public SignupPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By Name = By.Name("inputName");
        By Email = By.Name("inputEmail");
        By Password = By.Name("inputPassword");
        By SignupButton = By.ClassName("btn");

        public BoardPage EnterNameEmailAndPassword()
        {
            driver.FindElement(Name).SendKeys("Nick");
            driver.FindElement(Email).SendKeys("nicksmth@gmail.com");
            driver.FindElement(Password).SendKeys("wint&r20");
            driver.FindElement(SignupButton).Click();

            return new BoardPage(driver);
        }
    }
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PlanITPokerProject
{
   [TestClass]
    public class PlanITPokerLogin
    {
        [TestMethod]
        public void VerifyPlanITPokerLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/authentication/");
            driver.Manage().Window.Maximize();
            LoginPage login = new LoginPage(driver);
            login.TypeUsername();
            login.TypePassword();
            login.ClickOnLoginButton();
            System.Threading.Thread.Sleep(4000);
            driver.Close();
        }
    }


    }


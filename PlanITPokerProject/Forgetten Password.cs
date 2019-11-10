﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ForgettenPasswordUnitTest1
{
    [TestClass]
    public class ForgettenPasswordTest1
    {
       
        [TestMethod]
        public void ForgettenPasswordMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/authentication/restorepassword/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("inputEmail")).SendKeys("ann.mk@gmail.com");
            driver.FindElement(By.ClassName("btn")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.Close();

        }
    }
}

﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    public class QuickPlayPage
    {
        IWebDriver driver;
        By Username = By.Name("inputName");
        By EnterButton = By.ClassName("btn");

        public QuickPlayPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public PlayroomPage RunRoomsPage(string inputName)
        {
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(Username).SendKeys(inputName);
            driver.FindElement(EnterButton).Click();

            return new PlayroomPage(driver);

        }

    }
}

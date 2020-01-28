using OpenQA.Selenium;
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

        public void StartQuickPlay()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[@class='btn btn-default btn-lg btn-six']")).Click();
            
        }
        
    }
    

}

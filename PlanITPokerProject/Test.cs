using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace PlanITPokerProject
{
    
    public class Test
    {
        IWebDriver driver;       

        public Test()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();

            Assert.Equal("PlanITpoker: Online Scrum planning poker for Agile project teams", driver.Title);
            Assert.Contains("quickplay", driver.PageSource);
        }

        [Fact]
        public void QuickPlayPage()
        {
            var home = new HomePage(driver);
            var quickRoom = home.StartQuickPlay();
            var boardRoom = quickRoom.EnterUsername("Ana");
            var playRoom = boardRoom.EnterRoomname();
            playRoom.EnterStoryname();
            
            driver.Close();
            
        }

    }
}


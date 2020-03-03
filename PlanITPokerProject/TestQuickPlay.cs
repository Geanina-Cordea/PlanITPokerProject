using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanITPokerProject
{
    [TestClass]
    public class TestQuickPlay
    {

        IWebDriver driver;    
                
        [TestMethod]
        public void QuickPlayPage()
        {
            driver = new ChromeDriver();

            var home = new HomePage(driver);
            var quickRoom = home.StartQuickPlay();
            var boardRoom = quickRoom.EnterUsername("Ana");
            var playRoom = boardRoom.EnterRoomname();
            playRoom.EnterStoryname();

            driver.Close();
        }
    }
}

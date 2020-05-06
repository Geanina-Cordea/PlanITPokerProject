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

    public class Tests
    {
        IWebDriver driver;

        public Tests()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();

            Assert.Equal("PlanITpoker: Online Scrum planning poker for Agile project teams", driver.Title);
        }

        [Fact]
        public void StartQuickPlay()
        {
            var home = new HomePage(driver);
            var quickRoom = home.StartQuickPlay();
            var boardRoom = quickRoom.EnterUsername("Ana");
            var playRoom = boardRoom.CreateAndSetUpNewRoom();
            playRoom.EnterStoryname();

            driver.Close();
        }

        [Fact]
        public void LoginAndPlay()
        {
            var home = new HomePage(driver);
            var login = home.StartLogin();
            var boardRoom = login.EnterEmailAndPassword();
            var playRoom = boardRoom.CreateAndSetUpNewRoomWithDiffrentModes();
            playRoom.EnterStoryname();

            driver.Close();
        }

        [Fact]
        public void SignUp()
        {
            var home = new HomePage(driver);
            var signup = home.StartSignUp();
            var boardRoom = signup.EnterNameEmailAndPassword();
            var playRoom = boardRoom.CreateAndSetUpNewRoom();
            playRoom.EnterStoryname();

            driver.Close();
        }

        [Fact]
        public void RestorePassword()
        {
            var home = new HomePage(driver);
            var login = home.StartRestorePassword();
            login.EnterEmail();

            driver.Close();
        }

        [Fact]
        public void LoginWithGmail()
        {
            var home = new HomePage(driver);
            home.StartLoginWithGmail();

            driver.Close();
        }
        
    }
}


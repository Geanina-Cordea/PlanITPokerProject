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
            var boardRoom = quickRoom.EnterUsername();
            var playRoom = boardRoom.CreateRoomOnScrumMode();
            playRoom.EnterStoryname();

            driver.Close();
        }

        [Fact]
        public void EditRoomAndStory()
        {
            var home = new HomePage(driver);
            var quickRoom = home.StartQuickPlay();
            var boardRoom = quickRoom.EnterUsername();
            var playRoom = boardRoom.CreateRoomOnScrumMode();
            var vote = playRoom.EnterStoryname();
            var editRoom = vote.OneVoting();
            editRoom.RenameCurrentRoomAndStory();

            driver.Close();
        }

        [Fact]
        public void LoginOnScrumModeAndCountdown()
        {
            var home = new HomePage(driver);
            var login = home.StartLogin();
            var boardRoom = login.EnterEmailAndPassword();
            var playRoom = boardRoom.CreateRoomOnSequentialModeAndCountdown();
            playRoom.EnterStoryname();

            driver.Close();
        }

        [Fact]
        public void LoginOnTshirtMode()
        {
            var home = new HomePage(driver);
            var login = home.StartLogin();
            var boardRoom = login.EnterEmailAndPassword();
            var playRoom = boardRoom.CreateRoomWithTshirtMode();
            playRoom.EnterStoryname();

            driver.Close();
        }

        [Fact]
        public void LoginOnAndPlayWithOnePLayer()
        {
            var home = new HomePage(driver);
            var login = home.StartLogin();
            var boardRoom = login.EnterEmailAndPassword();
            var playRoom = boardRoom.CreateRoomOnSequentialModeAndCountdown();
            var vote = playRoom.EnterStoryname();
            vote.OneVoting();

            driver.Close();
        }

        [Fact]
        public void SignUp()
        {
            var home = new HomePage(driver);
            var signup = home.StartSignUp();
            var boardRoom = signup.EnterNameEmailAndPassword();
            var playRoom = boardRoom.CreateRoomOnScrumMode();
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

        [Fact]
        public void SignOut()
        {
            var home = new HomePage(driver);
            var quickRoom = home.StartQuickPlay();
            var boardRoom = quickRoom.EnterUsername();
            var playRoom = boardRoom.CreateRoomOnScrumMode();
            var vote = playRoom.EnterStoryname();
            var editRoom = vote.OneVoting();
            var signOut =  editRoom.RenameCurrentRoomAndStory();
            signOut.ClickOnSignOut();

            driver.Close();        
        }

        [Fact]
        public void StartQuickPlayAndDoubleVoting()
        {
            var home = new HomePage(driver);
            var quickRoom = home.StartQuickPlay();
            var boardRoom = quickRoom.EnterUsername();
            var playRoom = boardRoom.CreateRoomOnScrumMode();
            var vote = playRoom.EnterStoryname();
            vote.DoubleVoting();

            driver.Close();
        } 
        
        [Fact]
        public void SendInvitation ()
        {
            var home = new HomePage(driver);
            var quickRoom = home.StartQuickPlay();
            var boardRoom = quickRoom.EnterUsername();
            var playRoom = boardRoom.CreateRoomOnScrumMode();
            var invitePlayer = playRoom.EnterNewStoryname();
            invitePlayer.SendInvitation();

            driver.Close();
        }


    }



}


using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Pages;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()
        {
            driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            //options.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
            driver = new ChromeDriver(options);
            //Implicit Wait
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //User has logged in successfully
            loginPageObj.VerifyUserInHomePage(driver);


            //Home page object intialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);

        }

        [Test]
        public void CreateTime_Test()
        {
            //TM page object initialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTimeRecord(driver);

        }

        [Test]
        public void EditTime_Test()
        {
            //Edit Time Record
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTimeRecord(driver, "", "");

        }

        [Test]
        public void DeleteTime_Test()
        {
            //Delete Time Record
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTimeRecord(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}

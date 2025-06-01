
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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

    public class EmployeeTest : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()
        {
            driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
            driver = new ChromeDriver(options);

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //User has logged in successfully
            loginPageObj.VerifyUserInHomePage(driver);

            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.NavigateToEmployeePage(driver);
        }

        [Test]
        public void CreateEmployeeRecord_Test()
        {
            CreateEmployeePage createEmployeePageObj = new CreateEmployeePage();
            createEmployeePageObj.CreateEmployeeRecord(driver);
        }


        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }



    }
}


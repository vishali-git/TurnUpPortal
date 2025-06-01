using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Pages
{
    public class LoginPage
    {
        //Functions that allow users to login to Turnup portal
        public void LoginActions(IWebDriver driver)
        {
            //Launch Trunup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            try
            {
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("Username textbox not located.");
            }

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5)); //Explicit wait
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName")));

            //Identify username textbox and enter valid user name


            Wait.WaitToBeVisible(driver, "Id", "Password", 7);


            // Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            // Identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath(" //*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);//thread means stop
        }
        // check if user has logged in successfully
        public void VerifyUserInHomePage(IWebDriver driver)
        {
            IWebElement hellohari = driver.FindElement(By.XPath(" //*[@id=\"logoutForm\"]/ul/li/a"));

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("User has logged in successfully. Test Passed!");
            }
            else
            {
                Console.WriteLine("User has not logged in. Test failed");
            }
        }
    }
}
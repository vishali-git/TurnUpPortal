using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Pages
{
    public class CreateEmployeePage
    {
        public void CreateEmployeeRecord(IWebDriver driver)
        {
            try
            {
                IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                createButton.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Create  button hasn't been found");
            }

            //IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            //createButton.Click();
            Thread.Sleep(3000);

            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("Nisha");

            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.SendKeys("Nisha123");

            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.SendKeys("Home001");
            Thread.Sleep(3000);

            //IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            //editContactButton.Click();
            //Thread.Sleep(3000);


            //IWebElement firstNameTextbox = driver.FindElement(By.Id("FirstName"));
            //firstNameTextbox.SendKeys("Nishaa");

            //IWebElement lastNameTextbox = driver.FindElement(By.Id("LastName"));
            //lastNameTextbox.SendKeys("s");


            //IWebElement phoneTextbox = driver.FindElement(By.Id("Phone"));
            //phoneTextbox.SendKeys("12345");
            //Thread.Sleep(2000);

            //IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            //saveContactButton.Click();

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("Moon001!");

            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.SendKeys("Moon001!");

            IWebElement isAdminTickbox = driver.FindElement(By.Id("IsAdmin"));
            isAdminTickbox.Click();
            Thread.Sleep(2000);

            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.SendKeys("Car");

            IWebElement groupsTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groupsTextbox.Click();
            Thread.Sleep(3000);

            IWebElement icOption = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[73]"));
            icOption.Click();

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();


            IWebElement backToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToListButton.Click();
            Thread.Sleep(3000);

            IWebElement goToTheLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToTheLastPageButton.Click();

            IWebElement newName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(newName.Text == "Nisha", "New Name record has not been created");








        }
    }
}
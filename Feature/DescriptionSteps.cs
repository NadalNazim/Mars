using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace MarsQA_1.Feature
{
    [Binding]
    public class DescriptionSteps
    {
        [Given(@"Seller is logged in and is on profile page")]
        public void GivenSellerIsLoggedInAndIsOnProfilePage()
        {
            // Clicks on login button to login to the website
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }
        
        [Given(@"seller enters description into the description box")]
        public void GivenSellerEntersDescriptionIntoTheDescriptionBox(Table table)
        {
            dynamic datas = table.CreateDynamicSet();
            foreach (TableRow row in table.Rows)
            {
                foreach (string value in row.Values)
                {
                    //Clicks on outline write icon
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")).Click();

                    //Clicks and clear textarea
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).Click();
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).Clear();

                    //inputs data into textarea
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).SendKeys(value);

                    //Clicks on Save button
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

                    Task.Delay(5000).Wait();

                }
            }
        }
        
        [Given(@"seller clicks on outline write icon")]
        public void GivenSellerClicksOnOutlineWriteIcon()
        {
            //Clicks on outline write icon
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")).Click();

        }

        [When(@"seller edits the description and saves the data")]
        public void WhenSellerEditsTheDescriptionAndSavesTheData(Table table)
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).Clear();

            //Creates a dynamic object which will hold the values of table
            dynamic datas1 = table.CreateDynamicInstance();

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).SendKeys(datas1.Description);

            //Clicks on Save button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

            Task.Delay(5000).Wait();

        }

        [When(@"seller inputs the description and tries to saves the data")]
        public void WhenSellerInputsTheDescriptionAndTriesToSavesTheData(Table table)
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).Clear();

            //Creates a dynamic object which will hold the values of table
            dynamic datas2 = table.CreateDynamicInstance();

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).SendKeys(datas2.Description);

            //Clicks on Save button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

            Task.Delay(5000).Wait();
        }
        
        [Then(@"a successful message should be displayed")]
        public void ThenASuccessfulMessageShouldBeDisplayed()
        {
           
            //Finds and assign a web element to a local variable
            IWebElement line = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div"));

            //Condition to check wether test case passed or failed
            if (line.Text == "Description has been saved successfully")
            {
                Console.WriteLine("Passed");
            }

            else
            {
                Console.WriteLine("Failed");
            }
        }
        
        [Then(@"a message should appear")]
        public void ThenAMessageShouldAppear()
        {
            //Finds and assign a web element to a local variable
            IWebElement line1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div"));

            //Condition to check wether test case passed or failed
            if (line1.Text == "Description has been saved successfully")
            {
                Console.WriteLine("Passed");
            }

            else
            {
                Console.WriteLine("Failed");
            }
        }
        
        [Then(@"a error message display")]
        public void ThenAErrorMessageDisplay()
        {
            //Finds and assign a web element to a local variable
            IWebElement line2 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div"));

            //Condition to check wether test case passed or failed
            if (line2.Text == "First character can only be digit or letters")
            {
                Console.WriteLine("Passed");
            }

            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}

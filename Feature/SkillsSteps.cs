using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"Seller is logged-in and is in skills section")]
        public void GivenSellerIsLogged_InAndIsInSkillsSection()
        {
            // Clicks on login button to login to the website
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

            //Clicks on Skills section
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }
        
        [Given(@"seller clicks on Add New button")]
        public void GivenSellerClicksOnAddNewButton()
        {
            //Clicks on Add New button under skills section
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
        }
        
        [Given(@"seller clicks on add button")]
        public void GivenSellerClicksOnAddButton()
        {
            //Clicks on Add New button under skills section
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
        }

        [Given(@"seller clicks on edit icon")]
        public void GivenSellerClicksOnEditIcon()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();
        }

        [Given(@"seller clicks on remove icon")]
        public void GivenSellerClicksOnRemoveIcon()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();
            Task.Delay(2000).Wait();

        }
        
        [When(@"seller inputs skill name and selects skill level")]
        public void WhenSellerInputsSkillNameAndSelectsSkillLevel(Table table)
        {
            //Clicks on textbox add skill
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).Click();

            //Creates a dynamic object which will hold the values of table
            dynamic data = table.CreateDynamicInstance();

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys(data.AddSkill);
            Task.Delay(2000).Wait();

            //Clicks on dropdown list and selects an item from the list
            IWebElement dropdown = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));

            SelectElement element = new SelectElement(dropdown);

            element.SelectByText("Intermediate");

            Task.Delay(2000).Wait();
        }
        
        [When(@"seller enters skill name")]
        public void WhenSellerEntersSkillName(Table table)
        {
            //Clicks on textbox add skill
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).Click();

            //Creates a dynamic object which will hold the values of table
            dynamic data1 = table.CreateDynamicInstance();

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys(data1.AddSkill);
            Task.Delay(2000).Wait();

            //Clicks on dropdown list and selects an item from the list

            IWebElement dropdown1 = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));

            SelectElement element1 = new SelectElement(dropdown1);

            element1.SelectByText("Intermediate");

            //Delays the test execution speed.
            Task.Delay(2000).Wait();
        }
        
        [When(@"seller edits skill name and skill level")]
        public void WhenSellerEditsSkillNameAndSkillLevel(Table table)
        {
            //Clicks on textbox add skill under edit 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Click();

            //Clears the textbox add skill under edit
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();


            //Creates a dynamic object which will hold the values of table
            dynamic data2 = table.CreateDynamicInstance();

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys(data2.AddSkill);
            Task.Delay(2000).Wait();

            //Clicks on dropdown list and selects an item from the list

            IWebElement dropdown2 = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));

            SelectElement element2 = new SelectElement(dropdown2);

            element2.SelectByText("Expert");

            Task.Delay(2000).Wait();

        }


        [Then(@"seller clicks on Add button data should be saved")]
        public void ThenSellerClicksOnAddButtonDataShouldBeSaved()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
            Task.Delay(3000).Wait();
        }
        
        [Then(@"a successfull message should be displayed")]
        public void ThenASuccessfullMessageShouldBeDisplayed()
        {
            //Finds and assign a web element to a local variable
            IWebElement msg = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div"));

            //Condition to check wether test case passed or failed
            if (msg.Text == "C# Coding has been added to your skills")
            {
                Console.WriteLine("Passed");
            }

            else
            {
                Console.WriteLine("Failed");
            }
        }
        
        [Then(@"seller clicks on Add button")]
        public void ThenSellerClicksOnAddButton()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
            Task.Delay(3000).Wait();

        }

        [Then(@"an error message should display")]
        public void ThenAnErrorMessageShouldDisplay()
        {
            IWebElement msg1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div"));

            //Condition to check wether test case passed or failed
            if (msg1.Text == "This skill is already exist in your skill list.")
            {
                Console.WriteLine("Passed");
            }

            else
            {
                Console.WriteLine("Failed");
            }
            
        }
        
        [Then(@"seller clicks on update button")]
        public void ThenSellerClicksOnUpdateButton()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
            Task.Delay(2000).Wait();
        }

        [Then(@"a successful message should appear")]
        public void ThenASuccessfulMessageShouldAppear()
        {
            IWebElement msg2 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div"));

            //Condition to check wether test case passed or failed
            if (msg2.Text == "Testing has been updated to your skills")
            {
                Console.WriteLine("Passed");
            }

            else
            {
                Console.WriteLine("Failed");
            }
        }
        
        [Then(@"a message should be displayed")]
        public void ThenAMessageShouldBeDisplayed()
        {
            IWebElement msg3 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div"));

            //Condition to check wether test case passed or failed
            if (msg3.Text == "Testing has been deleted")
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

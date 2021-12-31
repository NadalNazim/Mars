using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Login
    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }
    }
}

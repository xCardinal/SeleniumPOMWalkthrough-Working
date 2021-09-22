﻿using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.tests.utils;
using TechTalk.SpecFlow.Assist;

namespace SeleniumPOMWalkthrough.BDD
{
    public class AP_SharedSteps
    {
        public AP_Website<ChromeDriver> AP_Website { get; } = new AP_Website<ChromeDriver>();
        protected Credentials _credentials;

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
        }

        [Given(@"I enter the following credentials")]
        public void GivenIEnterTheFollowingCredentials(Table table)
        {
            _credentials = table.CreateInstance<Credentials>();
        }

        [When(@"I enter these credentials")]
        public void WhenIEnterTheseCredentials()
        {
            AP_Website.AP_HomePage.InputUserName(_credentials.Username);
            AP_Website.AP_HomePage.InputPassword(_credentials.Password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            AP_Website.AP_HomePage.ClickLoginButton();
        }

        [Then(@"I should be logged in and sent to the inventory page")]
        public void ThenIShouldBeLoggedInAndSentToTheInventoryPage()
        {
            Assert.That(AP_Website.SeleniumDriver.Url, Does.Contain("inventory"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}

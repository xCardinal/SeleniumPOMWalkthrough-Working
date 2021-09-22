using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.tests.utils;
using TechTalk.SpecFlow.Assist;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "AP_Signin")]
    public class AP_SigninSteps : AP_SharedSteps
    {   
        
        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string message)
        {
            Assert.That(AP_Website.AP_HomePage.GetErrorMessage(), Is.EqualTo(message));
        }
    }
}

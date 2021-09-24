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
    //[Binding]
    [Scope(Feature = "Buying")]
    public class BuyingSteps : InventorySteps
    {
        UserDetails userDetails;

        [When(@"I click the shopping cart button")]
        public void WhenIClickTheShoppingCartButton()
        {
            AP_Website.AP_UserPage.ClickShoppingCartButton();
        }
        
        [When(@"I click checkout")]
        public void WhenIClickCheckout()
        {
            AP_Website.AP_UserPage.Checkout();
        }
        
        [When(@"I enter the follwing checkout information")]
        public void WhenIEnterTheFollwingCheckoutInformation(Table table)
        {
            userDetails = table.CreateInstance<UserDetails>();
            AP_Website.AP_UserPage.InputFirstName(userDetails.FirstName);
            AP_Website.AP_UserPage.InputLastName(userDetails.LastName);
            AP_Website.AP_UserPage.InputZipCode(userDetails.PostalCode);
        }
        
        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            AP_Website.AP_UserPage.Continue();
        }
        
        [When(@"I click finish")]
        public void WhenIClickFinish()
        {
            AP_Website.AP_UserPage.Finish();
        }
        
        [Then(@"I should be taken to the checkout completed page\.")]
        public void ThenIShouldBeTakenToTheCheckoutCompletedPage_()
        {
            Assert.That(AP_Website.AP_UserPage.GetHeaderText(), Does.Contain("CHECKOUT: COMPLETE!"));
        }
    }
}

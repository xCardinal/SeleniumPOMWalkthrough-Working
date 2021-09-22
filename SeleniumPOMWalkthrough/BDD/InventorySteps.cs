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
    [Scope(Feature = "Inventory")]
    public class InventorySteps : AP_SharedSteps
    {

        [Given(@"I login successfully with the credentials")]
        public void GivenILoginSuccessfullyWithTheCredentials(Table table)
        {
            base.GivenIAmOnTheHomepage();
            base.GivenIEnterTheFollowingCredentials(table);
            base.WhenIEnterTheseCredentials();
            base.WhenIClickTheLoginButton();
            base.ThenIShouldBeLoggedInAndSentToTheInventoryPage();
        }

        [When(@"I click the Backpack's ADD TO CART button")]
        public void WhenIClickTheBackpackSADDTOCARTButton()
        {
            AP_Website.AP_UserPage.AddBackPackToCart();
        }
        
        [Then(@"Cart's Badge number goes up by one")]
        public void ThenCartSBadgeNumberGoesUpByOne()
        {
            Assert.That(AP_Website.AP_UserPage.NumberOfItemsInCart(), Is.EqualTo(1)); 
        }
    }
}

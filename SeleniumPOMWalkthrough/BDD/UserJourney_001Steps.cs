using System;
using TechTalk.SpecFlow;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "FirstUserJourney")]
    public class UserJourney_001Steps
    {
        //To inport features I need to create instances of the steps!
        InventorySteps inventorySteps = new InventorySteps();

        [Given(@"I login")]
        public void GivenILogin(Table table)
        {
            inventorySteps.GivenILoginSuccessfullyWithTheCredentials(table);
        }
        
        [When(@"ADD TO CART button")]
        public void WhenADDTOCARTButton()
        {
            inventorySteps.WhenIClickTheBackpackSADDTOCARTButton();
        }
        
        [Then(@"Cart's Badge goes up")]
        public void ThenCartSBadgeGoesUp()
        {
            inventorySteps.ThenCartSBadgeNumberGoesUpByOne();
        }
    }
}

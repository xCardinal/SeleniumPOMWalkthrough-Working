//using OpenQA.Selenium.Chrome;
//using SeleniumPOMWalkthrough.lib.pages;
//using NUnit.Framework;

//namespace SeleniumPOMWalkthrough.tests
//{
//    public class AP_UserPortal_Tests
//    {
//        public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();

//        [Test]
//        public void WhenImOnTheTheInventoryPage_WhenIClickTheBasketIcon_ThenIShouldBeAbleToViewMyCart()
//        {
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUserName("standard_user");
//            AP_Website.AP_HomePage.InputPassword("secret_sauce");
//            AP_Website.AP_HomePage.ClickLoginButton();
//            AP_Website.AP_UserPage.ClickShoppingCartButton();
//            var result = AP_Website.AP_UserPage.GetHeaderText();
//            Assert.That(result, Does.Contain("YOUR CART"));
//        }

//        [OneTimeTearDown]
//        public void CleanUp()
//        {
//            //Quites the driver and closes ever associated window
//            AP_Website.SeleniumDriver.Quit();
//            //Realse unmanage resouces
//            AP_Website.SeleniumDriver.Dispose();
//        }
//    }
//}

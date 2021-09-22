//using OpenQA.Selenium.Chrome;
//using SeleniumPOMWalkthrough.lib.pages;
//using NUnit.Framework;

//namespace SeleniumPOMWalkthrough.tests
//{
//    public class AP_Signin_Tests
//    {

//        /*Instantiate our pages in our tests
//         These classes will include the functions for the page.
//        Notice - NO USING STATEMENTS! */

//        public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();

//        [Test]
//        public void GivenIAmOnTheHomePage_WhenISignInWithValidCredentials_ThenIShouldAppearInTheCustomerPortal()
//        {
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUserName("standard_user");
//            AP_Website.AP_HomePage.InputPassword("secret_sauce");
//            AP_Website.AP_HomePage.ClickLoginButton();
//            Assert.That(AP_Website.SeleniumDriver.Url.Contains("inventory"));
//        }

//        [Test]
//        public void GivenIAmOnTheHomePage_WhenISignInWithAnInvalidPassword_ThenIShouldGetAnErrorMessage()
//        {
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.InputUserName("standard_user");
//            AP_Website.AP_HomePage.InputPassword("secret");
//            AP_Website.AP_HomePage.ClickLoginButton();
//            Assert.That(AP_Website.AP_HomePage.GetErrorMessage(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
//        }

//        [Test]
//        public void GivenIAmOnTheHomePage_WhenITryToSignInWithNoCredentialsEter_ThenIShouldGetAnErrorMessage()
//        {
//            AP_Website.AP_HomePage.VisitHomePage();
//            AP_Website.AP_HomePage.ClickLoginButton();
//            Assert.That(AP_Website.AP_HomePage.GetErrorMessage(), Is.EqualTo("Epic sadface: Username is required"));
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

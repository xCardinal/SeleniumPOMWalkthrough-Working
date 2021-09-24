using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_UserPage
    {
        private IWebDriver _seleniumDriver;
        private string _userPageUrl = AppConfigReader.UserPageUrl;
        private IWebElement _shoppingCartButton => _seleniumDriver.FindElement(By.Id("shopping_cart_container"));
        private IWebElement _backpackButton => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));

        private IWebElement _checkoutButton => _seleniumDriver.FindElement(By.Id("checkout"));

        private IWebElement _continueButton => _seleniumDriver.FindElement(By.Id("continue"));

        private IWebElement _finishButton => _seleniumDriver.FindElement(By.Id("finish"));
        public AP_UserPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
        public void GoToUserPage() => _seleniumDriver.Navigate().GoToUrl(_userPageUrl);
        public void ClickShoppingCartButton() => _shoppingCartButton.Click();
        public string GetHeaderText() => _header.Text;

        public void AddBackPackToCart() => _backpackButton.Click();

        public void Checkout() => _checkoutButton.Click();
        public void Continue() => _continueButton.Click();
        public void Finish() => _finishButton.Click();

        public int NumberOfItemsInCart()
        {
            //try
            //    { return Int32.Parse(_itemsInCart.Text); }
            //catch
            //{
            //    return 0;
            //}
            return Int32.Parse(_shoppingCartButton.Text);
        }

        private IWebElement _firstNameField => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lastNameField => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _zipCodeField => _seleniumDriver.FindElement(By.Id("postal-code"));


        public void InputFirstName(string firstName) => _firstNameField.SendKeys(firstName);
        public void InputLastName(string lastName) =>_lastNameField.SendKeys(lastName);
        public void InputZipCode(string zipCode) => _zipCodeField.SendKeys(zipCode);
    }
}

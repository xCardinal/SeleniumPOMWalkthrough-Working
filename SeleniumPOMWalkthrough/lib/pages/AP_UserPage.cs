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


        public AP_UserPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
        public void GoToUserPage() => _seleniumDriver.Navigate().GoToUrl(_userPageUrl);
        public void ClickShoppingCartButton() => _shoppingCartButton.Click();
        public string GetHeaderText() => _header.Text;

        public void AddBackPackToCart() => _backpackButton.Click();

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
    }
}

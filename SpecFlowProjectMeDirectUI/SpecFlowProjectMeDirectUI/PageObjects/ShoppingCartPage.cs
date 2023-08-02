using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectMeDirectUI.PageObjects
{
    public class ShoppingCartPage : BasePageObjects
    {
        private readonly IWebDriver _driver;

        public ShoppingCartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ProductName(string productName) => _driver.FindElement(By.XPath($"//div[@class='inventory_item_name'][contains(text(),'{productName}')]"));
        public IWebElement CartButton => _driver.FindElement(By.CssSelector(".shopping_cart_link"));
        public IWebElement RemoveButton(string productName) => _driver.FindElement(By.XPath($"//div[@class='cart_item']//div[@class='inventory_item_name'][contains(text(),'{productName}')]//following-sibling::div[@class='cart_button']//button[text()='REMOVE']"));
        public IWebElement CheckoutButton => _driver.FindElement(By.CssSelector(".checkout_button"));
        public IWebElement FirstNameInput => _driver.FindElement(By.Id("first-name"));
        public IWebElement LastNameInput => _driver.FindElement(By.Id("last-name"));
        public IWebElement PostalCodeInput => _driver.FindElement(By.Id("postal-code"));
        public IWebElement ContinueButton => _driver.FindElement(By.CssSelector(".cart_button"));
        public IWebElement TotalPrice => _driver.FindElement(By.CssSelector(".summary_total_label"));

        public void FillOutCustomerInfo(string firstName, string lastName, string postalCode)
        {
            FirstNameInput.SendKeys(firstName);
            LastNameInput.SendKeys(lastName);
            PostalCodeInput.SendKeys(postalCode);
        }

        public void ClickCheckoutButton()
        {
            CheckoutButton.Click();
        }
    }
}

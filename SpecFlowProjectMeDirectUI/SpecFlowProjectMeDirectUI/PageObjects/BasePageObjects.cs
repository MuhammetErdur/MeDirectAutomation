using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.DevTools.V112.Browser;
using SpecFlowProjectMeDirectUI.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProjectMeDirectUI.PageObjects
{
    public class BasePageObjects
    {       
        private readonly IWebDriver webDriver;
        private readonly WebDriverWait wait;
        private readonly IWebElement webElement;

        public BasePageObjects(IWebDriver webDriver) 
        {
            this.webDriver = webDriver; 
            DriverHook.InitElements(this.webDriver, this);
            wait = new WebDriverWait(this.webDriver, webDriver);
        }
        public void WaitUntilElementDisplayed(IWebElement webElement)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
          public void ClickElement(IWebElement webElement)
        {
            webElement.Click();
        }
        public void ClickVisibleElement(IWebElement element)
        {
            if (element.Displayed)
            {
                ClickElement(element);
            }
        }

        public void SetText(string element, string text)
        {
            webDriver.FindElement(By.Id(element)).SendKeys(text);
        }

        //Elements...
        #region Elements

        [FindsBy(How = How.Id, Using = "user-name")]
        public IWebElement txtLoginUsername;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement txtLoginPassword;

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement btnLogin;

        [FindsBy(How = How.XPath, Using = "//div[.='Sauce Labs Backpack']")]
        public IWebElement btnBackpack;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")]
        public IWebElement btnAddCartBack;

        [FindsBy(How = How.XPath, Using = "//div[.='Sauce Labs Bike Light']")]
        public IWebElement btnBikeLight;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bike-light")]
        public IWebElement btnAddCartBikeLight;

        [FindsBy(How = How.XPath, Using = "//div[.='Sauce Labs Onesie']")]
        public IWebElement btnOnesie;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-onesie")]
        public IWebElement btnAddCartOnesie;

        [FindsBy(How = How.CssSelector, Using = ".shopping_cart_link")]
        public IWebElement btnShoppingCart;

        [FindsBy(How = How.Id, Using = "remove-sauce-labs-onesie")]
        public IWebElement btnRemoveOnesie;

        [FindsBy(How = How.Id, Using = "checkout")]
        public IWebElement btnCheckOut;

        [FindsBy(How = How.Id, Using = "first-name")]
        public IWebElement txtFirstName;

        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement txtLastName;

        [FindsBy(How = How.Id, Using = "postal-code")]
        public IWebElement txtpostalCode;

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement btnContinue;

        #endregion

        //Checkoutta classname inventory_item_price olan iki alan var. burlardan fiyatları alıp toplucak + 3.20 tax = totaldkiCSSSelectro(.summary_total_label ile uyumlumu bakıcak.) 
    }

}

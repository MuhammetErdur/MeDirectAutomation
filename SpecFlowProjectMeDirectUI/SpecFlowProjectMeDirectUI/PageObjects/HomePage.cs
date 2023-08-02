using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class HomePage : BasePageObjects
    { 
        private readonly IWebDriver webDriver;
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement FilterButton => webDriver.FindElement(By.CssSelector(".product_sort_container"));
        public IWebElement FilterNameAToZ => webDriver.FindElement(By.CssSelector("[value='az']"));
        public IReadOnlyCollection<IWebElement> ProductNames => webDriver.FindElements(By.CssSelector(".inventory_item_name"));


        public void ClickOnFilterButton(IWebElement filterButton)
        {
            WaitUntilElementDisplayed(filterButton).
        }

        public List<string> GetProductNames()
        {
            var productNames = new List<string>();
            foreach (var product in ProductNames)
            {
                productNames.Add(product.Text);
            }
            return productNames;
        }
    }
}


using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowProjectMeDirectUI.PageObjects;
using TechTalk.SpecFlow;


namespace SpecFlowProjectMeDirectUI.Hooks
{
    [Binding]
    public class DriverHook
    { 
        private IWebDriver _driver;
        private HomePage _homePage;
        private ShoppingCartPage _shoppingCartPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _homePage = new HomePage(_driver);
            _shoppingCartPage = new ShoppingCartPage(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}

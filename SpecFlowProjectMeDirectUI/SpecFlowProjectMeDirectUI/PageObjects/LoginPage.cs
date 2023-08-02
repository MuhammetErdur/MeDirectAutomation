using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V112.LayerTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectMeDirectUI.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement UsernameInput => webDriver.FindElement(By.Id("user-name"));
        public IWebElement PasswordInput => webDriver.FindElement(By.Id("password"));
        public IWebElement LoginButton => webDriver.FindElement(By.Id("login-button"));
        public IWebElement ErrorMessage => webDriver.FindElement(By.CssSelector("[data-test='error']"));
 
        {
        public void NavigateToLoginPage(string url)
        {
            webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void EnterUsername(string username)
        {
            UsernameInput.SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            PasswordInput.SendKeys(password);
        }
        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public bool IsErrorMessageDisplayed()
        {
            try
            {
                var errorMessage = ErrorMessage.Text;
                return errorMessage == $"Error: {errorMessage}";
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
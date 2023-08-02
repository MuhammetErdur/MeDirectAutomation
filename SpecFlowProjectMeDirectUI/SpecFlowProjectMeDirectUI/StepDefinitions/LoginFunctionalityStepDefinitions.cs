using OpenQA.Selenium;
using SpecFlowProjectMeDirectUI.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectMeDirectUI.StepDefinitions
{
    [Binding]
    public class LoginFunctionalityStepDefinitions
    {
        LoginPage loginPage = new LoginPage();
        BasePageObjects basePageObjects = new BasePageObjects();

        
        [Given(@"I am on the saucedemo\.com login page")]
        public void GivenIAmOnTheSaucedemo_ComLoginPage()
        {
            loginPage  NavigateToLoginPage("https://www.saucedemo.com/");
        }

        [Given(@"I enter valid username and password")]
        public void GivenIEnterValidUsernameAndPassword()
        {
            LoginPage.EnterUsername("standard_user");

        }

        [Given(@"I click on the login button")]
        public void GivenIClickOnTheLoginButton()
        {
            throw new PendingStepException();
        }

        [When(@"I enter valid username and password")]
        public void WhenIEnterValidUsernameAndPassword()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedİnSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I enter invalid username and/or password")]
        public void WhenIEnterİnvalidUsernameAndOrPassword()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see an error message for invalid credentials")]
        public void ThenIShouldSeeAnErrorMessageForİnvalidCredentials()
        {
            throw new PendingStepException();
        }
    }
}

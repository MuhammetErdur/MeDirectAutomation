using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectMeDirectUI.StepDefinitions
{
    [Binding]
    public class ShoppingCartFunctionalityStepDefinitions
    {
        [When(@"I click on ""([^""]*)""")]
        public void WhenIClickOn(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I click on the ""([^""]*)"" button")]
        public void WhenIClickOnTheButton(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the product ""([^""]*)"" should be seen in the cart")]
        public void ThenTheProductShouldBeSeenİnTheCart(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I clcik on the product ""([^""]*)""")]
        public void WhenIClcikOnTheProduct(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to the cart page")]
        public void WhenINavigateToTheCartPage()
        {
            throw new PendingStepException();
        }

        [Then(@"the cart should show two products")]
        public void ThenTheCartShouldShowTwoProducts()
        {
            throw new PendingStepException();
        }

        [When(@"I remove ""([^""]*)"" from the cart")]
        public void WhenIRemoveFromTheCart(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the cart should not contain the product ""([^""]*)""")]
        public void ThenTheCartShouldNotContainTheProduct(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I Click on checkout button")]
        public void WhenIClickOnCheckoutButton()
        {
            throw new PendingStepException();
        }

        [When(@"I fill out my info")]
        public void WhenIFillOutMyİnfo()
        {
            throw new PendingStepException();
        }

        [When(@"I click on continue button")]
        public void WhenIClickOnContinueButton()
        {
            throw new PendingStepException();
        }

        [Then(@"the cart should display the correct total price for all items")]
        public void ThenTheCartShouldDisplayTheCorrectTotalPriceForAllİtems()
        {
            throw new PendingStepException();
        }
    }
}

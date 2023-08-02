using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectMeDirectUI.StepDefinitions
{
    [Binding]
    public class FilteringProductByNameAndPriceStepDefinitions
    {
        [Given(@"I am on the saucedemo\.com homepage")]
        public void GivenIAmOnTheSaucedemo_ComHomepage()
        {
            Wait
        }

        [When(@"I click on filter box")]
        public void WhenIClickOnFilterBox()
        {
            throw new PendingStepException();
        }

        [When(@"I click Name \(A to Z\)")]
        public void WhenIClickNameAToZ()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see the products in correct order")]
        public void ThenIShouldSeeTheProductsİnCorrectOrder()
        {
            throw new PendingStepException();
        }
    }
}

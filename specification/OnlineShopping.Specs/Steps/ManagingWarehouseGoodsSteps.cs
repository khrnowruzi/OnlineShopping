using System;
using TechTalk.SpecFlow;

namespace OnlineShopping.Specs.Steps
{
    [Binding]
    public class ManagingWarehouseGoodsSteps
    {
        [Given(@"I have entered as a warehouse manager")]
        public void GivenIHaveEnteredAsAWarehouseManager()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I register the following IncomingInvoice")]
        public void WhenIRegisterTheFollowingIncomingInvoice(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I have one product in invoice with the following info")]
        public void WhenIHaveOneProductInInvoiceWithTheFollowingInfo(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to see the product in the list of goods for sell")]
        public void ThenIShouldBeAbleToSeeTheProductInTheListOfGoodsForSell()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have already register of the following IncomingInvoice")]
        public void GivenIHaveAlreadyRegisterOfTheFollowingIncomingInvoice(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have already register of the following SalesInvoice")]
        public void GivenIHaveAlreadyRegisterOfTheFollowingSalesInvoice(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I open the page of view inventory list")]
        public void WhenIOpenThePageOfViewInventoryList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to see the following inventory")]
        public void ThenIShouldBeAbleToSeeTheFollowingInventory(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

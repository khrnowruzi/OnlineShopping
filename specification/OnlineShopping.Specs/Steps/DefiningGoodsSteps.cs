using System;
using TechTalk.SpecFlow;

namespace OnlineShopping.Specs.Steps
{
    [Binding]
    public class DefiningGoodsSteps
    {
        [Given(@"I have entered as a seller account")]
        public void GivenIHaveEnteredAsASellerAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I define the following product")]
        public void WhenIDefineTheFollowingProduct(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to see the product in the list of goods")]
        public void ThenIShouldBeAbleToSeeTheProductInTheListOfGoods()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
